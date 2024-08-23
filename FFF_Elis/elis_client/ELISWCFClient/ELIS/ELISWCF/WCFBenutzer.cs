// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFBenutzer
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
  [DataContract(Name = "WCFBenutzer", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFBenutzer : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private bool AktivField;
    private WCFBerechtigungen[] BerechtigungenField;
    private string DienstgradField;
    private string EMailField;
    private string EMail2Field;
    private bool EMailAlarmField;
    private bool EMailAusgerField;
    private bool EMailErldgtField;
    private string FeuerwehrGuidField;
    private WCFBenutzerGruppe[] GruppeField;
    private int IDField;
    private bool IsADBenutzerField;
    private DateTime LetzterLoginField;
    private string LoginField;
    private string NachnameField;
    private string PasswortField;
    private bool SMSAlarmField;
    private bool SMSAusgerField;
    private bool SMSErldgtField;
    private int SyBOSIDField;
    private string TelField;
    private string VornameField;
    private bool WCFLoggingField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Aktiv
    {
      get => this.AktivField;
      set => this.AktivField = value;
    }

    [DataMember]
    public WCFBerechtigungen[] Berechtigungen
    {
      get => this.BerechtigungenField;
      set => this.BerechtigungenField = value;
    }

    [DataMember]
    public string Dienstgrad
    {
      get => this.DienstgradField;
      set => this.DienstgradField = value;
    }

    [DataMember]
    public string EMail
    {
      get => this.EMailField;
      set => this.EMailField = value;
    }

    [DataMember]
    public string EMail2
    {
      get => this.EMail2Field;
      set => this.EMail2Field = value;
    }

    [DataMember]
    public bool EMailAlarm
    {
      get => this.EMailAlarmField;
      set => this.EMailAlarmField = value;
    }

    [DataMember]
    public bool EMailAusger
    {
      get => this.EMailAusgerField;
      set => this.EMailAusgerField = value;
    }

    [DataMember]
    public bool EMailErldgt
    {
      get => this.EMailErldgtField;
      set => this.EMailErldgtField = value;
    }

    [DataMember]
    public string FeuerwehrGuid
    {
      get => this.FeuerwehrGuidField;
      set => this.FeuerwehrGuidField = value;
    }

    [DataMember]
    public WCFBenutzerGruppe[] Gruppe
    {
      get => this.GruppeField;
      set => this.GruppeField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public bool IsADBenutzer
    {
      get => this.IsADBenutzerField;
      set => this.IsADBenutzerField = value;
    }

    [DataMember]
    public DateTime LetzterLogin
    {
      get => this.LetzterLoginField;
      set => this.LetzterLoginField = value;
    }

    [DataMember]
    public string Login
    {
      get => this.LoginField;
      set => this.LoginField = value;
    }

    [DataMember]
    public string Nachname
    {
      get => this.NachnameField;
      set => this.NachnameField = value;
    }

    [DataMember]
    public string Passwort
    {
      get => this.PasswortField;
      set => this.PasswortField = value;
    }

    [DataMember]
    public bool SMSAlarm
    {
      get => this.SMSAlarmField;
      set => this.SMSAlarmField = value;
    }

    [DataMember]
    public bool SMSAusger
    {
      get => this.SMSAusgerField;
      set => this.SMSAusgerField = value;
    }

    [DataMember]
    public bool SMSErldgt
    {
      get => this.SMSErldgtField;
      set => this.SMSErldgtField = value;
    }

    [DataMember]
    public int SyBOSID
    {
      get => this.SyBOSIDField;
      set => this.SyBOSIDField = value;
    }

    [DataMember]
    public string Tel
    {
      get => this.TelField;
      set => this.TelField = value;
    }

    [DataMember]
    public string Vorname
    {
      get => this.VornameField;
      set => this.VornameField = value;
    }

    [DataMember]
    public bool WCFLogging
    {
      get => this.WCFLoggingField;
      set => this.WCFLoggingField = value;
    }
  }
}
