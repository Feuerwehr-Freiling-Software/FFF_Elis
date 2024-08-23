// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFPerson
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
  [DataContract(Name = "WCFPerson", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFPerson : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string DienstgradField;
    private int EDVNrField;
    private string NachnameField;
    private int StatusField;
    private string VornameField;
    private int idField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Dienstgrad
    {
      get => this.DienstgradField;
      set => this.DienstgradField = value;
    }

    [DataMember]
    public int EDVNr
    {
      get => this.EDVNrField;
      set => this.EDVNrField = value;
    }

    [DataMember]
    public string Nachname
    {
      get => this.NachnameField;
      set => this.NachnameField = value;
    }

    [DataMember]
    public int Status
    {
      get => this.StatusField;
      set => this.StatusField = value;
    }

    [DataMember]
    public string Vorname
    {
      get => this.VornameField;
      set => this.VornameField = value;
    }

    [DataMember]
    public int id
    {
      get => this.idField;
      set => this.idField = value;
    }
  }
}
