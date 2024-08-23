// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFEinsatzzonenInfo
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
  [DataContract(Name = "WCFEinsatzzonenInfo", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFEinsatzzonenInfo : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string BezirkField;
    private int EinsatzzonenIdField;
    private string GemeindeField;
    private int ZonenNrField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Bezirk
    {
      get => this.BezirkField;
      set => this.BezirkField = value;
    }

    [DataMember]
    public int EinsatzzonenId
    {
      get => this.EinsatzzonenIdField;
      set => this.EinsatzzonenIdField = value;
    }

    [DataMember]
    public string Gemeinde
    {
      get => this.GemeindeField;
      set => this.GemeindeField = value;
    }

    [DataMember]
    public int ZonenNr
    {
      get => this.ZonenNrField;
      set => this.ZonenNrField = value;
    }
  }
}
