// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFObjektKategorie
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
  [DataContract(Name = "WCFObjektKategorie", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFObjektKategorie : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private int IDField;
    private string IconRefField;
    private string NameField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public string IconRef
    {
      get => this.IconRefField;
      set => this.IconRefField = value;
    }

    [DataMember]
    public string Name
    {
      get => this.NameField;
      set => this.NameField = value;
    }
  }
}
