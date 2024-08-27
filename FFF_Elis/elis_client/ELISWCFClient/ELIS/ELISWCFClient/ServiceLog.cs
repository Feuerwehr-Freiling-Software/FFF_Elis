// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCFClient.ServiceLog
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using ELIS.ELISWCF;
using ELISWCFClient.ELIS.LogBase;
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
  }

  public interface ILogfile
  {
  }
}
