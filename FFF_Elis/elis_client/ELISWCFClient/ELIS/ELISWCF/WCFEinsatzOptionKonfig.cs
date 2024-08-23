// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFEinsatzOptionKonfig
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
  [DataContract(Name = "WCFEinsatzOptionKonfig", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFEinsatzOptionKonfig : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool ELISAppServiceActiveField;
    private bool ELISMessagingActiveField;
    private bool ELISPrinterActiveField;
    private bool ELISText2SpeechActiveField;
    private bool PrintChecklisteALARMIERTField;
    private bool PrintChecklisteAUSGERUECKTField;
    private bool PrintChecklisteERLEDIGTField;
    private bool PrintEinsatzkarteiALARMIERTField;
    private bool PrintEinsatzkarteiAUSGERUECKTField;
    private bool PrintEinsatzkarteiERLEDIGTField;
    private bool PrintEinsatzprotokollALARMIERTField;
    private bool PrintEinsatzprotokollAUSGERUECKTField;
    private bool PrintEinsatzprotokollERLEDIGTField;
    private bool PrintGoogleMapALARMIERTField;
    private bool PrintGoogleMapAUSGERUECKTField;
    private bool PrintGoogleMapERLEDIGTField;
    private bool PrintLFKMeldungALARMIERTField;
    private bool PrintLFKMeldungAUSGERUECKTField;
    private bool PrintLFKMeldungERLEDIGTField;
    private bool PrintWASMeldungALARMIERTField;
    private bool PrintWASMeldungAUSGERUECKTField;
    private bool PrintWASMeldungERLEDIGTField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool ELISAppServiceActive
    {
      get => this.ELISAppServiceActiveField;
      set => this.ELISAppServiceActiveField = value;
    }

    [DataMember]
    public bool ELISMessagingActive
    {
      get => this.ELISMessagingActiveField;
      set => this.ELISMessagingActiveField = value;
    }

    [DataMember]
    public bool ELISPrinterActive
    {
      get => this.ELISPrinterActiveField;
      set => this.ELISPrinterActiveField = value;
    }

    [DataMember]
    public bool ELISText2SpeechActive
    {
      get => this.ELISText2SpeechActiveField;
      set => this.ELISText2SpeechActiveField = value;
    }

    [DataMember]
    public bool PrintChecklisteALARMIERT
    {
      get => this.PrintChecklisteALARMIERTField;
      set => this.PrintChecklisteALARMIERTField = value;
    }

    [DataMember]
    public bool PrintChecklisteAUSGERUECKT
    {
      get => this.PrintChecklisteAUSGERUECKTField;
      set => this.PrintChecklisteAUSGERUECKTField = value;
    }

    [DataMember]
    public bool PrintChecklisteERLEDIGT
    {
      get => this.PrintChecklisteERLEDIGTField;
      set => this.PrintChecklisteERLEDIGTField = value;
    }

    [DataMember]
    public bool PrintEinsatzkarteiALARMIERT
    {
      get => this.PrintEinsatzkarteiALARMIERTField;
      set => this.PrintEinsatzkarteiALARMIERTField = value;
    }

    [DataMember]
    public bool PrintEinsatzkarteiAUSGERUECKT
    {
      get => this.PrintEinsatzkarteiAUSGERUECKTField;
      set => this.PrintEinsatzkarteiAUSGERUECKTField = value;
    }

    [DataMember]
    public bool PrintEinsatzkarteiERLEDIGT
    {
      get => this.PrintEinsatzkarteiERLEDIGTField;
      set => this.PrintEinsatzkarteiERLEDIGTField = value;
    }

    [DataMember]
    public bool PrintEinsatzprotokollALARMIERT
    {
      get => this.PrintEinsatzprotokollALARMIERTField;
      set => this.PrintEinsatzprotokollALARMIERTField = value;
    }

    [DataMember]
    public bool PrintEinsatzprotokollAUSGERUECKT
    {
      get => this.PrintEinsatzprotokollAUSGERUECKTField;
      set => this.PrintEinsatzprotokollAUSGERUECKTField = value;
    }

    [DataMember]
    public bool PrintEinsatzprotokollERLEDIGT
    {
      get => this.PrintEinsatzprotokollERLEDIGTField;
      set => this.PrintEinsatzprotokollERLEDIGTField = value;
    }

    [DataMember]
    public bool PrintGoogleMapALARMIERT
    {
      get => this.PrintGoogleMapALARMIERTField;
      set => this.PrintGoogleMapALARMIERTField = value;
    }

    [DataMember]
    public bool PrintGoogleMapAUSGERUECKT
    {
      get => this.PrintGoogleMapAUSGERUECKTField;
      set => this.PrintGoogleMapAUSGERUECKTField = value;
    }

    [DataMember]
    public bool PrintGoogleMapERLEDIGT
    {
      get => this.PrintGoogleMapERLEDIGTField;
      set => this.PrintGoogleMapERLEDIGTField = value;
    }

    [DataMember]
    public bool PrintLFKMeldungALARMIERT
    {
      get => this.PrintLFKMeldungALARMIERTField;
      set => this.PrintLFKMeldungALARMIERTField = value;
    }

    [DataMember]
    public bool PrintLFKMeldungAUSGERUECKT
    {
      get => this.PrintLFKMeldungAUSGERUECKTField;
      set => this.PrintLFKMeldungAUSGERUECKTField = value;
    }

    [DataMember]
    public bool PrintLFKMeldungERLEDIGT
    {
      get => this.PrintLFKMeldungERLEDIGTField;
      set => this.PrintLFKMeldungERLEDIGTField = value;
    }

    [DataMember]
    public bool PrintWASMeldungALARMIERT
    {
      get => this.PrintWASMeldungALARMIERTField;
      set => this.PrintWASMeldungALARMIERTField = value;
    }

    [DataMember]
    public bool PrintWASMeldungAUSGERUECKT
    {
      get => this.PrintWASMeldungAUSGERUECKTField;
      set => this.PrintWASMeldungAUSGERUECKTField = value;
    }

    [DataMember]
    public bool PrintWASMeldungERLEDIGT
    {
      get => this.PrintWASMeldungERLEDIGTField;
      set => this.PrintWASMeldungERLEDIGTField = value;
    }
  }
}
