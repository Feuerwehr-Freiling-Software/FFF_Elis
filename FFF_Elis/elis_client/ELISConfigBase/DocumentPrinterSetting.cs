// Decompiled with JetBrains decompiler
// Type: ELIS.ELISConfiguration.DocumentPrinterSetting
// Assembly: ELISConfigBase, Version=3.3.7468.42109, Culture=neutral, PublicKeyToken=null
// MVID: BE38FD42-018D-4617-86E9-4344F3F52349
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISConfigBase.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace ELIS.ELISConfiguration
{
  public class DocumentPrinterSetting
  {
    public List<DocPrintSettingsRow> Rows;

    public List<DocPrintSettingsRow> getRowsByStatus(string status)
    {
      return this.Rows.Where<DocPrintSettingsRow>((Func<DocPrintSettingsRow, bool>) (x => x.Status.ToString() == status)).ToList<DocPrintSettingsRow>() ?? new List<DocPrintSettingsRow>();
    }

    public string getKonfigString(List<DocPrintSettingsRow> rows)
    {
      this.Rows = rows;
      XmlDocument xmlDocument = new XmlDocument();
      using (MemoryStream inStream = new MemoryStream())
      {
        new XmlSerializer(typeof (DocumentPrinterSetting)).Serialize((Stream) inStream, (object) this);
        inStream.Seek(0L, SeekOrigin.Begin);
        xmlDocument.Load((Stream) inStream);
      }
      return xmlDocument.InnerXml;
    }

    public List<DocPrintSettingsRow> getRows(string konfigString)
    {
      if (string.IsNullOrEmpty(konfigString))
        return new List<DocPrintSettingsRow>();
      DocumentPrinterSetting documentPrinterSetting = new DocumentPrinterSetting();
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (DocumentPrinterSetting));
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(konfigString);
        using (MemoryStream memoryStream = new MemoryStream())
        {
          xmlDocument.Save((Stream) memoryStream);
          memoryStream.Seek(0L, SeekOrigin.Begin);
          using (XmlTextReader xmlTextReader = new XmlTextReader((Stream) memoryStream))
            documentPrinterSetting = (DocumentPrinterSetting) xmlSerializer.Deserialize((XmlReader) xmlTextReader);
        }
      }
      catch (Exception ex)
      {
      }
      if (documentPrinterSetting.Rows == null)
        return new List<DocPrintSettingsRow>();
      foreach (DocPrintSettingsRow row in documentPrinterSetting.Rows)
      {
        if (row.MaxEinsätze == 0)
          row.MaxEinsätze = 3;
      }
      return documentPrinterSetting.Rows;
    }
  }
}
