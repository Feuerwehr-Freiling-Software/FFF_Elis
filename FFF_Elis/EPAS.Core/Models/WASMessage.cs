namespace EPAS.Core.Models;

public class WASMessage
{
    public WASMessage(Pdu pdu, string apiKey)
    {
        Pdu = pdu;
        APIKey = apiKey;
    }
    
    public Pdu Pdu { get; set; } = new();
    public string APIKey { get; set; } = "";
}