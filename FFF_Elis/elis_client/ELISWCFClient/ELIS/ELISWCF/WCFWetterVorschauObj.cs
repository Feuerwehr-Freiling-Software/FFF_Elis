// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFWetterVorschauObj
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
  [DataContract(Name = "WCFWetterVorschauObj", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFWetterVorschauObj : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private DateTime DatumField;
    private int RegenwahrscheinlichkeitField;
    private int SkyCodeDayField;
    private string TagField;
    private string TagKurzformField;
    private int TagesMaxTempField;
    private int TagesMinTempField;
    private string WetterLageField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public DateTime Datum
    {
      get => this.DatumField;
      set => this.DatumField = value;
    }

    [DataMember]
    public int Regenwahrscheinlichkeit
    {
      get => this.RegenwahrscheinlichkeitField;
      set => this.RegenwahrscheinlichkeitField = value;
    }

    [DataMember]
    public int SkyCodeDay
    {
      get => this.SkyCodeDayField;
      set => this.SkyCodeDayField = value;
    }

    [DataMember]
    public string Tag
    {
      get => this.TagField;
      set => this.TagField = value;
    }

    [DataMember]
    public string TagKurzform
    {
      get => this.TagKurzformField;
      set => this.TagKurzformField = value;
    }

    [DataMember]
    public int TagesMaxTemp
    {
      get => this.TagesMaxTempField;
      set => this.TagesMaxTempField = value;
    }

    [DataMember]
    public int TagesMinTemp
    {
      get => this.TagesMinTempField;
      set => this.TagesMinTempField = value;
    }

    [DataMember]
    public string WetterLage
    {
      get => this.WetterLageField;
      set => this.WetterLageField = value;
    }
  }
}
