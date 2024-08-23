// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFCheckliste
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
  [DataContract(Name = "WCFCheckliste", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFCheckliste : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AllgemeingueltigField;
    private string DateinameField;
    private string DoknameField;
    private string[] EinsatztypenField;
    private string EinsatzzonenIDListeField;
    private int IdField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Allgemeingueltig
    {
      get => this.AllgemeingueltigField;
      set => this.AllgemeingueltigField = value;
    }

    [DataMember]
    public string Dateiname
    {
      get => this.DateinameField;
      set => this.DateinameField = value;
    }

    [DataMember]
    public string Dokname
    {
      get => this.DoknameField;
      set => this.DoknameField = value;
    }

    [DataMember]
    public string[] Einsatztypen
    {
      get => this.EinsatztypenField;
      set => this.EinsatztypenField = value;
    }

    [DataMember]
    public string EinsatzzonenIDListe
    {
      get => this.EinsatzzonenIDListeField;
      set => this.EinsatzzonenIDListeField = value;
    }

    [DataMember]
    public int Id
    {
      get => this.IdField;
      set => this.IdField = value;
    }
  }
}
