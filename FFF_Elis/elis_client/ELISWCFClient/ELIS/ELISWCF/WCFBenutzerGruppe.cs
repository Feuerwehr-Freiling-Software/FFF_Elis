// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFBenutzerGruppe
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFBenutzerGruppe", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFBenutzerGruppe : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private WCFBenutzer[] BenutzerField;
    private string GruppenNameField;
    private int IDField;
    private bool IsADGruppeField;
    private bool StdEMailAktivField;
    private bool StdSMSAktivField;
    private string StdSMSAufbauField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public WCFBenutzer[] Benutzer
    {
      get => this.BenutzerField;
      set => this.BenutzerField = value;
    }

    [DataMember]
    public string GruppenName
    {
      get => this.GruppenNameField;
      set => this.GruppenNameField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public bool IsADGruppe
    {
      get => this.IsADGruppeField;
      set => this.IsADGruppeField = value;
    }

    [DataMember]
    public bool StdEMailAktiv
    {
      get => this.StdEMailAktivField;
      set => this.StdEMailAktivField = value;
    }

    [DataMember]
    public bool StdSMSAktiv
    {
      get => this.StdSMSAktivField;
      set => this.StdSMSAktivField = value;
    }

    [DataMember]
    public string StdSMSAufbau
    {
      get => this.StdSMSAufbauField;
      set => this.StdSMSAufbauField = value;
    }
  }
}
