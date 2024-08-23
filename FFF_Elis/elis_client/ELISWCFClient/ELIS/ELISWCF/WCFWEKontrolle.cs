// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFWEKontrolle
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFWEKontrolle", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFWEKontrolle : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string BeschreibungField;
    private DateTime DatumField;
    private int DauerField;
    private string KurzinfoField;
    private WCFPerson[] PrüferField;
    private WCFWasserentnahmen WasserEntnahmeField;
    private int idField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string Beschreibung
    {
      get => this.BeschreibungField;
      set => this.BeschreibungField = value;
    }

    [DataMember]
    public DateTime Datum
    {
      get => this.DatumField;
      set => this.DatumField = value;
    }

    [DataMember]
    public int Dauer
    {
      get => this.DauerField;
      set => this.DauerField = value;
    }

    [DataMember]
    public string Kurzinfo
    {
      get => this.KurzinfoField;
      set => this.KurzinfoField = value;
    }

    [DataMember]
    public WCFPerson[] Prüfer
    {
      get => this.PrüferField;
      set => this.PrüferField = value;
    }

    [DataMember]
    public WCFWasserentnahmen WasserEntnahme
    {
      get => this.WasserEntnahmeField;
      set => this.WasserEntnahmeField = value;
    }

    [DataMember]
    public int id
    {
      get => this.idField;
      set => this.idField = value;
    }
  }
}
