// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFEinsatzTypGruppe
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
  [DataContract(Name = "WCFEinsatzTypGruppe", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFEinsatzTypGruppe : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool EMailActiveField;
    private string EinsatzTypField;
    private WCFBenutzerGruppe GruppeField;
    private int IDField;
    private bool SMSActiveField;
    private string SMSAufbauField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool EMailActive
    {
      get => this.EMailActiveField;
      set => this.EMailActiveField = value;
    }

    [DataMember]
    public string EinsatzTyp
    {
      get => this.EinsatzTypField;
      set => this.EinsatzTypField = value;
    }

    [DataMember]
    public WCFBenutzerGruppe Gruppe
    {
      get => this.GruppeField;
      set => this.GruppeField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public bool SMSActive
    {
      get => this.SMSActiveField;
      set => this.SMSActiveField = value;
    }

    [DataMember]
    public string SMSAufbau
    {
      get => this.SMSAufbauField;
      set => this.SMSAufbauField = value;
    }
  }
}
