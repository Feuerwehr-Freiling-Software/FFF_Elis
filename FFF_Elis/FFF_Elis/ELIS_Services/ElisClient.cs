using ELIS.ELISWCF;
using ELIS.ELISWCFClient;

namespace FFF_Elis.ELIS_Services;

public class ElisClient
{
    private ELISWCFServiceClient serviceClient;

    private const string URL_ELISServer = "elisfreiling.ddns.net";
    private const string PORT_ELISServer = "9001";
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