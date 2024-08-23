// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFKarteiBlatt
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
  [DataContract(Name = "WCFKarteiBlatt", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFKarteiBlatt : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string[] AlternativNamenField;
    private string AnfahrtField;
    private int AusfahrtsrichtungIDField;
    private string BesonderheitenField;
    private DateTime ChangeDatField;
    private string DataSourceField;
    private bool DeckblattDruckenField;
    private string DisplayNameField;
    private WCFKarteiDokument[] DokumenteField;
    private bool EigeneDatenField;
    private string FeuerwehrGuidField;
    private int FremdSystemIDField;
    private string HausNrStringField;
    private int IDField;
    private string KarteiBlattGuidField;
    private string RichtungField;
    private string StrNameField;
    private string UeberFotoField;
    private WCFWasserentnahmen[] WasserentnahmeStellenField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string[] AlternativNamen
    {
      get => this.AlternativNamenField;
      set => this.AlternativNamenField = value;
    }

    [DataMember]
    public string Anfahrt
    {
      get => this.AnfahrtField;
      set => this.AnfahrtField = value;
    }

    [DataMember]
    public int AusfahrtsrichtungID
    {
      get => this.AusfahrtsrichtungIDField;
      set => this.AusfahrtsrichtungIDField = value;
    }

    [DataMember]
    public string Besonderheiten
    {
      get => this.BesonderheitenField;
      set => this.BesonderheitenField = value;
    }

    [DataMember]
    public DateTime ChangeDat
    {
      get => this.ChangeDatField;
      set => this.ChangeDatField = value;
    }

    [DataMember]
    public string DataSource
    {
      get => this.DataSourceField;
      set => this.DataSourceField = value;
    }

    [DataMember]
    public bool DeckblattDrucken
    {
      get => this.DeckblattDruckenField;
      set => this.DeckblattDruckenField = value;
    }

    [DataMember]
    public string DisplayName
    {
      get => this.DisplayNameField;
      set => this.DisplayNameField = value;
    }

    [DataMember]
    public WCFKarteiDokument[] Dokumente
    {
      get => this.DokumenteField;
      set => this.DokumenteField = value;
    }

    [DataMember]
    public bool EigeneDaten
    {
      get => this.EigeneDatenField;
      set => this.EigeneDatenField = value;
    }

    [DataMember]
    public string FeuerwehrGuid
    {
      get => this.FeuerwehrGuidField;
      set => this.FeuerwehrGuidField = value;
    }

    [DataMember]
    public int FremdSystemID
    {
      get => this.FremdSystemIDField;
      set => this.FremdSystemIDField = value;
    }

    [DataMember]
    public string HausNrString
    {
      get => this.HausNrStringField;
      set => this.HausNrStringField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public string KarteiBlattGuid
    {
      get => this.KarteiBlattGuidField;
      set => this.KarteiBlattGuidField = value;
    }

    [DataMember]
    public string Richtung
    {
      get => this.RichtungField;
      set => this.RichtungField = value;
    }

    [DataMember]
    public string StrName
    {
      get => this.StrNameField;
      set => this.StrNameField = value;
    }

    [DataMember]
    public string UeberFoto
    {
      get => this.UeberFotoField;
      set => this.UeberFotoField = value;
    }

    [DataMember]
    public WCFWasserentnahmen[] WasserentnahmeStellen
    {
      get => this.WasserentnahmeStellenField;
      set => this.WasserentnahmeStellenField = value;
    }
  }
}
