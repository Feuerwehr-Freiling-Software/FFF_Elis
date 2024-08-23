// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.ApDataContracts.WCFKontakt
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
  [DataContract(Name = "WCFKontakt", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF.ApDataContracts")]
  public class WCFKontakt : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private WCFKontaktObj[] AdressenField;
    private int IdField;
    private string NameField;
    private string OrtField;
    private int PLZField;
    private string StrasseField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public WCFKontaktObj[] Adressen
    {
      get => this.AdressenField;
      set => this.AdressenField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }

    [DataMember]
    public string Name
    {
      get => this.NameField;
      set => this.NameField = value;
    }

    [DataMember]
    public string Ort
    {
      get => this.OrtField;
      set => this.OrtField = value;
    }

    [DataMember]
    public int PLZ
    {
      get => this.PLZField;
      set => this.PLZField = value;
    }

    [DataMember]
    public string Strasse
    {
      get => this.StrasseField;
      set => this.StrasseField = value;
    }
  }
}
