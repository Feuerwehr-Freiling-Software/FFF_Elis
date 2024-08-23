// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFAlarmplan
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
  [DataContract(Name = "WCFAlarmplan", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFAlarmplan : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private WCFAlarmplanKategorie AlarmplanKategorieField;
    private WCFAlarmplanObj[] AlarmplanObjListField;
    private string BezeichnungField;
    private string EinsatzzonenIdField;
    private int IdField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public WCFAlarmplanKategorie AlarmplanKategorie
    {
      get => this.AlarmplanKategorieField;
      set => this.AlarmplanKategorieField = value;
    }

    [DataMember]
    public WCFAlarmplanObj[] AlarmplanObjList
    {
      get => this.AlarmplanObjListField;
      set => this.AlarmplanObjListField = value;
    }

    [DataMember]
    public string Bezeichnung
    {
      get => this.BezeichnungField;
      set => this.BezeichnungField = value;
    }

    [DataMember]
    public string EinsatzzonenId
    {
      get => this.EinsatzzonenIdField;
      set => this.EinsatzzonenIdField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }
  }
}
