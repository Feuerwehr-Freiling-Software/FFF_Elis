// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFEinsatzTyp
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF.ApDataContracts
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFEinsatzTyp", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFEinsatzTyp : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AktivField;
    private WCFAlarmplanKategorie AlarmplanKategorieField;
    private string BezeichnungField;
    private DateTime ChangedDateField;
    private int IdField;
    private string PrioritaetField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Aktiv
    {
      get => this.AktivField;
      set => this.AktivField = value;
    }

    [DataMember]
    public WCFAlarmplanKategorie AlarmplanKategorie
    {
      get => this.AlarmplanKategorieField;
      set => this.AlarmplanKategorieField = value;
    }

    [DataMember]
    public string Bezeichnung
    {
      get => this.BezeichnungField;
      set => this.BezeichnungField = value;
    }

    [DataMember]
    public DateTime ChangedDate
    {
      get => this.ChangedDateField;
      set => this.ChangedDateField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }

    [DataMember]
    public string Prioritaet
    {
      get => this.PrioritaetField;
      set => this.PrioritaetField = value;
    }
  }
}
