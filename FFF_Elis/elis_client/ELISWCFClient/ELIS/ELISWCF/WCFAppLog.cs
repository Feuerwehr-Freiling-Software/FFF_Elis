// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFAppLog
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
  [DataContract(Name = "WCFAppLog", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFAppLog : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private string DeviceFamilyField;
    private string DeviceNameField;
    private string DeviceOSField;
    private string EventTypeField;
    private double GPSAltitudeField;
    private double GPSLatitudeField;
    private double GPSLongitudeField;
    private int IDField;
    private string InfoField;
    private string LocationField;
    private DateTime ZeitField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string DeviceFamily
    {
      get => this.DeviceFamilyField;
      set => this.DeviceFamilyField = value;
    }

    [DataMember]
    public string DeviceName
    {
      get => this.DeviceNameField;
      set => this.DeviceNameField = value;
    }

    [DataMember]
    public string DeviceOS
    {
      get => this.DeviceOSField;
      set => this.DeviceOSField = value;
    }

    [DataMember]
    public string EventType
    {
      get => this.EventTypeField;
      set => this.EventTypeField = value;
    }

    [DataMember]
    public double GPSAltitude
    {
      get => this.GPSAltitudeField;
      set => this.GPSAltitudeField = value;
    }

    [DataMember]
    public double GPSLatitude
    {
      get => this.GPSLatitudeField;
      set => this.GPSLatitudeField = value;
    }

    [DataMember]
    public double GPSLongitude
    {
      get => this.GPSLongitudeField;
      set => this.GPSLongitudeField = value;
    }

    [DataMember]
    public int ID
    {
      get => this.IDField;
      set => this.IDField = value;
    }

    [DataMember]
    public string Info
    {
      get => this.InfoField;
      set => this.InfoField = value;
    }

    [DataMember]
    public string Location
    {
      get => this.LocationField;
      set => this.LocationField = value;
    }

    [DataMember]
    public DateTime Zeit
    {
      get => this.ZeitField;
      set => this.ZeitField = value;
    }
  }
}
