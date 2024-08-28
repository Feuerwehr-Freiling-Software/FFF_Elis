using ELISWCFService;

namespace FFF_Elis.ELIS_Services;

public class ElisClient
{
    private ELISWCFServiceClient serviceClient;

    private const string URL_ELISServer = "127.0.0.1";
    private const string PORT_ELISServer = "8001";
    private const string ELISLogin = "admin";
    private const string ELISPasswort = "admin";
    
    public ELISWCFServiceClient Client
    {
        get
        {
            var cs = new
                ELISWCFClientFunctions(URL_ELISServer,PORT_ELISServer);
            var isSecured=false;
            serviceClient = cs.getWCFServiceClient(ref isSecured);
            return serviceClient;
        }
    }
    
    public WCFTicket Ticket
    {
        get
        {
            ELISWCFClientFunctions cs = new
                ELISWCFClientFunctions(URL_ELISServer,PORT_ELISServer);
            WCFTicket _ticket = cs.getTicket(ELISLogin, ELISPasswort);
            return _ticket;
        }
    }

}