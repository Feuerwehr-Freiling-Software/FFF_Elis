// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFAlarmplanObj
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF.ApDataContracts
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFAlarmplanObj", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFAlarmplanObj : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private int AlarmplanIDField;
    private int AlarmstufeField;
    private WCFFahrzeug FahrzeugField;
    private int FahrzeugIDField;
    private WCFFeuerwehr FeuerwehrField;
    private int IdField;
    private string ZeitraumField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public int AlarmplanID
    {
      get => this.AlarmplanIDField;
      set => this.AlarmplanIDField = value;
    }

    [DataMember]
    public int Alarmstufe
    {
      get => this.AlarmstufeField;
      set => this.AlarmstufeField = value;
    }

    [DataMember]
    public WCFFahrzeug Fahrzeug
    {
      get => this.FahrzeugField;
      set => this.FahrzeugField = value;
    }

    [DataMember]
    public int FahrzeugID
    {
      get => this.FahrzeugIDField;
      set => this.FahrzeugIDField = value;
    }

    [DataMember]
    public WCFFeuerwehr Feuerwehr
    {
      get => this.FeuerwehrField;
      set => this.FeuerwehrField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }

    [DataMember]
    public string Zeitraum
    {
      get => this.ZeitraumField;
      set => this.ZeitraumField = value;
    }
  }
}
