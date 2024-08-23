// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFObjektKartei
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
  [DataContract(Name = "WCFObjektKartei", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFObjektKartei : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string AnfahrtField;
    private string BesonderheitenField;
    private DateTime ChangeDatField;
    private string DataSourceField;
    private string DisplayNameField;
    private WCFKarteiDokument[] DokumenteField;
    private bool EigeneDatenField;
    private string FeuerwehrGuidField;
    private int FremdSystemIDField;
    private double GPSAltitudeField;
    private double GPSLatitudeField;
    private double GPSLongitudeField;
    private string HausNrStringField;
    private int IDField;
    private string KontaktField;
    private string NameField;
    private string ObjektKarteiGuidField;
    private WCFObjektKategorie ObjektKategorieField;
    private string StraßenNameField;
    private int StraßenkarteiIDField;
    private string UeberFotoField;
    private string WASHinweisField;
    private WCFWasserentnahmen[] WasserentnahmeStellenField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Anfahrt
    {
      get => this.AnfahrtField;
      set => this.AnfahrtField = value;
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
    public double GPSAltitude
    {
      get => this.GPSAltitudeField;
      set => this.GPSAltitudeField = value;
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
    public string Kontakt
    {
      get => this.KontaktField;
      set => this.KontaktField = value;
    }

    [DataMember]
    public string Name
    {
      get => this.NameField;
      set => this.NameField = value;
    }

    [DataMember]
    public string ObjektKarteiGuid
    {
      get => this.ObjektKarteiGuidField;
      set => this.ObjektKarteiGuidField = value;
    }

    [DataMember]
    public WCFObjektKategorie ObjektKategorie
    {
      get => this.ObjektKategorieField;
      set => this.ObjektKategorieField = value;
    }

    [DataMember]
    public string StraßenName
    {
      get => this.StraßenNameField;
      set => this.StraßenNameField = value;
    }

    [DataMember]
    public int StraßenkarteiID
    {
      get => this.StraßenkarteiIDField;
      set => this.StraßenkarteiIDField = value;
    }

    [DataMember]
    public string UeberFoto
    {
      get => this.UeberFotoField;
      set => this.UeberFotoField = value;
    }

    [DataMember]
    public string WASHinweis
    {
      get => this.WASHinweisField;
      set => this.WASHinweisField = value;
    }

    [DataMember]
    public WCFWasserentnahmen[] WasserentnahmeStellen
    {
      get => this.WasserentnahmeStellenField;
      set => this.WasserentnahmeStellenField = value;
    }
  }
}
