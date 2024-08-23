// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFEinsatzOptionen
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
  [DataContract(Name = "WCFEinsatzOptionen", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFEinsatzOptionen : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string APPIDsField;
    private string EMailIDsField;
    private WCFEinsatzOptionByStatus OptAPPServiceField;
    private WCFEinsatzOptionByStatus OptChecklisteField;
    private WCFEinsatzOptionByStatus OptEinsatzkarteiField;
    private WCFEinsatzOptionByStatus OptEinsatzprotokollField;
    private WCFEinsatzOptionByStatus OptEmailField;
    private WCFEinsatzOptionByStatus OptGoogleMapsField;
    private WCFEinsatzOptionByStatus OptLFKFormularField;
    private WCFEinsatzOptionByStatus OptSMSField;
    private WCFEinsatzOptionByStatus OptText2SpeechField;
    private WCFEinsatzOptionByStatus OptWASMeldungField;
    private string SMSIDsField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string APPIDs
    {
      get => this.APPIDsField;
      set => this.APPIDsField = value;
    }

    [DataMember]
    public string EMailIDs
    {
      get => this.EMailIDsField;
      set => this.EMailIDsField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptAPPService
    {
      get => this.OptAPPServiceField;
      set => this.OptAPPServiceField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptCheckliste
    {
      get => this.OptChecklisteField;
      set => this.OptChecklisteField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptEinsatzkartei
    {
      get => this.OptEinsatzkarteiField;
      set => this.OptEinsatzkarteiField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptEinsatzprotokoll
    {
      get => this.OptEinsatzprotokollField;
      set => this.OptEinsatzprotokollField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptEmail
    {
      get => this.OptEmailField;
      set => this.OptEmailField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptGoogleMaps
    {
      get => this.OptGoogleMapsField;
      set => this.OptGoogleMapsField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptLFKFormular
    {
      get => this.OptLFKFormularField;
      set => this.OptLFKFormularField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptSMS
    {
      get => this.OptSMSField;
      set => this.OptSMSField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptText2Speech
    {
      get => this.OptText2SpeechField;
      set => this.OptText2SpeechField = value;
    }

    [DataMember]
    public WCFEinsatzOptionByStatus OptWASMeldung
    {
      get => this.OptWASMeldungField;
      set => this.OptWASMeldungField = value;
    }

    [DataMember]
    public string SMSIDs
    {
      get => this.SMSIDsField;
      set => this.SMSIDsField = value;
    }
  }
}
