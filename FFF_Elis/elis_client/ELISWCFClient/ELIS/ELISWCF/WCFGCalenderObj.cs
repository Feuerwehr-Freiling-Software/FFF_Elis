// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFGCalenderObj
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
  [DataContract(Name = "WCFGCalenderObj", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public class WCFGCalenderObj : IExtensibleDataObject
  {
    private ExtensionDataObject extensionDataField;
    private DateTime BeginField;
    private string DetailField;
    private DateTime EndeField;
    private string EventIDField;
    private bool GanztaegigField;
    private string KalenderNameField;
    private string OrtField;
    private string TitelField;

    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public DateTime Begin
    {
      get => this.BeginField;
      set => this.BeginField = value;
    }

    [DataMember]
    public string Detail
    {
      get => this.DetailField;
      set => this.DetailField = value;
    }

    [DataMember]
    public DateTime Ende
    {
      get => this.EndeField;
      set => this.EndeField = value;
    }

    [DataMember]
    public string EventID
    {
      get => this.EventIDField;
      set => this.EventIDField = value;
    }

    [DataMember]
    public bool Ganztaegig
    {
      get => this.GanztaegigField;
      set => this.GanztaegigField = value;
    }

    [DataMember]
    public string KalenderName
    {
      get => this.KalenderNameField;
      set => this.KalenderNameField = value;
    }

    [DataMember]
    public string Ort
    {
      get => this.OrtField;
      set => this.OrtField = value;
    }

    [DataMember]
    public string Titel
    {
      get => this.TitelField;
      set => this.TitelField = value;
    }
  }
}
