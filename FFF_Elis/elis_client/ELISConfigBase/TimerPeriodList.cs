// Decompiled with JetBrains decompiler
// Type: ELIS.ELISConfiguration.TimerPeriodList
// Assembly: ELISConfigBase, Version=3.3.7468.42109, Culture=neutral, PublicKeyToken=null
// MVID: BE38FD42-018D-4617-86E9-4344F3F52349
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISConfigBase.dll

using System;
using System.Collections.Generic;
using System.Globalization;

#nullable disable
namespace ELIS.ELISConfiguration
{
  public class TimerPeriodList
  {
    public static string getStringByTimeSpanList(TimeSpan[][][] ts)
    {
      string stringByTimeSpanList = "";
      DayOfWeek dayOfWeek = DayOfWeek.Sunday;
      foreach (TimeSpan[][] t in ts)
      {
        foreach (TimeSpan[] timeSpanArray in t)
        {
          if (!string.IsNullOrEmpty(stringByTimeSpanList))
            stringByTimeSpanList += ";";
          TimeSpan timeSpan1 = timeSpanArray[0];
          TimeSpan timeSpan2 = timeSpanArray[1];
          if (timeSpan2.Days == 1)
            timeSpan2 = timeSpan2.Subtract(new TimeSpan(0, 1, 0));
          if ((timeSpan2 - timeSpan1).TotalMinutes > 0.0)
          {
            string[] strArray = new string[10];
            strArray[0] = stringByTimeSpanList;
            int num = (int) dayOfWeek;
            strArray[1] = num.ToString();
            strArray[2] = ":";
            num = timeSpanArray[0].Hours;
            strArray[3] = num.ToString();
            strArray[4] = ":";
            num = timeSpanArray[0].Minutes;
            strArray[5] = num.ToString();
            strArray[6] = ":";
            num = timeSpan2.Hours;
            strArray[7] = num.ToString();
            strArray[8] = ":";
            num = timeSpan2.Minutes;
            strArray[9] = num.ToString();
            stringByTimeSpanList = string.Concat(strArray);
          }
        }
        ++dayOfWeek;
      }
      return stringByTimeSpanList;
    }

    public static TimeSpan[][][] getTimeSpansByString(string timeSpanListString)
    {
      TimeSpan[][][] timeSpansByString = new TimeSpan[7][][];
      string[] strArray1 = timeSpanListString.Split(';');
      int index1 = 0;
      for (int index2 = 0; index2 < 7; ++index2)
      {
        List<KeyValuePair<TimeSpan, TimeSpan>> keyValuePairList = new List<KeyValuePair<TimeSpan, TimeSpan>>();
        for (; index1 < strArray1.Length && strArray1[index1].StartsWith(index2.ToString()); ++index1)
        {
          string[] strArray2 = strArray1[index1].Split(':');
          if (strArray2.Length == 5)
          {
            TimeSpan key = new TimeSpan(int.Parse(strArray2[1]), int.Parse(strArray2[2]), 0);
            TimeSpan timeSpan = new TimeSpan(int.Parse(strArray2[3]), int.Parse(strArray2[4]), 0);
            if (timeSpan.TotalSeconds == 0.0)
              timeSpan = timeSpan.Add(new TimeSpan(23, 59, 0));
            if ((timeSpan - key).TotalMinutes > 0.0)
              keyValuePairList.Add(new KeyValuePair<TimeSpan, TimeSpan>(key, timeSpan));
          }
        }
        timeSpansByString[index2] = new TimeSpan[keyValuePairList.Count][];
        int index3 = 0;
        foreach (KeyValuePair<TimeSpan, TimeSpan> keyValuePair in keyValuePairList)
        {
          timeSpansByString[index2][index3] = new TimeSpan[2];
          timeSpansByString[index2][index3][0] = keyValuePair.Key;
          timeSpansByString[index2][index3][1] = keyValuePair.Value;
          ++index3;
        }
      }
      return timeSpansByString;
    }

    public static string getGermanTag(int idx)
    {
      return idx < 0 || idx > 6 ? "" : new CultureInfo("de-DE").DateTimeFormat.DayNames[idx];
    }

    public static bool isCurrentTimeActive(string timeSpanListString)
    {
      bool result = false;
      if (bool.TryParse(timeSpanListString, out result))
        return result;
      if (string.IsNullOrEmpty(timeSpanListString))
        return false;
      TimeSpan[][][] timeSpansByString = TimerPeriodList.getTimeSpansByString(timeSpanListString);
      DateTime now = DateTime.Now;
      int dayOfWeek = (int) now.DayOfWeek;
      foreach (TimeSpan[] timeSpanArray in timeSpansByString[dayOfWeek])
      {
        if (timeSpanArray[1].Hours == 0 && timeSpanArray[1].Minutes == 0)
          timeSpanArray[1] = new TimeSpan(23, 59, 59);
        if (timeSpanArray[0] <= now.TimeOfDay && now.TimeOfDay <= timeSpanArray[1])
          return true;
      }
      return false;
    }
  }
}
