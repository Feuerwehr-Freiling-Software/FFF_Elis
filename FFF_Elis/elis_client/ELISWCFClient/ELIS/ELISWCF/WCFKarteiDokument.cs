// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFKarteiDokument
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
  [DataContract(Name = "WCFKarteiDokument", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFKarteiDokument : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AlleEinsatztypenField;
    private DateTime ChangedatField;
    private string DateiNameField;
    private string DokNameField;
    private WCFKarteiDokument.WCFDokTyp DokTypField;
    private bool DokumentDruckenField;
    private string[] EinsatztypenField;
    private DateTime ErstellungsDatumField;
    private string HausnummernField;
    private int IDField;
    private int KarteiIdField;
    private int ObjektKarteiIdField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool AlleEinsatztypen
    {
      get => this.AlleEinsatztypenField;
      set => this.AlleEinsatztypenField = value;
    }

    [DataMember]
    public DateTime Changedat
    {
      get => this.ChangedatField;
      set => this.ChangedatField = value;
    }

    [DataMember]
    public string DateiName
    {
      get => this.DateiNameField;
      set => this.DateiNameField = value;
    }

    [DataMember]
    public string DokName
    {
      get => this.DokNameField;
      set => this.DokNameField = value;
    }

    [DataMember]
    public WCFKarteiDokument.WCFDokTyp DokTyp
    {
      get => this.DokTypField;
      set => this.DokTypField = value;
    }

    [DataMember]
    public bool DokumentDrucken
    {
      get => this.DokumentDruckenField;
      set => this.DokumentDruckenField = value;
    }

    [DataMember]
    public string[] Einsatztypen
    {
      get => this.EinsatztypenField;
      set => this.EinsatztypenField = value;
    }

    [DataMember]
    public DateTime ErstellungsDatum
    {
      get => this.ErstellungsDatumField;
      set => this.ErstellungsDatumField = value;
    }

    [DataMember]
    public string Hausnummern
    {
      get => this.HausnummernField;
      set => this.HausnummernField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public int KarteiId
    {
      get => this.KarteiIdField;
      set => this.KarteiIdField = value;
    }

    [DataMember]
    public int ObjektKarteiId
    {
      get => this.ObjektKarteiIdField;
      set => this.ObjektKarteiIdField = value;
    }

    [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
    [DataContract(Name = "WCFKarteiDokument.WCFDokTyp", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
    public enum WCFDokTyp
    {
      [EnumMember] BrandschutzplanDokument,
      [EnumMember] KarteiDokument,
      [EnumMember] StraßenKarteiDeckblatt,
      [EnumMember] ObjektKarteiDeckblatt,
    }
  }
}
