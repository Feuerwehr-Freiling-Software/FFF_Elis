// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFWetterObj
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
  [DataContract(Name = "WCFWetterObj", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFWetterObj : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private DateTime ErstellungsZeitField;
    private int LuftfeuchtigkeitField;
    private string MessortField;
    private int SkyCodeField;
    private int TemperaturField;
    private int TemperaturGefuehltField;
    private WCFWetterVorschauObj[] VorschauField;
    private string WetterLageField;
    private string WindAnzeigeField;
    private int WindgeschwindigkeitField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public DateTime ErstellungsZeit
    {
      get => this.ErstellungsZeitField;
      set => this.ErstellungsZeitField = value;
    }

    [DataMember]
    public int Luftfeuchtigkeit
    {
      get => this.LuftfeuchtigkeitField;
      set => this.LuftfeuchtigkeitField = value;
    }

    [DataMember]
    public string Messort
    {
      get => this.MessortField;
      set => this.MessortField = value;
    }

    [DataMember]
    public int SkyCode
    {
      get => this.SkyCodeField;
      set => this.SkyCodeField = value;
    }

    [DataMember]
    public int Temperatur
    {
      get => this.TemperaturField;
      set => this.TemperaturField = value;
    }

    [DataMember]
    public int TemperaturGefuehlt
    {
      get => this.TemperaturGefuehltField;
      set => this.TemperaturGefuehltField = value;
    }

    [DataMember]
    public WCFWetterVorschauObj[] Vorschau
    {
      get => this.VorschauField;
      set => this.VorschauField = value;
    }

    [DataMember]
    public string WetterLage
    {
      get => this.WetterLageField;
      set => this.WetterLageField = value;
    }

    [DataMember]
    public string WindAnzeige
    {
      get => this.WindAnzeigeField;
      set => this.WindAnzeigeField = value;
    }

    [DataMember]
    public int Windgeschwindigkeit
    {
      get => this.WindgeschwindigkeitField;
      set => this.WindgeschwindigkeitField = value;
    }
  }
}
