using System;
using ELIS.ELISWCF;

namespace ELIS.ELISWCFClient.BusinessObjects;

public class BerKarteiStraße
{
    public int kbId { get; set; }
    public string tempFolder { get; set; }
    public WCFKarteiBlatt wkb { get; set; }
    public string feuerwehrname { get; set; }
    public Guid TicketID { get; set; }
}