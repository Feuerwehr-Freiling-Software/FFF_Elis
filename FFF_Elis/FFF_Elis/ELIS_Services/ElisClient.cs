using System.ServiceModel;
using ELISWCFService;

namespace FFF_Elis.ELIS_Services;

public class ElisClient
{
    private ELISWCFServiceClient serviceClient;

    private const string URL_ELISServer = "127.0.0.1";
    private const string PORT_ELISServer = "8010";
    private const string ELISLogin = "admin";
    private const string ELISPasswort = "admin";
    
    public ELISWCFServiceClient Client
    {
        get
        {
            serviceClient = new ELISWCFServiceClient(ELISWCFServiceClient.EndpointConfiguration.ELISWCFTcpBinding_IELISWCFService, new EndpointAddress("net.tcp://127.0.0.1:8000/ELISWCFService"));
            return serviceClient;
        }
    }
    
    public WCFTicket Ticket
    {
        get
        {
            var _ticket = Client.CreateTicket(new CreateTicketRequest(ELISLogin, ELISPasswort));
            return _ticket.CreateTicketResult;
        }
    }

}