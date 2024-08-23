// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFAusrueckeOrdnung
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF.ApDataContracts
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFAusrueckeOrdnung", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFAusrueckeOrdnung : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string EinsatzTypField;
    private WCFFahrzeug FahrzeugField;
    private int FahrzeugIDField;
    private int IdField;
    private int OrdnungField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string EinsatzTyp
    {
      get => this.EinsatzTypField;
      set => this.EinsatzTypField = value;
    }

    [DataMember]
    public WCFFahrzeug Fahrzeug
    {
      get => this.FahrzeugField;
      set => this.FahrzeugField = value;
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

    [DataMember]
    public int Ordnung
    {
      get => this.OrdnungField;
      set => this.OrdnungField = value;
    }
  }
}
