﻿// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFJournalEntry
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFJournalEntry", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFJournalEntry : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string ArtField;
    private string ErstellerField;
    private int IDField;
    private string InfoField;
    private DateTime ZeitField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Art
    {
      get => this.ArtField;
      set => this.ArtField = value;
    }

    [DataMember]
    public string Ersteller
    {
      get => this.ErstellerField;
      set => this.ErstellerField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public string Info
    {
      get => this.InfoField;
      set => this.InfoField = value;
    }

    [DataMember]
    public DateTime Zeit
    {
      get => this.ZeitField;
      set => this.ZeitField = value;
    }
  }
}