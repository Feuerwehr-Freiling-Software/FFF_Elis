﻿// Decompiled with JetBrains decompiler
// Type: FremdhilfeLeisterPersistCompletedEventArgs
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using ELIS.ELISWCF.ApDataContracts;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

#nullable disable
[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "3.0.0.0")]
public class FremdhilfeLeisterPersistCompletedEventArgs : AsyncCompletedEventArgs
{
  private object[] results;

  public FremdhilfeLeisterPersistCompletedEventArgs(
    object[] results,
    Exception exception,
    bool cancelled,
    object userState)
    : base(exception, cancelled, userState)
  {
    this.results = results;
  }

  public WCFFremdhilfeLeister Result
  {
    get
    {
      this.RaiseExceptionIfNecessary();
      return (WCFFremdhilfeLeister) this.results[0];
    }
  }
}