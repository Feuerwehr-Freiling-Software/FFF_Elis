// Decompiled with JetBrains decompiler
// Type: ELIS.ELISConfiguration.AbstractConfigFile
// Assembly: ELISConfigBase, Version=3.3.7468.42109, Culture=neutral, PublicKeyToken=null
// MVID: BE38FD42-018D-4617-86E9-4344F3F52349
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISConfigBase.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace ELIS.ELISConfiguration
{
  public abstract class AbstractConfigFile
  {
    public System.Configuration.Configuration config;
    protected SortedDictionary<string, ConfigItem> configItemMap;

    public SortedDictionary<string, ConfigItem> ConfigItemMap => this.configItemMap;

    protected abstract void fillSettingsList();

    public override bool Equals(object obj) => this.Equals(obj);

    public override int GetHashCode() => base.GetHashCode();

    protected string getSetting(string settingName)
    {
      string str;
      try
      {
        str = this.config.AppSettings.Settings[settingName].Value;
      }
      catch (Exception ex)
      {
        str = "";
      }
      return str.ToUpper() == "JA" ? "TRUE" : str;
    }

    protected bool getSettingBOOL(string settingName, bool defaultValueIfNotYETSet)
    {
      if (!string.IsNullOrEmpty(this.getSetting(settingName)))
        return this.getSetting(settingName).ToUpper() == "TRUE";
      try
      {
        this.setSetting(settingName, defaultValueIfNotYETSet);
      }
      catch (Exception ex)
      {
      }
      return defaultValueIfNotYETSet;
    }

    protected int getSettingINT(string settingName)
    {
      try
      {
        string setting = this.getSetting(settingName);
        int settingInt = 5;
        ref int local = ref settingInt;
        int.TryParse(setting, out local);
        return settingInt;
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    protected double getSettingDOUBLE(string settingName)
    {
      try
      {
        string setting = this.getSetting(settingName);
        double settingDouble = 5.0;
        ref double local = ref settingDouble;
        double.TryParse(setting, out local);
        return settingDouble;
      }
      catch (Exception ex)
      {
        return 0.0;
      }
    }

    protected bool setSetting(string settingName, bool value)
    {
      return this.setSetting(settingName, value ? "true" : "false");
    }

    protected bool setSetting(string settingName, int value)
    {
      return this.setSetting(settingName, value.ToString());
    }

    protected bool setSetting(string settingName, long value)
    {
      return this.setSetting(settingName, value.ToString());
    }

    protected bool setSetting(string settingName, double value)
    {
      return this.setSetting(settingName, value.ToString());
    }

    protected bool setSetting(string settingName, string value)
    {
      try
      {
        if (value.ToUpper() == "JA")
          value = "true";
        if (value.ToUpper() == "NEIN")
          value = "false";
        this.configItemMap[settingName].Value = (object) value;
        this.config.AppSettings.Settings[settingName].Value = value;
      }
      catch (Exception ex)
      {
        this.config.AppSettings.Settings.Add(settingName, value);
        this.config.AppSettings.Settings[settingName].Value = value;
      }
      this.config.Save();
      return true;
    }
  }
}
