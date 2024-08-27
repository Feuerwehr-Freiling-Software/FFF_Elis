// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCFClient.Berichte
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using CrystalDecisions.CrystalReports.Engine;
//using ELIS.ELISConfiguration;
using ELIS.ELISWCF;
using ELIS.ELISWCF.ApDataContracts;
//using ELIS.GeoTools;
//using ELIS.LogBase;
//using ELIS.Reports;
//using ELIS.Reports.Berichte;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.ServiceModel;
using ELISWCFClient.ELIS.LogBase;

#nullable disable
namespace ELIS.ELISWCFClient
{
  public class Berichte
  {
    private static Logfile log;
    private string wcfIp;
    private string wcfPort;

    public Berichte(Logfile logFile, string wcfIp, string wcfPort)
    {
      if (ELIS.ELISWCFClient.Berichte.log == null)
        ELIS.ELISWCFClient.Berichte.log = logFile;
      this.wcfIp = wcfIp;
      this.wcfPort = wcfPort;
    }

    public BerKarteiStraße getStraßenKarteiBericht(
      int kbId,
      string tempFolder,
      WCFKarteiBlatt wkb,
      string feuerwehrname,
      Guid TicketID)
    {
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          BerichteDataSet berichteDataSet = this.getBerichteDataSet(channel, tempFolder, TicketID);
          byte[] numArray1 = new byte[0];
          try
          {
            if (channel.FileCheckExists(wkb.UeberFoto, WCFFileTyp.Document, TicketID))
              numArray1 = this.GetImagefromWCF(tempFolder, wkb.UeberFoto, TicketID);
          }
          catch (Exception ex)
          {
            // TODO: Custom Logging
            // ELIS.ELISWCFClient.Berichte.log.writelogfile(EventLogEntryType.Error, (LogCategory) 107, ex.Message);
          }
          try
          {
            foreach (WCFWasserentnahmen wcfWasserentnahmen in wkb.WasserentnahmeStellen)
            {
              string str1 = wcfWasserentnahmen.nummer.ToString() + " " + wcfWasserentnahmen.name;
              WCFWasserEntnahmeStellenTyp typ2 = wcfWasserentnahmen.typ2;
              switch (typ2)
              {
                case WCFWasserEntnahmeStellenTyp.OH:
                case WCFWasserEntnahmeStellenTyp.UH:
                  str1 = str1 + " " + wcfWasserentnahmen.leistung.ToString() + " l/min";
                  break;
                case WCFWasserEntnahmeStellenTyp.Brunnen:
                case WCFWasserEntnahmeStellenTyp.Saugstelle:
                  str1 = str1 + " " + wcfWasserentnahmen.leistung.ToString() + " l/min";
                  break;
                case WCFWasserEntnahmeStellenTyp.Löschteich:
                  str1 = str1 + " " + wcfWasserentnahmen.fassungsvermoegen.ToString() + " m\u00B3";
                  break;
                case WCFWasserEntnahmeStellenTyp.LöschwasserBehälter:
                  str1 = str1 + " " + wcfWasserentnahmen.fassungsvermoegen.ToString() + " m\u00B3";
                  break;
                case WCFWasserEntnahmeStellenTyp.Pumpe:
                  str1 = str1 + " " + wcfWasserentnahmen.leistung.ToString() + " l/min";
                  break;
              }
              BerichteDataSet.WasserEntnahmenDataTable wasserEntnahmen = berichteDataSet.WasserEntnahmen;
              int id = wcfWasserentnahmen.id;
              string str2 = str1;
              string ort = wcfWasserentnahmen.ort;
              string anmerkung = wcfWasserentnahmen.anmerkung;
              int nummer = wcfWasserentnahmen.nummer;
              int leistung = wcfWasserentnahmen.leistung;
              string str3 = wcfWasserentnahmen.rechtswert.ToString();
              string str4 = wcfWasserentnahmen.hochwert.ToString();
              int bmnkarte = wcfWasserentnahmen.bmnkarte;
              string utmref = wcfWasserentnahmen.UTMREF;
              double longitude = wcfWasserentnahmen.longitude;
              double latitude = wcfWasserentnahmen.latitude;
              double altitude = wcfWasserentnahmen.Altitude;
              byte[] numArray2 = new byte[0];
              typ2 = wcfWasserentnahmen.typ2;
              string str5 = typ2.ToString();
              wasserEntnahmen.AddWasserEntnahmenRow(id, 1, str2, ort, anmerkung, nummer, leistung, str3, str4, bmnkarte, utmref, longitude, latitude, altitude, "", numArray2, 0.0, 0.0, str5);
            }
          }
          catch (Exception ex)
          {
            // TODO: Custom Logging
            // ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 107);
          }
          bool flag1 = string.IsNullOrEmpty(wkb.Anfahrt);
          bool flag2 = string.IsNullOrEmpty(wkb.Besonderheiten);
          bool flag3 = wkb.WasserentnahmeStellen.Length == 0;
          bool flag4 = string.IsNullOrEmpty(wkb.UeberFoto);
          string str6 = "";
          string str7 = wkb.Anfahrt;
          bool eigeneDaten = wkb.EigeneDaten;
          if (!eigeneDaten)
          {
            string str8 = "Vom Feuerwehrhaus " + feuerwehrname + ":";
            str6 = "Quelle: " + feuerwehrname;
            string newLine = Environment.NewLine;
            string anfahrt = wkb.Anfahrt;
            str7 = str8 + newLine + anfahrt;
          }
          berichteDataSet.Z_BerKarteiBlatt.AddZ_BerKarteiBlattRow(wkb.ID, numArray1, wkb.StrName, wkb.HausNrString, eigeneDaten ? wkb.Richtung : str6, str7, wkb.Besonderheiten, wkb.ChangeDat, !string.IsNullOrEmpty(str6), "", wkb.DisplayName, flag1, flag2, flag3, flag4, "", "", "", "", "", "", true, "");
          BerKarteiStraße straßenKarteiBericht = new BerKarteiStraße();
          ((ReportDocument) straßenKarteiBericht).SetDataSource((DataSet) berichteDataSet);
          foreach (ReportDocument subreport in (ReadOnlyCollectionBase) ((ReportDocument) straßenKarteiBericht).Subreports)
            subreport.SetDataSource((DataSet) berichteDataSet);
          return straßenKarteiBericht;
        }
      }
      catch (Exception ex)
      {
        ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 107);
        return new BerKarteiStraße();
      }
    }

    public BerKarteiObjekt getObjektKarteiBericht(
      int okId,
      string tempFolder,
      WCFObjektKartei wok,
      string feuerwehrname,
      Guid TicketID)
    {
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          BerichteDataSet berichteDataSet = this.getBerichteDataSet(channel, tempFolder, TicketID);
          byte[] numArray1 = new byte[0];
          try
          {
            if (channel.FileCheckExists(wok.UeberFoto, WCFFileTyp.Document, TicketID))
              numArray1 = this.GetImagefromWCF(tempFolder, wok.UeberFoto, TicketID);
          }
          catch (Exception ex)
          {
            ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 107);
          }
          try
          {
            foreach (WCFWasserentnahmen wcfWasserentnahmen in wok.WasserentnahmeStellen)
            {
              string str1 = wcfWasserentnahmen.nummer.ToString() + " " + wcfWasserentnahmen.name;
              WCFWasserEntnahmeStellenTyp typ2 = wcfWasserentnahmen.typ2;
              double num1;
              switch (typ2)
              {
                case WCFWasserEntnahmeStellenTyp.OH:
                case WCFWasserEntnahmeStellenTyp.UH:
                  str1 = str1 + " " + wcfWasserentnahmen.leistung.ToString() + " l/min";
                  break;
                case WCFWasserEntnahmeStellenTyp.Brunnen:
                case WCFWasserEntnahmeStellenTyp.Saugstelle:
                  str1 = str1 + " " + wcfWasserentnahmen.leistung.ToString() + " l/min";
                  break;
                case WCFWasserEntnahmeStellenTyp.Löschteich:
                  string str2 = str1;
                  num1 = wcfWasserentnahmen.fassungsvermoegen;
                  string str3 = num1.ToString();
                  str1 = str2 + " " + str3 + " m\u00B3";
                  break;
                case WCFWasserEntnahmeStellenTyp.LöschwasserBehälter:
                  string str4 = str1;
                  num1 = wcfWasserentnahmen.fassungsvermoegen;
                  string str5 = num1.ToString();
                  str1 = str4 + " " + str5 + " m\u00B3";
                  break;
                case WCFWasserEntnahmeStellenTyp.Pumpe:
                  str1 = str1 + " " + wcfWasserentnahmen.leistung.ToString() + " l/min";
                  break;
              }
              string str6 = wcfWasserentnahmen.anmerkung;
              if (wok.GPSLongitude > 0.0 && wok.GPSLatitude > 0.0 && wcfWasserentnahmen.longitude > 0.0 && wcfWasserentnahmen.latitude > 0.0)
              {
                double distance = GPSRechner.GetDistance(wok.GPSLongitude, wok.GPSLatitude, wcfWasserentnahmen.longitude, wcfWasserentnahmen.latitude);
                if (distance > 0.0)
                {
                  if (!string.IsNullOrEmpty(str6))
                    str6 += "; ";
                  str6 = str6 + "Entfernung ca. " + distance.ToString("F0") + " m";
                }
              }
              if (wok.GPSAltitude > 0.0 && wcfWasserentnahmen.Altitude > 0.0)
              {
                double num2 = wok.GPSAltitude - wcfWasserentnahmen.Altitude;
                if (!string.IsNullOrEmpty(str6))
                  str6 += "; ";
                if (num2 > 0.0)
                {
                  str6 = str6 + "Wasserentnahme liegt ca. " + num2.ToString("F0") + " m tiefer";
                }
                else
                {
                  string str7 = str6;
                  num1 = num2 * -1.0;
                  string str8 = num1.ToString("F0");
                  str6 = str7 + "Wasserentnahme liegt ca. " + str8 + " m höher";
                }
              }
              BerichteDataSet.WasserEntnahmenDataTable wasserEntnahmen = berichteDataSet.WasserEntnahmen;
              int id = wcfWasserentnahmen.id;
              string str9 = str1;
              string ort = wcfWasserentnahmen.ort;
              string str10 = str6;
              int nummer = wcfWasserentnahmen.nummer;
              int leistung = wcfWasserentnahmen.leistung;
              string str11 = wcfWasserentnahmen.rechtswert.ToString();
              string str12 = wcfWasserentnahmen.hochwert.ToString();
              int bmnkarte = wcfWasserentnahmen.bmnkarte;
              string utmref = wcfWasserentnahmen.UTMREF;
              double longitude = wcfWasserentnahmen.longitude;
              double latitude = wcfWasserentnahmen.latitude;
              double altitude = wcfWasserentnahmen.Altitude;
              byte[] numArray2 = new byte[0];
              typ2 = wcfWasserentnahmen.typ2;
              string str13 = typ2.ToString();
              wasserEntnahmen.AddWasserEntnahmenRow(id, 1, str9, ort, str10, nummer, leistung, str11, str12, bmnkarte, utmref, longitude, latitude, altitude, "", numArray2, 0.0, 0.0, str13);
            }
          }
          catch (Exception ex)
          {
            ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 107);
          }
          bool flag1 = string.IsNullOrEmpty(wok.Anfahrt);
          bool flag2 = string.IsNullOrEmpty(wok.Besonderheiten);
          bool flag3 = wok.WasserentnahmeStellen.Length == 0;
          bool flag4 = string.IsNullOrEmpty(wok.UeberFoto);
          bool flag5 = string.IsNullOrEmpty(wok.Kontakt);
          string str14 = "";
          string str15 = wok.Anfahrt;
          bool eigeneDaten = wok.EigeneDaten;
          if (!eigeneDaten)
          {
            string str16 = "Vom Feuerwehrhaus " + feuerwehrname + ":";
            str14 = "Quelle: " + feuerwehrname;
            string newLine = Environment.NewLine;
            string anfahrt = wok.Anfahrt;
            str15 = str16 + newLine + anfahrt;
          }
          string str17 = "";
          if (wok.GPSLatitude > 0.0 && wok.GPSLongitude > 0.0)
            str17 = UTMREFRechner.getUTMREFByGPS(wok.GPSLatitude, wok.GPSLongitude);
          berichteDataSet.Z_BerKarteiBlatt.AddZ_BerKarteiBlattRow(wok.ID, numArray1, wok.StraßenName, wok.HausNrString, eigeneDaten ? wok.StraßenName : str14, str15, wok.Besonderheiten, wok.ChangeDat, !string.IsNullOrEmpty(str14), "", wok.DisplayName, flag1, flag2, flag3, flag4, wok.Name, wok.Kontakt, wok.GPSLatitude.ToString(), wok.GPSLongitude.ToString(), wok.GPSAltitude.ToString(), str17, flag5, wok.ObjektKategorie.Name);
          BerKarteiObjekt objektKarteiBericht = new BerKarteiObjekt();
          ((ReportDocument) objektKarteiBericht).SetDataSource((DataSet) berichteDataSet);
          foreach (ReportDocument subreport in (ReadOnlyCollectionBase) ((ReportDocument) objektKarteiBericht).Subreports)
            subreport.SetDataSource((DataSet) berichteDataSet);
          return objektKarteiBericht;
        }
      }
      catch (Exception ex)
      {
        ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 107);
        return new BerKarteiObjekt();
      }
    }

    private byte[] GetImagefromWCF(string tempFolder, string fileName, Guid TicketID)
    {
      byte[] buffer = new byte[0];
      try
      {
        WCFClientFileTransfer clientFileTransfer = new WCFClientFileTransfer(ELIS.ELISWCFClient.Berichte.log, this.wcfIp, this.wcfPort);
        if (!tempFolder.EndsWith("\\"))
          tempFolder += "\\";
        string filePath = tempFolder + fileName;
        string fileName1 = fileName;
        Guid TicketID1 = TicketID;
        if (clientFileTransfer.FileDownload(filePath, fileName1, WCFFileTyp.Document, TicketID1))
        {
          MediaTypeNames.Image.FromFile(tempFolder + fileName).Save(tempFolder + fileName + "_tmp2.jpg", ImageFormat.Jpeg);
          using (FileStream fileStream = new FileStream(tempFolder + fileName + "_tmp2.jpg", FileMode.Open, FileAccess.Read))
          {
            buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, Convert.ToInt32(fileStream.Length));
          }
        }
        else
          ELIS.ELISWCFClient.Berichte.log.writelogfile(EventLogEntryType.Warning, (LogCategory) 109, "GetImagefromWCF: Datei " + fileName + " konnte nicht von ELIS Service übermittelt werden.");
      }
      catch (Exception ex)
      {
        ELIS.ELISWCFClient.Berichte.log.writelogfile(EventLogEntryType.Error, (LogCategory) 109, "GetImagefromWCF: " + ex.Message);
        ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 109);
      }
      return buffer;
    }

    public BerAlarmplan getAlarmplanBericht(
      WCFAlarmplan ap,
      BerichteApDataSet.InfoRow info,
      string tempFolder,
      Guid TicketID)
    {
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          BerichteApDataSet berichteDataSetAp = this.getBerichteDataSetAP(channel, tempFolder, TicketID);
          int num = 1;
          string gemeinde;
          string bezirk;
          if (string.IsNullOrEmpty(ap.EinsatzzonenId))
          {
            gemeinde = channel.InfoGetGemeinde();
            bezirk = channel.InfoGetBezirk();
          }
          else
          {
            WCFEinsatzzonenInfo einsatzZonenDetails = channel.InfoGetEinsatzZonenDetails(ap.EinsatzzonenId);
            gemeinde = einsatzZonenDetails.Gemeinde;
            bezirk = einsatzZonenDetails.Bezirk;
            num = einsatzZonenDetails.ZonenNr;
          }
          try
          {
            if (info == null)
              berichteDataSetAp.Info.AddInfoRow(gemeinde, channel.InfoGetFeuerwehrName(), channel.InfoGetPLZ(), bezirk, channel.FeuerwehrGetEigene(TicketID).KdtKontakt.Name, num);
            else
              berichteDataSetAp.Info.AddInfoRow(info);
          }
          catch (Exception ex)
          {
          }
          List<WCFFeuerwehr> wcfFeuerwehrList = new List<WCFFeuerwehr>((IEnumerable<WCFFeuerwehr>) channel.FeuerwehrenGetAll(TicketID, false));
          foreach (WCFAlarmplanObj wcfAlarmplanObj in ((IEnumerable<WCFAlarmplanObj>) ap.AlarmplanObjList).ToList<WCFAlarmplanObj>().OrderBy<WCFAlarmplanObj, int>((System.Func<WCFAlarmplanObj, int>) (x => x.Id)).OrderBy<WCFAlarmplanObj, string>((System.Func<WCFAlarmplanObj, string>) (x => x.Feuerwehr.Feuerwehrname)).ToList<WCFAlarmplanObj>())
          {
            WCFAlarmplanObj ao = wcfAlarmplanObj;
            WCFFeuerwehr wcfFeuerwehr = wcfFeuerwehrList.Find((Predicate<WCFFeuerwehr>) (x => x.Id == ao.Fahrzeug.FeuerwehrID));
            string str1 = "";
            if (wcfFeuerwehr != null && wcfFeuerwehr.KdtKontakt.Adressen.Length != 0)
              str1 = wcfFeuerwehr.KdtKontakt.Adressen[0].Typ + " " + wcfFeuerwehr.KdtKontakt.Adressen[0].Wert;
            string str2 = "";
            if (wcfFeuerwehr != null && wcfFeuerwehr.Kontakt.Adressen.Length != 0)
              str2 = wcfFeuerwehr.Kontakt.Adressen[0].Typ + " " + wcfFeuerwehr.Kontakt.Adressen[0].Wert;
            string str3 = "";
            if (wcfFeuerwehr != null && wcfFeuerwehr.KdtKontakt.Adressen.Length > 1)
              str3 = wcfFeuerwehr.KdtKontakt.Adressen[1].Typ + " " + wcfFeuerwehr.KdtKontakt.Adressen[1].Wert;
            string str4 = "";
            if (wcfFeuerwehr != null && wcfFeuerwehr.Kontakt.Adressen.Length > 1)
              str4 = wcfFeuerwehr.Kontakt.Adressen[1].Typ + " " + wcfFeuerwehr.Kontakt.Adressen[1].Wert;
            string pumpe = ao.Fahrzeug.Pumpe;
            string str5 = ao.Fahrzeug.Atemschutz ? "Atemschutz" : "";
            string objZeitraum = this.getObjZeitraum(ao.Zeitraum);
            try
            {
              berichteDataSetAp.AlarmstufenObj.AddAlarmstufenObjRow(ao.Alarmstufe, wcfFeuerwehr.Id, ao.Fahrzeug.Bezeichnung, pumpe, str5, str2, str1, ap.Id, wcfFeuerwehr.KdtKontakt.Name, str4, str3, objZeitraum);
            }
            catch (Exception ex)
            {
            }
            try
            {
              berichteDataSetAp.Feuerwehr.AddFeuerwehrRow(wcfFeuerwehr.Kontakt.Name, wcfFeuerwehr.Id, wcfFeuerwehr.KontaktID, wcfFeuerwehr.KdtID, wcfFeuerwehr.KdtStvID, wcfFeuerwehr.SirenenCode.ToString("D5"), wcfFeuerwehr.EdvID.ToString("D5"));
            }
            catch (Exception ex)
            {
            }
          }
          try
          {
            berichteDataSetAp.Alarmplan.AddAlarmplanRow(ap.Bezeichnung, ap.Id, ap.EinsatzzonenId);
          }
          catch (Exception ex)
          {
          }
          BerAlarmplan alarmplanBericht = new BerAlarmplan();
          ((ReportDocument) alarmplanBericht).SetDataSource((DataSet) berichteDataSetAp);
          foreach (ReportDocument subreport in (ReadOnlyCollectionBase) ((ReportDocument) alarmplanBericht).Subreports)
            subreport.SetDataSource((DataSet) berichteDataSetAp);
          return alarmplanBericht;
        }
      }
      catch (Exception ex)
      {
        ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 107);
        return new BerAlarmplan();
      }
    }

    private string getObjZeitraum(string zeitraum)
    {
      string objZeitraum;
      if (zeitraum == "24x7")
      {
        objZeitraum = "";
      }
      else
      {
        TimeSpan[][][] timeSpansByString = TimerPeriodList.getTimeSpansByString(zeitraum);
        string str1 = "";
        string str2 = "";
        string str3 = "";
        string str4 = "";
        if (((IEnumerable<TimeSpan[]>) timeSpansByString[0]).Count<TimeSpan[]>() > 0)
        {
          if (string.IsNullOrEmpty(str1))
          {
            str1 = "So";
            str2 = timeSpansByString[0][0][0].ToString().Substring(0, 5);
          }
          str4 = timeSpansByString[0][0][1].ToString().Substring(0, 5);
          str3 = "So";
        }
        if (((IEnumerable<TimeSpan[]>) timeSpansByString[1]).Count<TimeSpan[]>() > 0)
        {
          if (string.IsNullOrEmpty(str1))
          {
            str1 = "Mo";
            str2 = timeSpansByString[1][0][0].ToString().Substring(0, 5);
          }
          str4 = timeSpansByString[1][0][1].ToString().Substring(0, 5);
          str3 = "Mo";
        }
        if (((IEnumerable<TimeSpan[]>) timeSpansByString[2]).Count<TimeSpan[]>() > 0)
        {
          if (string.IsNullOrEmpty(str1))
          {
            str1 = "Di";
            str2 = timeSpansByString[2][0][0].ToString().Substring(0, 5);
          }
          str4 = timeSpansByString[2][0][1].ToString().Substring(0, 5);
          str3 = "Di";
        }
        if (((IEnumerable<TimeSpan[]>) timeSpansByString[3]).Count<TimeSpan[]>() > 0)
        {
          if (string.IsNullOrEmpty(str1))
          {
            str1 = "Mi";
            str2 = timeSpansByString[3][0][0].ToString().Substring(0, 5);
          }
          str4 = timeSpansByString[3][0][1].ToString().Substring(0, 5);
          str3 = "Mi";
        }
        if (((IEnumerable<TimeSpan[]>) timeSpansByString[4]).Count<TimeSpan[]>() > 0)
        {
          if (string.IsNullOrEmpty(str1))
          {
            str1 = "Do";
            str2 = timeSpansByString[4][0][0].ToString().Substring(0, 5);
          }
          str4 = timeSpansByString[4][0][1].ToString().Substring(0, 5);
          str3 = "Do";
        }
        if (((IEnumerable<TimeSpan[]>) timeSpansByString[5]).Count<TimeSpan[]>() > 0)
        {
          if (string.IsNullOrEmpty(str1))
          {
            str1 = "Fr";
            str2 = timeSpansByString[5][0][0].ToString().Substring(0, 5);
          }
          str4 = timeSpansByString[5][0][1].ToString().Substring(0, 5);
          str3 = "Fr";
        }
        if (((IEnumerable<TimeSpan[]>) timeSpansByString[6]).Count<TimeSpan[]>() > 0)
        {
          if (string.IsNullOrEmpty(str1))
          {
            str1 = "Sa";
            str2 = timeSpansByString[6][0][0].ToString().Substring(0, 5);
          }
          str4 = timeSpansByString[6][0][1].ToString().Substring(0, 5);
          str3 = "Sa";
        }
        string str5 = str1;
        if (!string.IsNullOrEmpty(str3))
          str5 = str5 + "-" + str3;
        objZeitraum = str5 + " " + str2 + "-" + str4;
      }
      return objZeitraum;
    }

    public BerFeuerwehr getFeuerwehrBericht(WCFFeuerwehr fw, string tempFolder, Guid TicketID)
    {
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          BerichteApDataSet berichteDataSetAp = this.getBerichteDataSetAP(channel, tempFolder, TicketID);
          try
          {
            BerichteApDataSet.FeuerwehrDataTable feuerwehr = berichteDataSetAp.Feuerwehr;
            string name = fw.Kontakt.Name;
            int id1 = fw.Id;
            int id2 = fw.Kontakt.Id;
            int kdtId = fw.KdtID;
            int kdtStvId = fw.KdtStvID;
            int num = fw.SirenenCode;
            string str1 = num.ToString("D5");
            num = fw.EdvID;
            string str2 = num.ToString("D5");
            feuerwehr.AddFeuerwehrRow(name, id1, id2, kdtId, kdtStvId, str1, str2);
          }
          catch (Exception ex)
          {
          }
          foreach (WCFKontakt wcfKontakt in new List<WCFKontakt>()
          {
            fw.Kontakt,
            fw.KdtKontakt,
            fw.KdtStvKontakt
          })
          {
            try
            {
              berichteDataSetAp.Kontakt.AddKontaktRow(wcfKontakt.Id, wcfKontakt.Name, wcfKontakt.Strasse, wcfKontakt.Ort, wcfKontakt.PLZ.ToString());
            }
            catch (Exception ex)
            {
            }
          }
          List<WCFKontaktObj> wcfKontaktObjList = new List<WCFKontaktObj>();
          wcfKontaktObjList.AddRange((IEnumerable<WCFKontaktObj>) fw.Kontakt.Adressen);
          wcfKontaktObjList.AddRange((IEnumerable<WCFKontaktObj>) fw.KdtKontakt.Adressen);
          wcfKontaktObjList.AddRange((IEnumerable<WCFKontaktObj>) fw.KdtStvKontakt.Adressen);
          foreach (WCFKontaktObj wcfKontaktObj in wcfKontaktObjList)
          {
            try
            {
              berichteDataSetAp.KontaktObj.AddKontaktObjRow(wcfKontaktObj.Typ, wcfKontaktObj.Wert, wcfKontaktObj.KontaktID, wcfKontaktObj.Id);
            }
            catch (Exception ex)
            {
            }
          }
          foreach (WCFFahrzeug wcfFahrzeug in channel.FahrzeugeGetByFeuerwehr(fw.Id, TicketID))
          {
            try
            {
              berichteDataSetAp.Fahrzeug.AddFahrzeugRow(wcfFahrzeug.Id, wcfFahrzeug.Bezeichnung, wcfFahrzeug.Atemschutz ? "Atemschutz" : "", wcfFahrzeug.Pumpe, fw.Id);
            }
            catch (Exception ex)
            {
            }
          }
          BerFeuerwehr feuerwehrBericht = new BerFeuerwehr();
          ((ReportDocument) feuerwehrBericht).SetDataSource((DataSet) berichteDataSetAp);
          foreach (ReportDocument subreport in (ReadOnlyCollectionBase) ((ReportDocument) feuerwehrBericht).Subreports)
            subreport.SetDataSource((DataSet) berichteDataSetAp);
          return feuerwehrBericht;
        }
      }
      catch (Exception ex)
      {
        ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 107);
        return new BerFeuerwehr();
      }
    }

    public BerEinsatzprotokoll getEinsatzprotokollBericht(
      DateTime von,
      DateTime bis,
      string tempFolder,
      string artFilter,
      Guid TicketID)
    {
      using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
      {
        IELISWCFService channel = wcfService.CreateChannel();
        BerichteDataSet berichteDataSet = this.getBerichteDataSet(channel, tempFolder, TicketID);
        BerEinsatzprotokoll einsatzprotokollBericht = new BerEinsatzprotokoll();
        berichteDataSet.Werte.AddWerteRow(von, bis);
        int num = 1;
        foreach (WCFJournalEntry wcfJournalEntry in ((IEnumerable<WCFJournalEntry>) channel.ProtocolGetFilteredRange(0, 1000, artFilter, von, bis, TicketID)).ToList<WCFJournalEntry>().OrderBy<WCFJournalEntry, DateTime>((System.Func<WCFJournalEntry, DateTime>) (x => x.Zeit)).ToList<WCFJournalEntry>())
        {
          if (string.IsNullOrEmpty(artFilter) || !(wcfJournalEntry.Art != artFilter))
            berichteDataSet.Journal.AddJournalRow(num++, wcfJournalEntry.Art, wcfJournalEntry.Ersteller, wcfJournalEntry.Info, wcfJournalEntry.Zeit);
        }
        ((ReportDocument) einsatzprotokollBericht).SetDataSource((DataSet) berichteDataSet);
        foreach (ReportDocument subreport in (ReadOnlyCollectionBase) ((ReportDocument) einsatzprotokollBericht).Subreports)
          subreport.SetDataSource((DataSet) berichteDataSet);
        return einsatzprotokollBericht;
      }
    }

    public BerTelefonbuch getTelefonbuchBericht(string tempFolder, Guid TicketID)
    {
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          BerichtTelefonbuchDS dataSetTelefonbuch = this.getBerichteDataSetTelefonbuch(channel, tempFolder, TicketID);
          List<WCFFremdhilfeArt> list1 = ((IEnumerable<WCFFremdhilfeArt>) channel.FremdhilfeArtenGetAll(TicketID)).ToList<WCFFremdhilfeArt>();
          foreach (WCFFremdhilfeArt wcfFremdhilfeArt in list1)
          {
            try
            {
              dataSetTelefonbuch.Kategorien.AddKategorienRow(wcfFremdhilfeArt.Id, wcfFremdhilfeArt.Bezeichnung);
            }
            catch (Exception ex)
            {
            }
          }
          foreach (WCFFremdhilfeLeister fremdhilfeLeister in ((IEnumerable<WCFFremdhilfeLeister>) channel.FremdhilfeLeisterGetAll(TicketID)).ToList<WCFFremdhilfeLeister>().OrderBy<WCFFremdhilfeLeister, string>((System.Func<WCFFremdhilfeLeister, string>) (x => x.Geraet)).ToList<WCFFremdhilfeLeister>())
          {
            WCFFremdhilfeLeister eintrag = fremdhilfeLeister;
            try
            {
              string bezeichnung = list1.Find((Predicate<WCFFremdhilfeArt>) (x => x.Id == eintrag.FremdhilfeArtId)).Bezeichnung;
              List<WCFKontaktObj> list2 = ((IEnumerable<WCFKontaktObj>) eintrag.Kontakt.Adressen).ToList<WCFKontaktObj>();
              string str1 = "";
              string str2 = "";
              if (list2.Count > 0)
              {
                string typ = list2[0].Typ;
                string wert = list2[0].Wert;
                str1 = str1 + typ + " " + wert + Environment.NewLine;
              }
              if (list2.Count > 1)
              {
                string typ = list2[1].Typ;
                string wert = list2[1].Wert;
                str2 = str2 + typ + " " + wert + Environment.NewLine;
              }
              if (list2.Count > 2)
              {
                string typ = list2[2].Typ;
                string wert = list2[2].Wert;
                str1 = str1 + typ + " " + wert + Environment.NewLine;
              }
              if (list2.Count > 3)
              {
                string typ = list2[3].Typ;
                string wert = list2[3].Wert;
                str2 = str2 + typ + " " + wert + Environment.NewLine;
              }
              if (list2.Count > 4)
              {
                string typ = list2[4].Typ;
                string wert = list2[4].Wert;
                str1 = str1 + typ + " " + wert + Environment.NewLine;
              }
              if (list2.Count > 5)
              {
                string typ = list2[5].Typ;
                string wert = list2[5].Wert;
                str2 = str2 + typ + " " + wert + Environment.NewLine;
              }
              string str3 = "";
              if (eintrag.Kontakt.PLZ > 0)
                str3 = eintrag.Kontakt.PLZ.ToString() + " " + eintrag.Kontakt.Ort;
              string str4 = eintrag.Kontakt.Name;
              if (!string.IsNullOrEmpty(str4))
                str4 += Environment.NewLine;
              if (!string.IsNullOrEmpty(eintrag.Kontakt.Strasse))
                str4 = str4 + eintrag.Kontakt.Strasse + Environment.NewLine;
              if (!string.IsNullOrEmpty(str3))
                str4 += str3;
              dataSetTelefonbuch.Telefonbucheintrag.AddTelefonbucheintragRow(eintrag.Id, bezeichnung, eintrag.Kontakt.Id, eintrag.Geraet, str4, "", "", str1, "", str2, "", "", "", "", "");
            }
            catch (Exception ex)
            {
            }
          }
          BerTelefonbuch telefonbuchBericht = new BerTelefonbuch();
          ((ReportDocument) telefonbuchBericht).SetDataSource((DataSet) dataSetTelefonbuch);
          foreach (ReportDocument subreport in (ReadOnlyCollectionBase) ((ReportDocument) telefonbuchBericht).Subreports)
            subreport.SetDataSource((DataSet) dataSetTelefonbuch);
          return telefonbuchBericht;
        }
      }
      catch (Exception ex)
      {
        ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 155);
        return new BerTelefonbuch();
      }
    }

    public BerEinsatzmeldungWAS getWASBericht(string tempFolder, WCFEinsatzdaten ed, Guid TicketID)
    {
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          BerichteDataSet berichteDataSet = this.getBerichteDataSet(channel, tempFolder, TicketID);
          string str1 = ed.Information;
          string[] strArray = str1.Split(new string[1]
          {
            Environment.NewLine
          }, StringSplitOptions.None);
          string str2 = "";
          int num1 = 3;
          if (strArray.Length > num1)
          {
            str1 = "";
            for (int index = 0; index < num1; ++index)
              str1 = str1 + strArray[index] + Environment.NewLine;
            for (int index = num1; index < strArray.Length; ++index)
              str2 = str2 + strArray[index] + Environment.NewLine;
          }
          Color einsatzFarbe = Einsatzfarbe.GetEinsatzFarbe(ed.Einsatzgrund, ed.Status.ToString());
          berichteDataSet.Einsatzdaten.AddEinsatzdatenRow(ed.ID, ed.EinsatzNr, ed.AlarmStelle, ed.Erhalten, ed.WASnr, ed.Alarmstufe, ed.Geschaedigter, ed.Einsatzgrund, ed.Anrufer, ed.Adresse, str1, ed.Status.ToString(), ed.Ausgerueckt, ed.Erledigt, ed.DatenQuelle.ToString(), channel.InfoGetFeuerwehrName(), channel.InfoGetBezirk(), channel.InfoGetGemeinde(), ed.Prioritaet, (short) einsatzFarbe.R, (short) einsatzFarbe.G, (short) einsatzFarbe.B, ed.GPSLatitude, ed.GPSLongitude, UTMREFRechner.getUTMREFÖK50Koordinatenmeldung(ed.UTMREF), ed.EinsatzzonenId, ed.AlarmplanName, UTMREFRechner.getGPSStringByGPS(ed.GPSLatitude, ed.GPSLongitude), str2, "", "", "", "", "", false, "");
          WCFWetterObj wetterInfos = ed.WetterInfos;
          if (wetterInfos == null)
            berichteDataSet.Wetter.AddWetterRow(new DateTime(2001, 1, 1, 0, 0, 0), "", "", "", "");
          else
            berichteDataSet.Wetter.AddWetterRow(wetterInfos.ErstellungsZeit, wetterInfos.Temperatur.ToString() + " °C", wetterInfos.Messort, wetterInfos.WindAnzeige, wetterInfos.WetterLage);
          int num2 = 1;
          List<WCFFahrzeug> wcfFahrzeugList = new List<WCFFahrzeug>((IEnumerable<WCFFahrzeug>) channel.FahrzeugeGetAll(TicketID));
          WCFFeuerwehr eigene = channel.FeuerwehrGetEigene(TicketID);
          List<WCFEinsatz_Fahrzeug> wcfEinsatzFahrzeugList1 = new List<WCFEinsatz_Fahrzeug>();
          List<WCFEinsatz_Fahrzeug> wcfEinsatzFahrzeugList2 = ed.Status != WCFEinsatzdaten.WCFEinsatzStatus.Erledigt ? new List<WCFEinsatz_Fahrzeug>((IEnumerable<WCFEinsatz_Fahrzeug>) channel.EinsatzGetFahrzeuge(ed.ID, false, TicketID)) : new List<WCFEinsatz_Fahrzeug>((IEnumerable<WCFEinsatz_Fahrzeug>) channel.EinsatzGetFahrzeuge(ed.ID, true, TicketID));
          List<WCFEinsatz_Fahrzeug> wcfEinsatzFahrzeugList3 = new List<WCFEinsatz_Fahrzeug>();
          int num3 = 0;
          foreach (WCFEinsatz_Fahrzeug wcfEinsatzFahrzeug in wcfEinsatzFahrzeugList2)
          {
            WCFEinsatz_Fahrzeug ef = wcfEinsatzFahrzeug;
            WCFFahrzeug wcfFahrzeug = wcfFahrzeugList.Find((Predicate<WCFFahrzeug>) (x => x.Id == ef.FahrzeugID));
            if (wcfFahrzeug != null)
            {
              if (wcfFahrzeug.FeuerwehrID == eigene.Id)
                wcfEinsatzFahrzeugList3.Insert(num3++, ef);
              else
                wcfEinsatzFahrzeugList3.Add(ef);
            }
          }
          foreach (WCFEinsatz_Fahrzeug wcfEinsatzFahrzeug in wcfEinsatzFahrzeugList3)
          {
            WCFEinsatz_Fahrzeug ef = wcfEinsatzFahrzeug;
            WCFFahrzeug wcfFahrzeug = wcfFahrzeugList.Find((Predicate<WCFFahrzeug>) (x => x.Id == ef.FahrzeugID));
            if (wcfFahrzeug != null)
            {
              DateTime dateTime = new DateTime(2000, 1, 1);
              switch (ed.Status)
              {
                case WCFEinsatzdaten.WCFEinsatzStatus.Alarmiert:
                  berichteDataSet.Fahrzeuge.AddFahrzeugeRow(wcfFahrzeug.Id, wcfFahrzeug.Bezeichnung, num2++, ef.Beginn, dateTime);
                  continue;
                case WCFEinsatzdaten.WCFEinsatzStatus.Ausgerückt:
                  berichteDataSet.Fahrzeuge.AddFahrzeugeRow(wcfFahrzeug.Id, wcfFahrzeug.Bezeichnung, num2++, ef.Beginn, dateTime);
                  continue;
                case WCFEinsatzdaten.WCFEinsatzStatus.Erledigt:
                  berichteDataSet.Fahrzeuge.AddFahrzeugeRow(wcfFahrzeug.Id, wcfFahrzeug.Bezeichnung, num2++, ef.Beginn, ef.Ende);
                  continue;
                default:
                  continue;
              }
            }
          }
          foreach (WCFFeuerwehr wcfFeuerwehr in ed.Alarmierungen)
          {
            if (wcfFeuerwehr != null)
            {
              try
              {
                berichteDataSet.Feuerwehr.AddFeuerwehrRow(wcfFeuerwehr.Kontakt.Name, wcfFeuerwehr.SirenenCode);
              }
              catch (Exception ex)
              {
              }
            }
          }
          BerEinsatzmeldungWAS wasBericht = new BerEinsatzmeldungWAS();
          ((ReportDocument) wasBericht).SetDataSource((DataSet) berichteDataSet);
          foreach (ReportDocument subreport in (ReadOnlyCollectionBase) ((ReportDocument) wasBericht).Subreports)
            subreport.SetDataSource((DataSet) berichteDataSet);
          return wasBericht;
        }
      }
      catch (Exception ex)
      {
        ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 108);
        return new BerEinsatzmeldungWAS();
      }
    }

    public BerAlleEigFzAlarmplan getAlarmplanEigeneFahrzeugeBericht(
      bool mitPflichtbereich,
      string tempFolder,
      Guid TicketID)
    {
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          BerichteApDataSet berichteDataSetAp = this.getBerichteDataSetAP(channel, tempFolder, TicketID);
          List<WCFFeuerwehr> wcfFeuerwehrList = new List<WCFFeuerwehr>((IEnumerable<WCFFeuerwehr>) channel.FeuerwehrenGetAll(TicketID, false));
          List<WCFAlarmplan> wcfAlarmplanList = new List<WCFAlarmplan>((IEnumerable<WCFAlarmplan>) channel.AlarmplanGetAll(TicketID));
          List<WCFFahrzeug> wcfFahrzeugList = new List<WCFFahrzeug>((IEnumerable<WCFFahrzeug>) channel.FahrzeugeGetByEigenerFeuerwehr(TicketID));
          string str1 = "";
          if (!mitPflichtbereich)
            str1 = channel.InfoGetGemeinde();
          foreach (WCFAlarmplan wcfAlarmplan in wcfAlarmplanList)
          {
            if (mitPflichtbereich || !(channel.InfoGetEinsatzZonenDetails(wcfAlarmplan.EinsatzzonenId).Gemeinde == str1))
            {
              foreach (WCFAlarmplanObj wcfAlarmplanObj in ((IEnumerable<WCFAlarmplanObj>) wcfAlarmplan.AlarmplanObjList).ToList<WCFAlarmplanObj>().OrderBy<WCFAlarmplanObj, int>((System.Func<WCFAlarmplanObj, int>) (x => x.Id)).OrderBy<WCFAlarmplanObj, string>((System.Func<WCFAlarmplanObj, string>) (x => x.Feuerwehr.Feuerwehrname)).ToList<WCFAlarmplanObj>())
              {
                WCFAlarmplanObj ao = wcfAlarmplanObj;
                if (wcfFahrzeugList.Find((Predicate<WCFFahrzeug>) (x => x.Id == ao.FahrzeugID)) != null)
                {
                  WCFFeuerwehr wcfFeuerwehr = wcfFeuerwehrList.Find((Predicate<WCFFeuerwehr>) (x => x.Id == ao.Fahrzeug.FeuerwehrID));
                  string str2 = "";
                  if (wcfFeuerwehr != null && wcfFeuerwehr.KdtKontakt.Adressen.Length != 0)
                    str2 = wcfFeuerwehr.KdtKontakt.Adressen[0].Typ + " " + wcfFeuerwehr.KdtKontakt.Adressen[0].Wert;
                  string str3 = "";
                  if (wcfFeuerwehr != null && wcfFeuerwehr.Kontakt.Adressen.Length != 0)
                    str3 = wcfFeuerwehr.Kontakt.Adressen[0].Typ + " " + wcfFeuerwehr.Kontakt.Adressen[0].Wert;
                  string str4 = "";
                  if (wcfFeuerwehr != null && wcfFeuerwehr.KdtKontakt.Adressen.Length > 1)
                    str4 = wcfFeuerwehr.KdtKontakt.Adressen[1].Typ + " " + wcfFeuerwehr.KdtKontakt.Adressen[1].Wert;
                  string str5 = "";
                  if (wcfFeuerwehr != null && wcfFeuerwehr.Kontakt.Adressen.Length > 1)
                    str5 = wcfFeuerwehr.Kontakt.Adressen[1].Typ + " " + wcfFeuerwehr.Kontakt.Adressen[1].Wert;
                  string pumpe = ao.Fahrzeug.Pumpe;
                  string str6 = ao.Fahrzeug.Atemschutz ? "Atemschutz" : "";
                  try
                  {
                    berichteDataSetAp.AlarmstufenObj.AddAlarmstufenObjRow(ao.Alarmstufe, wcfFeuerwehr.Id, ao.Fahrzeug.Bezeichnung, pumpe, str6, str3, str2, wcfAlarmplan.Id, wcfFeuerwehr.KdtKontakt.Name, str5, str4, "");
                  }
                  catch (Exception ex)
                  {
                  }
                  try
                  {
                    BerichteApDataSet.FeuerwehrDataTable feuerwehr = berichteDataSetAp.Feuerwehr;
                    string name = wcfFeuerwehr.Kontakt.Name;
                    int id = wcfFeuerwehr.Id;
                    int kontaktId = wcfFeuerwehr.KontaktID;
                    int kdtId = wcfFeuerwehr.KdtID;
                    int kdtStvId = wcfFeuerwehr.KdtStvID;
                    int num = wcfFeuerwehr.SirenenCode;
                    string str7 = num.ToString("D5");
                    num = wcfFeuerwehr.EdvID;
                    string str8 = num.ToString("D5");
                    feuerwehr.AddFeuerwehrRow(name, id, kontaktId, kdtId, kdtStvId, str7, str8);
                  }
                  catch (Exception ex)
                  {
                  }
                }
              }
              try
              {
                berichteDataSetAp.Alarmplan.AddAlarmplanRow(wcfAlarmplan.Bezeichnung, wcfAlarmplan.Id, wcfAlarmplan.EinsatzzonenId);
              }
              catch (Exception ex)
              {
              }
            }
          }
          BerAlleEigFzAlarmplan fahrzeugeBericht = new BerAlleEigFzAlarmplan();
          ((ReportDocument) fahrzeugeBericht).SetDataSource((DataSet) berichteDataSetAp);
          foreach (ReportDocument subreport in (ReadOnlyCollectionBase) ((ReportDocument) fahrzeugeBericht).Subreports)
            subreport.SetDataSource((DataSet) berichteDataSetAp);
          return fahrzeugeBericht;
        }
      }
      catch (Exception ex)
      {
        ELIS.ELISWCFClient.Berichte.log.writelogfile(ex, EventLogEntryType.Error, (LogCategory) 107);
        return new BerAlleEigFzAlarmplan();
      }
    }

    public BerichteDataSet getBerichteDataSet(
      IELISWCFService service,
      string tempFolder,
      Guid TicketID)
    {
      BerichteDataSet berichteDataSet = new BerichteDataSet();
      try
      {
        berichteDataSet.Bild.AddBildRow(1, this.GetImagefromWCF(tempFolder, "LOGO", TicketID), new byte[0], new byte[0]);
      }
      catch (Exception ex)
      {
        berichteDataSet.Bild.AddBildRow(1, new byte[0], new byte[0], new byte[0]);
      }
      berichteDataSet.Z_DBInfo.AddZ_DBInfoRow(1, service.InfoGetSysDBVersion());
      return berichteDataSet;
    }

    public BerichteApDataSet getBerichteDataSetAP(
      IELISWCFService service,
      string tempFolder,
      Guid TicketID)
    {
      BerichteApDataSet berichteDataSetAp = new BerichteApDataSet();
      try
      {
        berichteDataSetAp.Bild.AddBildRow(1, this.GetImagefromWCF(tempFolder, "LOGO", TicketID));
      }
      catch (Exception ex)
      {
        berichteDataSetAp.Bild.AddBildRow(1, new byte[0]);
      }
      berichteDataSetAp.Z_DBInfo.AddZ_DBInfoRow(1, service.InfoGetSysDBVersion());
      return berichteDataSetAp;
    }

    public BerichtTelefonbuchDS getBerichteDataSetTelefonbuch(
      IELISWCFService service,
      string tempFolder,
      Guid TicketID)
    {
      BerichtTelefonbuchDS dataSetTelefonbuch = new BerichtTelefonbuchDS();
      try
      {
        dataSetTelefonbuch.Bild.AddBildRow(1, this.GetImagefromWCF(tempFolder, "LOGO", TicketID));
      }
      catch (Exception ex)
      {
        dataSetTelefonbuch.Bild.AddBildRow(1, new byte[0]);
      }
      dataSetTelefonbuch.Z_DBInfo.AddZ_DBInfoRow(1, service.InfoGetSysDBVersion());
      return dataSetTelefonbuch;
    }
  }
}
