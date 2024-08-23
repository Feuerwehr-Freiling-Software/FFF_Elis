// Decompiled with JetBrains decompiler
// Type: ELIS.ELISConfiguration.GoogleKeyListObj
// Assembly: ELISConfigBase, Version=3.3.7468.42109, Culture=neutral, PublicKeyToken=null
// MVID: BE38FD42-018D-4617-86E9-4344F3F52349
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISConfigBase.dll

using System.Collections.Generic;

#nullable disable
namespace ELIS.ELISConfiguration
{
  public class GoogleKeyListObj
  {
    private List<GoogleKeyObj> _googleKeyList;

    public List<GoogleKeyObj> GoogleKeyList
    {
      get => this._googleKeyList;
      set => this._googleKeyList = value;
    }

    public GoogleKeyListObj(string value)
    {
      this._googleKeyList = new List<GoogleKeyObj>();
      string str1 = value;
      char[] chArray1 = new char[1]{ '|' };
      foreach (string str2 in str1.Split(chArray1))
      {
        char[] chArray2 = new char[1]{ '#' };
        string[] strArray = str2.Split(chArray2);
        if (strArray.Length == 2)
          this.addKey(new GoogleKeyObj(strArray[0], strArray[1]));
      }
    }

    public void addKey(GoogleKeyObj gko) => this._googleKeyList.Add(gko);

    public override string ToString()
    {
      string str = "";
      foreach (GoogleKeyObj googleKey in this._googleKeyList)
      {
        if (str != "")
          str += "|";
        str += googleKey.Url;
        str += "#";
        str += googleKey.GoogleKey;
      }
      return str;
    }
  }
}
