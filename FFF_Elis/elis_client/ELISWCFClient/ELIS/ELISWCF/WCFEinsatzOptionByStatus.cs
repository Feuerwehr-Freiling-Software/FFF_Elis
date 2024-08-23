// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFEinsatzOptionByStatus
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
  [DataContract(Name = "WCFEinsatzOptionByStatus", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFEinsatzOptionByStatus : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AlarmiertField;
    private bool AusgerücktField;
    private bool ErledigtField;
    private bool GeplantField;
    private string WertField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Alarmiert
    {
      get => this.AlarmiertField;
      set => this.AlarmiertField = value;
    }

    [DataMember]
    public bool Ausgerückt
    {
      get => this.AusgerücktField;
      set => this.AusgerücktField = value;
    }

    [DataMember]
    public bool Erledigt
    {
      get => this.ErledigtField;
      set => this.ErledigtField = value;
    }

    [DataMember]
    public bool Geplant
    {
      get => this.GeplantField;
      set => this.GeplantField = value;
    }

    [DataMember]
    public string Wert
    {
      get => this.WertField;
      set => this.WertField = value;
    }
  }
}
