// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFFremdhilfeLeister
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
  [DataContract(Name = "WCFFremdhilfeLeister", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFFremdhilfeLeister : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private int FremdhilfeArtIdField;
    private string GeraetField;
    private int IdField;
    private WCFKontakt KontaktField;
    private int KontaktIDField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public int FremdhilfeArtId
    {
      get => this.FremdhilfeArtIdField;
      set => this.FremdhilfeArtIdField = value;
    }

    [DataMember]
    public string Geraet
    {
      get => this.GeraetField;
      set => this.GeraetField = value;
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
