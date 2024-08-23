// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFWakeOnLanClientObj
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
  [DataContract(Name = "WCFWakeOnLanClientObj", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFWakeOnLanClientObj : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AutomaticStartField;
    private int IDField;
    private string IPAdressField;
    private string MACAdressField;
    private string NameField;
    private string StatusField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool AutomaticStart
    {
      get => this.AutomaticStartField;
      set => this.AutomaticStartField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public string IPAdress
    {
      get => this.IPAdressField;
      set => this.IPAdressField = value;
    }

    [DataMember]
    public string MACAdress
    {
      get => this.MACAdressField;
      set => this.MACAdressField = value;
    }

    [DataMember]
    public string Name
    {
      get => this.NameField;
      set => this.NameField = value;
    }

    [DataMember]
    public string Status
    {
      get => this.StatusField;
      set => this.StatusField = value;
    }
  }
}
