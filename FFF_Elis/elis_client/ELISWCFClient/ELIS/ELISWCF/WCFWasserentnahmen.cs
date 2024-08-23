// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFWasserentnahmen
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
  [DataContract(Name = "WCFWasserentnahmen", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFWasserentnahmen : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private double AltitudeField;
    private DateTime ChangeDatumField;
    private DateTime CreateDatumField;
    private WCFELISDataSourceEnum DataSourceTypField;
    private string DisplayNameField;
    private bool EigeneDatenField;
    private string FeuerwehrGuidField;
    private int FremdSystemIDField;
    private WCFWEGMLAttribut[] GMLAttributeField;
    private WCFKarteiBlatt[] KarteiblaetterListField;
    private WCFWEKontrolle[] KontrollenListField;
    private string UTMREFField;
    private string WasserentnahmenGuidField;
    private string anmerkungField;
    private int bmnkarteField;
    private double fassungsvermoegenField;
    private double foerderhoeheField;
    private double geodaetischeSaughoeheField;
    private int hochwertField;
    private int idField;
    private double latitudeField;
    private int leistungField;
    private double longitudeField;
    private string nameField;
    private double nennweiteField;
    private int nummerField;
    private string ortField;
    private int rechtswertField;
    private double saugleitungslaengeField;
    private int typField;
    private WCFWasserEntnahmeStellenTyp typ2Field;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public double Altitude
    {
      get => this.AltitudeField;
      set => this.AltitudeField = value;
    }

    [DataMember]
    public DateTime ChangeDatum
    {
      get => this.ChangeDatumField;
      set => this.ChangeDatumField = value;
    }

    [DataMember]
    public DateTime CreateDatum
    {
      get => this.CreateDatumField;
      set => this.CreateDatumField = value;
    }

    [DataMember]
    public WCFELISDataSourceEnum DataSourceTyp
    {
      get => this.DataSourceTypField;
      set => this.DataSourceTypField = value;
    }

    [DataMember]
    public string DisplayName
    {
      get => this.DisplayNameField;
      set => this.DisplayNameField = value;
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
    public WCFWEGMLAttribut[] GMLAttribute
    {
      get => this.GMLAttributeField;
      set => this.GMLAttributeField = value;
    }

    [DataMember]
    public WCFKarteiBlatt[] KarteiblaetterList
    {
      get => this.KarteiblaetterListField;
      set => this.KarteiblaetterListField = value;
    }

    [DataMember]
    public WCFWEKontrolle[] KontrollenList
    {
      get => this.KontrollenListField;
      set => this.KontrollenListField = value;
    }

    [DataMember]
    public string UTMREF
    {
      get => this.UTMREFField;
      set => this.UTMREFField = value;
    }

    [DataMember]
    public string WasserentnahmenGuid
    {
      get => this.WasserentnahmenGuidField;
      set => this.WasserentnahmenGuidField = value;
    }

    [DataMember]
    public string anmerkung
    {
      get => this.anmerkungField;
      set => this.anmerkungField = value;
    }

    [DataMember]
    public int bmnkarte
    {
      get => this.bmnkarteField;
      set => this.bmnkarteField = value;
    }

    [DataMember]
    public double fassungsvermoegen
    {
      get => this.fassungsvermoegenField;
      set => this.fassungsvermoegenField = value;
    }

    [DataMember]
    public double foerderhoehe
    {
      get => this.foerderhoeheField;
      set => this.foerderhoeheField = value;
    }

    [DataMember]
    public double geodaetischeSaughoehe
    {
      get => this.geodaetischeSaughoeheField;
      set => this.geodaetischeSaughoeheField = value;
    }

    [DataMember]
    public int hochwert
    {
      get => this.hochwertField;
      set => this.hochwertField = value;
    }

    [DataMember]
    public int id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [DataMember]
    public double latitude
    {
      get => this.latitudeField;
      set => this.latitudeField = value;
    }

    [DataMember]
    public int leistung
    {
      get => this.leistungField;
      set => this.leistungField = value;
    }

    [DataMember]
    public double longitude
    {
      get => this.longitudeField;
      set => this.longitudeField = value;
    }

    [DataMember]
    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    [DataMember]
    public double nennweite
    {
      get => this.nennweiteField;
      set => this.nennweiteField = value;
    }

    [DataMember]
    public int nummer
    {
      get => this.nummerField;
      set => this.nummerField = value;
    }

    [DataMember]
    public string ort
    {
      get => this.ortField;
      set => this.ortField = value;
    }

    [DataMember]
    public int rechtswert
    {
      get => this.rechtswertField;
      set => this.rechtswertField = value;
    }

    [DataMember]
    public double saugleitungslaenge
    {
      get => this.saugleitungslaengeField;
      set => this.saugleitungslaengeField = value;
    }

    [DataMember]
    public int typ
    {
      get => this.typField;
      set => this.typField = value;
    }

    [DataMember]
    public WCFWasserEntnahmeStellenTyp typ2
    {
      get => this.typ2Field;
      set => this.typ2Field = value;
    }
  }
}
