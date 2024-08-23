// Decompiled with JetBrains decompiler
// Type: ELIS.ELISConfiguration.GoogleKeyObj
// Assembly: ELISConfigBase, Version=3.3.7468.42109, Culture=neutral, PublicKeyToken=null
// MVID: BE38FD42-018D-4617-86E9-4344F3F52349
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISConfigBase.dll

#nullable disable
namespace ELIS.ELISConfiguration
{
  public class GoogleKeyObj
  {
    public string GoogleKey;
    public string Url;

    public GoogleKeyObj(string url, string googleKey)
    {
      this.GoogleKey = googleKey;
      this.Url = url;
    }
  }
}
