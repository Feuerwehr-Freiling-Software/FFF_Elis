﻿// Decompiled with JetBrains decompiler
// Type: NewEinsatzGuidGetCompletedEventArgs
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

#nullable disable
[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "3.0.0.0")]
public class NewEinsatzGuidGetCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  public NewEinsatzGuidGetCompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, userState)
  {
    this.results = results;
  }

  public string Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return (string) this.results[0];
    }
  }
}
