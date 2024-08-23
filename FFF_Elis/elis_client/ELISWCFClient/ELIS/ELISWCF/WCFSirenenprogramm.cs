// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFSirenenprogramm
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
  [DataContract(Name = "WCFSirenenprogramm", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFSirenenprogramm : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool APPEnabledField;
    private string BeschreibungField;
    private bool EMailEnabledField;
    private int IDField;
    private bool PrinterEnabledField;
    private bool SMSEnabledField;
    private string SirenenprogrammWASTextField;
    private bool TTSEnabledField;
    private bool WOLEnabledField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool APPEnabled
    {
      get => this.APPEnabledField;
      set => this.APPEnabledField = value;
    }

    [DataMember]
    public string Beschreibung
    {
      get => this.BeschreibungField;
      set => this.BeschreibungField = value;
    }

    [DataMember]
    public bool EMailEnabled
    {
      get => this.EMailEnabledField;
      set => this.EMailEnabledField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public bool PrinterEnabled
    {
      get => this.PrinterEnabledField;
      set => this.PrinterEnabledField = value;
    }

    [DataMember]
    public bool SMSEnabled
    {
      get => this.SMSEnabledField;
      set => this.SMSEnabledField = value;
    }

    [DataMember]
    public string SirenenprogrammWASText
    {
      get => this.SirenenprogrammWASTextField;
      set => this.SirenenprogrammWASTextField = value;
    }

    [DataMember]
    public bool TTSEnabled
    {
      get => this.TTSEnabledField;
      set => this.TTSEnabledField = value;
    }

    [DataMember]
    public bool WOLEnabled
    {
      get => this.WOLEnabledField;
      set => this.WOLEnabledField = value;
    }
  }
}
