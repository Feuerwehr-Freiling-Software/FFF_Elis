// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFSondergeraet
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
  [DataContract(Name = "WCFSondergeraet", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFSondergeraet : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string BezeichnungField;
    private WCFFeuerwehr FeuerwehrField;
    private int FeuerwehrIDField;
    private int IdField;
    private WCFKontakt KontaktField;
    private int KontaktIDField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Bezeichnung
    {
      get => this.BezeichnungField;
      set => this.BezeichnungField = value;
    }

    [DataMember]
    public WCFFeuerwehr Feuerwehr
    {
      get => this.FeuerwehrField;
      set => this.FeuerwehrField = value;
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
    public WCFKontakt Kontakt
    {
      get => this.KontaktField;
      set => this.KontaktField = value;
    }

    [DataMember]
    public int KontaktID
    {
      get => this.KontaktIDField;
      set => this.KontaktIDField = value;
    }
  }
}
