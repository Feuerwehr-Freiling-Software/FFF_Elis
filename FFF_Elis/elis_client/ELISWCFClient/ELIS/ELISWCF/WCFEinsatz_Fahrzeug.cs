// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFEinsatz_Fahrzeug
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
  [DataContract(Name = "WCFEinsatz_Fahrzeug", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFEinsatz_Fahrzeug : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AktivField;
    private DateTime BeginnField;
    private string EinsatzNrField;
    private DateTime EndeField;
    private int FahrzeugIDField;
    private int IdField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Aktiv
    {
      get => this.AktivField;
      set => this.AktivField = value;
    }

    [DataMember]
    public DateTime Beginn
    {
      get => this.BeginnField;
      set => this.BeginnField = value;
    }

    [DataMember]
    public string EinsatzNr
    {
      get => this.EinsatzNrField;
      set => this.EinsatzNrField = value;
    }

    [DataMember]
    public DateTime Ende
    {
      get => this.EndeField;
      set => this.EndeField = value;
    }

    [DataMember]
    public int FahrzeugID
    {
      get => this.FahrzeugIDField;
      set => this.FahrzeugIDField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }
  }
}
