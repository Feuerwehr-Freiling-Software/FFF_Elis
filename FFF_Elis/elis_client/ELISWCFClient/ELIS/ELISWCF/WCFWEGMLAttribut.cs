// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFWEGMLAttribut
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
  [DataContract(Name = "WCFWEGMLAttribut", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFWEGMLAttribut : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private WCFWEGMLAttributTyp AttributField;
    private string WasserEntnahmenGuidField;
    private string WertField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public WCFWEGMLAttributTyp Attribut
    {
      get => this.AttributField;
      set => this.AttributField = value;
    }

    [DataMember]
    public string WasserEntnahmenGuid
    {
      get => this.WasserEntnahmenGuidField;
      set => this.WasserEntnahmenGuidField = value;
    }

    [DataMember]
    public string Wert
    {
      get => this.WertField;
      set => this.WertField = value;
    }
  }
}
