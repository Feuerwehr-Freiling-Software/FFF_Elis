// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFEinsatzdaten
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using ELIS.ELISWCF.ApDataContracts;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFEinsatzdaten", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFEinsatzdaten : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string AdresseField;
    private int AlarmStelleField;
    private WCFFeuerwehr[] AlarmierungenField;
    private string AlarmplanNameField;
    private int AlarmstufeField;
    private string AnruferField;
    private DateTime AusgeruecktField;
    private WCFEinsatzdaten.WCFDatenQuellenTyp DatenQuelleField;
    private int ERM0Field;
    private int ERM1Field;
    private string EinsatzNrField;
    private WCFEinsatzOptionen EinsatzOptionenField;
    private string EinsatzgrundField;
    private string EinsatzzonenIdField;
    private DateTime ErhaltenField;
    private DateTime ErledigtField;
    private WCFFahrzeug[] FahrzeugeField;
    private WCFFahrzeug[] FahrzeugeAlleField;
    private double GPSLatitudeField;
    private double GPSLongitudeField;
    private string GeschaedigterField;
    private int IDField;
    private int Id1Field;
    private string InformationField;
    private double LFKGPSLatitudeField;
    private double LFKGPSLongitudeField;
    private string LFKMldgArchivPfadField;
    private int PrioritaetField;
    private string SirenenprogrammField;
    private WCFEinsatzdaten.WCFEinsatzStatus StatusField;
    private string UTMREFField;
    private string WASMldgArchivPfadField;
    private string WASOriginalAdresseField;
    private string WASnrField;
    private WCFWetterObj WetterInfosField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Adresse
    {
      get => this.AdresseField;
      set => this.AdresseField = value;
    }

    [DataMember]
    public int AlarmStelle
    {
      get => this.AlarmStelleField;
      set => this.AlarmStelleField = value;
    }

    [DataMember]
    public WCFFeuerwehr[] Alarmierungen
    {
      get => this.AlarmierungenField;
      set => this.AlarmierungenField = value;
    }

    [DataMember]
    public string AlarmplanName
    {
      get => this.AlarmplanNameField;
      set => this.AlarmplanNameField = value;
    }

    [DataMember]
    public int Alarmstufe
    {
      get => this.AlarmstufeField;
      set => this.AlarmstufeField = value;
    }

    [DataMember]
    public string Anrufer
    {
      get => this.AnruferField;
      set => this.AnruferField = value;
    }

    [DataMember]
    public DateTime Ausgerueckt
    {
      get => this.AusgeruecktField;
      set => this.AusgeruecktField = value;
    }

    [DataMember]
    public WCFEinsatzdaten.WCFDatenQuellenTyp DatenQuelle
    {
      get => this.DatenQuelleField;
      set => this.DatenQuelleField = value;
    }

    [DataMember]
    public int ERM0
    {
      get => this.ERM0Field;
      set => this.ERM0Field = value;
    }

    [DataMember]
    public int ERM1
    {
      get => this.ERM1Field;
      set => this.ERM1Field = value;
    }

    [DataMember]
    public string EinsatzNr
    {
      get => this.EinsatzNrField;
      set => this.EinsatzNrField = value;
    }

    [DataMember]
    public WCFEinsatzOptionen EinsatzOptionen
    {
      get => this.EinsatzOptionenField;
      set => this.EinsatzOptionenField = value;
    }

    [DataMember]
    public string Einsatzgrund
    {
      get => this.EinsatzgrundField;
      set => this.EinsatzgrundField = value;
    }

    [DataMember]
    public string EinsatzzonenId
    {
      get => this.EinsatzzonenIdField;
      set => this.EinsatzzonenIdField = value;
    }

    [DataMember]
    public DateTime Erhalten
    {
      get => this.ErhaltenField;
      set => this.ErhaltenField = value;
    }

    [DataMember]
    public DateTime Erledigt
    {
      get => this.ErledigtField;
      set => this.ErledigtField = value;
    }

    [DataMember]
    public WCFFahrzeug[] Fahrzeuge
    {
      get => this.FahrzeugeField;
      set => this.FahrzeugeField = value;
    }

    [DataMember]
    public WCFFahrzeug[] FahrzeugeAlle
    {
      get => this.FahrzeugeAlleField;
      set => this.FahrzeugeAlleField = value;
    }

    [DataMember]
    public double GPSLatitude
    {
      get => this.GPSLatitudeField;
      set => this.GPSLatitudeField = value;
    }

    [DataMember]
    public double GPSLongitude
    {
      get => this.GPSLongitudeField;
      set => this.GPSLongitudeField = value;
    }

    [DataMember]
    public string Geschaedigter
    {
      get => this.GeschaedigterField;
      set => this.GeschaedigterField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember(Name = "Id")]
    public int Id1
    {
      get => this.Id1Field;
      set => this.Id1Field = value;
    }

    [DataMember]
    public string Information
    {
      get => this.InformationField;
      set => this.InformationField = value;
    }

    [DataMember]
    public double LFKGPSLatitude
    {
      get => this.LFKGPSLatitudeField;
      set => this.LFKGPSLatitudeField = value;
    }

    [DataMember]
    public double LFKGPSLongitude
    {
      get => this.LFKGPSLongitudeField;
      set => this.LFKGPSLongitudeField = value;
    }

    [DataMember]
    public string LFKMldgArchivPfad
    {
      get => this.LFKMldgArchivPfadField;
      set => this.LFKMldgArchivPfadField = value;
    }

    [DataMember]
    public int Prioritaet
    {
      get => this.PrioritaetField;
      set => this.PrioritaetField = value;
    }

    [DataMember]
    public string Sirenenprogramm
    {
      get => this.SirenenprogrammField;
      set => this.SirenenprogrammField = value;
    }

    [DataMember]
    public WCFEinsatzdaten.WCFEinsatzStatus Status
    {
      get => this.StatusField;
      set => this.StatusField = value;
    }

    [DataMember]
    public string UTMREF
    {
      get => this.UTMREFField;
      set => this.UTMREFField = value;
    }

    [DataMember]
    public string WASMldgArchivPfad
    {
      get => this.WASMldgArchivPfadField;
      set => this.WASMldgArchivPfadField = value;
    }

    [DataMember]
    public string WASOriginalAdresse
    {
      get => this.WASOriginalAdresseField;
      set => this.WASOriginalAdresseField = value;
    }

    [DataMember]
    public string WASnr
    {
      get => this.WASnrField;
      set => this.WASnrField = value;
    }

    [DataMember]
    public WCFWetterObj WetterInfos
    {
      get => this.WetterInfosField;
      set => this.WetterInfosField = value;
    }

    [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
    [DataContract(Name = "WCFEinsatzdaten.WCFDatenQuellenTyp", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
    public enum WCFDatenQuellenTyp
    {
      [EnumMember] WAS,
      [EnumMember] Simulator,
      [EnumMember] Manuell,
    }

    [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
    [DataContract(Name = "WCFEinsatzdaten.WCFEinsatzStatus", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
    public enum WCFEinsatzStatus
    {
      [EnumMember] Alarmiert,
      [EnumMember] Ausgerückt,
      [EnumMember] Erledigt,
      [EnumMember] Geplant,
    }
  }
}
