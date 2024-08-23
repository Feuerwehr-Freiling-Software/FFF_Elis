// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFAusfahrtsrichtung
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
  [DataContract(Name = "WCFAusfahrtsrichtung", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFAusfahrtsrichtung : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string RichtungField;
    private int idField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Richtung
    {
      get => this.RichtungField;
      set => this.RichtungField = value;
    }

    [DataMember]
    public int id
    {
      get => this.idField;
      set => this.idField = value;
    }
  }
}
