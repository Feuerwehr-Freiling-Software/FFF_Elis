// Decompiled with JetBrains decompiler
// Type: ELIS.ELISConfiguration.DocPrintSettingsRow
// Assembly: ELISConfigBase, Version=3.3.7468.42109, Culture=neutral, PublicKeyToken=null
// MVID: BE38FD42-018D-4617-86E9-4344F3F52349
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISConfigBase.dll

using System.Collections.Generic;

#nullable disable
namespace ELIS.ELISConfiguration
{
  public class DocPrintSettingsRow
  {
    private ELISEinsatzStatus _status;
    private string _druckerList;
    private int _AnzahlAusgaben;
    private int _MaxEinsätze;

    public ELISEinsatzStatus Status
    {
      get => this._status;
      set => this._status = value;
    }

    public string DruckerString
    {
      get => this._druckerList;
      set => this._druckerList = value;
    }

    public int AnzahlAusgaben
    {
      get => this._AnzahlAusgaben;
      set => this._AnzahlAusgaben = value;
    }

    public int MaxEinsätze
    {
      get => this._MaxEinsätze;
      set => this._MaxEinsätze = value;
    }

    public List<string> getDruckerList()
    {
      return new List<string>((IEnumerable<string>) this.DruckerString.Split('|'));
    }
  }
}
