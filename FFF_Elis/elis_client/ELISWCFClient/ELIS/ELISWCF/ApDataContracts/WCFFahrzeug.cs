// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFFahrzeug
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF.ApDataContracts
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFFahrzeug", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFFahrzeug : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AtemschutzField;
    private string BezeichnungField;
    private bool DisabledField;
    private bool DisponierbarField;
    private string FZBildRefField;
    private int FeuerwehrIDField;
    private int IdField;
    private bool ImDienstField;
    private string PumpeField;
    private string StatusInfoField;
    private DateTime StatusInfoZeitField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Atemschutz
    {
      get => this.AtemschutzField;
      set => this.AtemschutzField = value;
    }

    [DataMember]
    public string Bezeichnung
    {
      get => this.BezeichnungField;
      set => this.BezeichnungField = value;
    }

    [DataMember]
    public bool Disabled
    {
      get => this.DisabledField;
      set => this.DisabledField = value;
    }

    [DataMember]
    public bool Disponierbar
    {
      get => this.DisponierbarField;
      set => this.DisponierbarField = value;
    }

    [DataMember]
    public string FZBildRef
    {
      get => this.FZBildRefField;
      set => this.FZBildRefField = value;
    }

    [DataMember]
    public int FeuerwehrID
    {
      get => this.FeuerwehrIDField;
      set => this.FeuerwehrIDField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }

    [DataMember]
    public bool ImDienst
    {
      get => this.ImDienstField;
      set => this.ImDienstField = value;
    }

    [DataMember]
    public string Pumpe
    {
      get => this.PumpeField;
      set => this.PumpeField = value;
    }

    [DataMember]
    public string StatusInfo
    {
      get => this.StatusInfoField;
      set => this.StatusInfoField = value;
    }

    [DataMember]
    public DateTime StatusInfoZeit
    {
      get => this.StatusInfoZeitField;
      set => this.StatusInfoZeitField = value;
    }
  }
}
