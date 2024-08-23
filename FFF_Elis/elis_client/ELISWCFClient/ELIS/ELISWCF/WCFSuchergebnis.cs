// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFSuchergebnis
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFSuchergebnis", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFSuchergebnis : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string DetailField;
    private int ObjIDField;
    private string TitelField;
    private WCFSuchergebnis.WCFSuchergebnisTyp TypField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Detail
    {
      get => this.DetailField;
      set => this.DetailField = value;
    }

    [DataMember]
    public int ObjID
    {
      get => this.ObjIDField;
      set => this.ObjIDField = value;
    }

    [DataMember]
    public string Titel
    {
      get => this.TitelField;
      set => this.TitelField = value;
    }

    [DataMember]
    public WCFSuchergebnis.WCFSuchergebnisTyp Typ
    {
      get => this.TypField;
      set => this.TypField = value;
    }

    [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
    [DataContract(Name = "WCFSuchergebnis.WCFSuchergebnisTyp", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
    public enum WCFSuchergebnisTyp
    {
      [EnumMember] Allgemein,
      [EnumMember] Objektkartei,
      [EnumMember] Checkliste,
      [EnumMember] Straßenkartei,
      [EnumMember] Kontakt,
      [EnumMember] Dokument,
      [EnumMember] ELISBenutzer,
    }
  }
}
