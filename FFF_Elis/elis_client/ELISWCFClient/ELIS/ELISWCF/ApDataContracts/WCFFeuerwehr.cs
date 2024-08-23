// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFFeuerwehr
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
  [DataContract(Name = "WCFFeuerwehr", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFFeuerwehr : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool DisabledField;
    private int EdvIDField;
    private string FeuerwehrGuidField;
    private string FeuerwehrnameField;
    private string FunkrufnameField;
    private int IdField;
    private int KdtIDField;
    private WCFKontakt KdtKontaktField;
    private int KdtStvIDField;
    private WCFKontakt KdtStvKontaktField;
    private WCFKontakt KontaktField;
    private int KontaktIDField;
    private bool PflichtbereichField;
    private int SirenenCodeField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Disabled
    {
      get => this.DisabledField;
      set => this.DisabledField = value;
    }

    [DataMember]
    public int EdvID
    {
      get => this.EdvIDField;
      set => this.EdvIDField = value;
    }

    [DataMember]
    public string FeuerwehrGuid
    {
      get => this.FeuerwehrGuidField;
      set => this.FeuerwehrGuidField = value;
    }

    [DataMember]
    public string Feuerwehrname
    {
      get => this.FeuerwehrnameField;
      set => this.FeuerwehrnameField = value;
    }

    [DataMember]
    public string Funkrufname
    {
      get => this.FunkrufnameField;
      set => this.FunkrufnameField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }

    [DataMember]
    public int KdtID
    {
      get => this.KdtIDField;
      set => this.KdtIDField = value;
    }

    [DataMember]
    public WCFKontakt KdtKontakt
    {
      get => this.KdtKontaktField;
      set => this.KdtKontaktField = value;
    }

    [DataMember]
    public int KdtStvID
    {
      get => this.KdtStvIDField;
      set => this.KdtStvIDField = value;
    }

    [DataMember]
    public WCFKontakt KdtStvKontakt
    {
      get => this.KdtStvKontaktField;
      set => this.KdtStvKontaktField = value;
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

    [DataMember]
    public bool Pflichtbereich
    {
      get => this.PflichtbereichField;
      set => this.PflichtbereichField = value;
    }

    [DataMember]
    public int SirenenCode
    {
      get => this.SirenenCodeField;
      set => this.SirenenCodeField = value;
    }
  }
}
