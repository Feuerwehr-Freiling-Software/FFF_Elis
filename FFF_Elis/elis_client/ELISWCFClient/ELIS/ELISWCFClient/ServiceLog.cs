// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCFClient.ServiceLog
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using ELIS.ELISWCF;
using ELIS.LogBase;
using System;
using System.Diagnostics;
using System.ServiceModel;

#nullable disable
namespace ELIS.ELISWCFClient
{
  public class ServiceLog : ILogfile
  {
    private static Logfile log;
    private string wcfIp;
    private string wcfPort;

    public ServiceLog(Logfile logFile, string wcfIp, string wcfPort)
    {
      if (ServiceLog.log == null)
        ServiceLog.log = logFile;
      this.wcfIp = wcfIp;
      this.wcfPort = wcfPort;
    }

    public void writelogfile(Exception ex, EventLogEntryType typ, LogCategory location)
    {
      string info = "Fehler: " + ex.Message;
      if (ex.InnerException != null)
        info = info + " - InnerExc: " + ex.InnerException.Message;
      if (!string.IsNullOrEmpty(ex.StackTrace))
        info = info + " - Stack: " + ex.StackTrace;
      this.writelogfile(typ, location, info);
    }

    public void writelogfile(EventLogEntryType typ, LogCategory location, string info)
    {
      ServiceLog.log.writelogfile(typ, location, info);
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          try
          {
            channel.SystemLogWrite(new WCFSystemLog()
            {
              EventType = typ.ToString(),
              Location = location.ToString(),
              Info = info
            });
          }
          catch (Exception ex)
          {
            ServiceLog.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 154);
          }
        }
      }
      catch (Exception ex)
      {
        ServiceLog.log.writelogfile(EventLogEntryType.Error, (LogCategory) 154, "Keine Verbindung zum ELIS Service Log.");
      }
    }
  }
}
