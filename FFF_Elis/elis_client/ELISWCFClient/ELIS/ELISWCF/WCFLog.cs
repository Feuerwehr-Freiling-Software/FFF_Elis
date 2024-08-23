// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFLog
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFLog", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFLog : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string FunktionField;
    private int IDField;
    private string InfoField;
    private string LoginField;
    private string NameField;
    private Guid TicketIDField;
    private DateTime ZeitField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Funktion
    {
      get => this.FunktionField;
      set => this.FunktionField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public string Info
    {
      get => this.InfoField;
      set => this.InfoField = value;
    }

    [DataMember]
    public string Login
    {
      get => this.LoginField;
      set => this.LoginField = value;
    }

    [DataMember]
    public string Name
    {
      get => this.NameField;
      set => this.NameField = value;
    }

    [DataMember]
    public Guid TicketID
    {
      get => this.TicketIDField;
      set => this.TicketIDField = value;
    }

    [DataMember]
    public DateTime Zeit
    {
      get => this.ZeitField;
      set => this.ZeitField = value;
    }
  }
}
