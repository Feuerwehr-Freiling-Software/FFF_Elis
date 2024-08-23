// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFKontaktObj
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
  [DataContract(Name = "WCFKontaktObj", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFKontaktObj : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private int IdField;
    private int KontaktIDField;
    private string TypField;
    private string WertField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }

    [DataMember]
    public int KontaktID
    {
      get => this.KontaktIDField;
      set => this.KontaktIDField = value;
    }

    [DataMember]
    public string Typ
    {
      get => this.TypField;
      set => this.TypField = value;
    }

    [DataMember]
    public string Wert
    {
      get => this.WertField;
      set => this.WertField = value;
    }
  }
}
