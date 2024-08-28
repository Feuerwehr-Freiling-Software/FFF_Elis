using System;
using ELIS.ELISWCF.ApDataContracts;

namespace ELIS.ELISWCFClient.BusinessObjects;

public class BerAlarmplan
{
    public WCFAlarmplan ap { get; set; }
    public BerichteApDataSet.InfoRow info { get; set; }
    public string tempFolder { get; set; }
    public Guid TicketID { get; set; }
}