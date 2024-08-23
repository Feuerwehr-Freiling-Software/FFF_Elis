// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFTimerService
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using ELIS.ELISSystemBase;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFTimerService", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFTimerService : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AktivField;
    private string DisplayNameField;
    private int IDField;
    private long IntervalField;
    private DateTime LastSyncField;
    private DateTime NextSyncField;
    private string Parameter1Field;
    private TimerServiceObjServiceTyp ServiceTypField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Aktiv
    {
      get => this.AktivField;
      set => this.AktivField = value;
    }

    [DataMember]
    public string DisplayName
    {
      get => this.DisplayNameField;
      set => this.DisplayNameField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public long Interval
    {
      get => this.IntervalField;
      set => this.IntervalField = value;
    }

    [DataMember]
    public DateTime LastSync
    {
      get => this.LastSyncField;
      set => this.LastSyncField = value;
    }

    [DataMember]
    public DateTime NextSync
    {
      get => this.NextSyncField;
      set => this.NextSyncField = value;
    }

    [DataMember]
    public string Parameter1
    {
      get => this.Parameter1Field;
      set => this.Parameter1Field = value;
    }

    [DataMember]
    public TimerServiceObjServiceTyp ServiceTyp
    {
      get => this.ServiceTypField;
      set => this.ServiceTypField = value;
    }
  }
}
