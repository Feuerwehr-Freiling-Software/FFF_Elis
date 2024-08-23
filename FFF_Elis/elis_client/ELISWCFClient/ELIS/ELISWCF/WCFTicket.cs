// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFTicket
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
  [DataContract(Name = "WCFTicket", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFTicket : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string BerechtigungField;
    private DateTime ErstellungField;
    private int IDField;
    private DateTime LetzterZugriffField;
    private string LoginNameField;
    private string NameField;
    private bool TicketActivField;
    private Guid TicketIDField;
    private int UserIdField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Berechtigung
    {
      get => this.BerechtigungField;
      set => this.BerechtigungField = value;
    }

    [DataMember]
    public DateTime Erstellung
    {
      get => this.ErstellungField;
      set => this.ErstellungField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public DateTime LetzterZugriff
    {
      get => this.LetzterZugriffField;
      set => this.LetzterZugriffField = value;
    }

    [DataMember]
    public string LoginName
    {
      get => this.LoginNameField;
      set => this.LoginNameField = value;
    }

    [DataMember]
    public string Name
    {
      get => this.NameField;
      set => this.NameField = value;
    }

    [DataMember]
    public bool TicketActiv
    {
      get => this.TicketActivField;
      set => this.TicketActivField = value;
    }

    [DataMember]
    public Guid TicketID
    {
      get => this.TicketIDField;
      set => this.TicketIDField = value;
    }

    [DataMember]
    public int UserId
    {
      get => this.UserIdField;
      set => this.UserIdField = value;
    }
  }
}
