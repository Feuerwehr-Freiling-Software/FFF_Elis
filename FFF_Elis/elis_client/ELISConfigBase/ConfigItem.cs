// Decompiled with JetBrains decompiler
// Type: ELIS.ELISConfiguration.ConfigItem
// Assembly: ELISConfigBase, Version=3.3.7468.42109, Culture=neutral, PublicKeyToken=null
// MVID: BE38FD42-018D-4617-86E9-4344F3F52349
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISConfigBase.dll

using System;

#nullable disable
namespace ELIS.ELISConfiguration
{
  public class ConfigItem
  {
    public string name;
    public Type type;
    public object value;
    public string group;
    public string description;

    public string Name
    {
      get => this.name;
      set => this.name = value;
    }

    public object Value
    {
      get => this.value;
      set => this.value = value;
    }

    public string Group
    {
      get => this.group;
      set => this.group = value;
    }

    public string Description
    {
      get => this.description;
      set => this.description = value;
    }

    public Type Type
    {
      get => this.type;
      set => this.type = value;
    }

    public ConfigItem(string name, Type type, object value, string group, string description)
    {
      this.name = name;
      this.type = type;
      this.value = value;
      this.group = group;
      this.description = description;
    }

    public override string ToString()
    {
      if (!this.type.Equals(typeof (bool)))
        return this.value.ToString();
      bool result = false;
      bool.TryParse(this.value.ToString(), out result);
      return result ? "Ja" : "Nein";
    }
  }
}
