using System.Net.Http.Json;
using System.Net.Sockets;
using System.Xml.Serialization;
using EPAS.BusinessLogic.Services;
using EPAS.Core.Models;
using Serilog;
using Serilog.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.SignalR.Client;


Logger? Log = null;

// get API url from config
var builder = new ConfigurationBuilder()
    .AddJsonFile($"appsettings.json", true, true);

var config = builder.Build();

Log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:54341", apiKey: "Z9WtdEfPYecaDOd7h4iY")
    .WriteTo.File("log.txt")
    .CreateLogger();

var clearString = Convert.ToBoolean(config["Testing:ClearString"]);
var useXml = true;
var wasHost = config["WAS:Url"];
var wasPort = Convert.ToInt32(config["WAS:Port"]);
var sendToApi = Convert.ToBoolean(config["API:ApiLogging"]);
var serverUrl = config["API:Url"];
var firebrigadeName = config["API:FireBrigadeName"];
var apiKey = config["API:ApiKey"];
// SignalR Connection


var connection = new HubConnectionBuilder()
    .WithUrl($"{serverUrl}/OperationHub")
    .WithAutomaticReconnect()
    .Build();

connection.Closed += async (error) =>
{
    await Task.Delay(new Random().Next(0,5) * 1000);
    Log.Error("Error in Websocket connection: {ErrorMessage}", error.Message);
    await connection.StartAsync();
};

var proxy = new OperationHubProxy(connection, apiKey, firebrigadeName);

await connection.StartAsync();


Log.Information("Starting WAS Connector");

var dateString1 = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
var filePath =
    "WASConnectorComplete-" +
    dateString1 + " .xml";

while (true)
{
    TcpClient tcpClient = new TcpClient();
    try
    {
        tcpClient = new TcpClient(wasHost, wasPort);
    }
    catch (Exception e)
    {
        Log.Error("Error connecting to WAS: {ErrorMessage}", e.Message);
        Thread.Sleep(15000);
        continue;
    }
    
    var networkStream = tcpClient.GetStream();
    var streamReader = new StreamReader(networkStream);
    var now = DateTime.Now;
    var tmpSave = "";
    
    Log.Information("Starting Reading from WAS");
    
    while (!streamReader.EndOfStream && now.AddSeconds((double) (15 * 4)) > DateTime.Now)
    {
        var tmpString = streamReader.ReadLine();
        tmpSave += tmpString + "\n";
        if (clearString)
        {
            Log.Information("Writing Clear String...");
            using (var clearStringWriter = new StreamWriter(File.Open("WasConnectorCompleteClear"+ dateString1 +".txt", FileMode.Append)))
            {
                clearStringWriter.WriteLine(tmpString);
            }
        }
        else if (useXml && tmpString.StartsWith("</pdu>"))
        {
            Log.Information("Reading data from WAS");
            // Serialize the XML
            var serializer = new XmlSerializer(typeof(Pdu));
            var reader = new StringReader(tmpSave);
            var pdu = (Pdu) serializer.Deserialize(reader);
            
            File.WriteAllText(filePath, tmpSave);

            if (sendToApi)
            {
                Task.Run(() => SendDataToApi(pdu));
            }
            
            Log.Information("Anzahl Auftragsliste: {OrderlistCount}", pdu.Orderlist.Order.Count);
            tmpSave = "";
        }
    }
    now = DateTime.Now;
    tcpClient?.Close();
    networkStream?.Close();
    tcpClient = null;
    networkStream = null;
    streamReader = null;
    
    Thread.Sleep(15000);
    Log.Information("Waiting for new data");
}

async Task SendDataToApi(Pdu pdu)
{
    try
    {
        var res = await proxy.NewOperation(new WASMessage(pdu));
        Log.Information("Response: {Response}", res);
    }
    catch (Exception e)
    {
        Log.Error("Error sending data to API: {ErrorMessage}", e.Message);
    }
}

