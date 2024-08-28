using System;
using ELIS.ELISWCF;

namespace ELIS.ELISWCFClient.BusinessObjects;

public class BerKarteiObjekt
{
    public int okId { get;set;} 
    public string tempFolder { get;set;} 
    public WCFObjektKartei wok { get;set;} 
    public string feuerwehrname { get;set;} 
    public Guid TicketID { get;set;} 
}