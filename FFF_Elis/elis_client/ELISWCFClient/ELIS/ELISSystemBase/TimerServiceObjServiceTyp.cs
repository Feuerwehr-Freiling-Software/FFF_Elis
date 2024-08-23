// Decompiled with JetBrains decompiler
// Type: ELIS.ELISSystemBase.TimerServiceObjServiceTyp
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISSystemBase
{
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "TimerServiceObj.ServiceTyp", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISSystemBase")]
  public enum TimerServiceObjServiceTyp
  {
    [EnumMember] DataSync,
    [EnumMember] SystemTest,
    [EnumMember] ConfigReset,
    [EnumMember] DBMigration,
    [EnumMember] DBSizeReduce,
    [EnumMember] Sicherung,
    [EnumMember] SystemÜberwachungsEMail,
    [EnumMember] ELISRegistration,
    [EnumMember] ELISWebWarmUp,
    [EnumMember] KalenderTTS,
    [EnumMember] KalenderMail,
    [EnumMember] ADSync,
    [EnumMember] DatenIntegritätscheck,
    [EnumMember] PrintWarmUp,
    [EnumMember] SyBOSUserSync,
    [EnumMember] ZeitSync,
    [EnumMember] KarteiReplikation,
    [EnumMember] KalenderSMS,
  }
}
