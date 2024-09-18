using System.Globalization;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;
using Serilog;
using TestWASConnection;

var Log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:5341", apiKey: "Z9WtdEfPYecaDOd7h4iY")
    .CreateLogger();

Log.Information("Starting WAS Connector");

var dateString1 = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
var filePath =
    @"C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\TestWASConnection\TestFiles\WASConnectorComplete " +
    dateString1 + " .xml";

while (true)
{
    var tcpClient = new TcpClient("127.0.0.1", 4321);
    var networkStream = tcpClient.GetStream();
    var streamReader = new StreamReader(networkStream);
    var now = DateTime.Now;
    var tmpSave = "";
    
    while (!streamReader.EndOfStream && now.AddSeconds((double) (15 * 4)) > DateTime.Now)
    {
        var tmpString = streamReader.ReadLine();
        tmpSave += tmpString + "\n";
        if (tmpString.StartsWith("</pdu>"))
        {
            // Serialize the XML
            var serializer = new XmlSerializer(typeof(Pdu));
            var reader = new StringReader(tmpSave);
            var pdu = (Pdu) serializer.Deserialize(reader);
            
            File.WriteAllText(filePath, tmpSave);
            // TODO: Send data to API
            
            Log.Information("Anzahl Auftragsliste: {OrderlistCount}", pdu.Orderlist.Order.Count);
            tmpSave = "";
        }
    }
    now = DateTime.Now;
    tcpClient?.Close();
    networkStream?.Close();
    tcpClient = (TcpClient) null;
    networkStream = (NetworkStream) null;
    streamReader = (StreamReader) null;
    
    Thread.Sleep(15000);
    Console.WriteLine("Waiting for new data");
}