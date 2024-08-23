// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFFremdSystem
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
  [DataContract(Name = "WCFFremdSystem", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFFremdSystem : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private int IDField;
    private DateTime LastDataSyncField;
    private string NameField;
    private string RemotePasswordField;
    private string RemoteUserField;
    private bool SendRequestField;
    private string WCFAdresseField;
    private string WCFPortField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public DateTime LastDataSync
    {
      get => this.LastDataSyncField;
      set => this.LastDataSyncField = value;
    }

    [DataMember]
    public string Name
    {
      get => this.NameField;
      set => this.NameField = value;
    }

    [DataMember]
    public string RemotePassword
    {
      get => this.RemotePasswordField;
      set => this.RemotePasswordField = value;
    }

    [DataMember]
    public string RemoteUser
    {
      get => this.RemoteUserField;
      set => this.RemoteUserField = value;
    }

    [DataMember]
    public bool SendRequest
    {
      get => this.SendRequestField;
      set => this.SendRequestField = value;
    }

    [DataMember]
    public string WCFAdresse
    {
      get => this.WCFAdresseField;
      set => this.WCFAdresseField = value;
    }

    [DataMember]
    public string WCFPort
    {
      get => this.WCFPortField;
      set => this.WCFPortField = value;
    }
  }
}
