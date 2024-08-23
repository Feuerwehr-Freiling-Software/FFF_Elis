// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFWasserEntnahmeStellenTyp
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFWasserEntnahmeStellenTyp", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public enum WCFWasserEntnahmeStellenTyp
  {
    [EnumMember] OH = 1,
    [EnumMember] UH = 2,
    [EnumMember] Brunnen = 3,
    [EnumMember] Löschteich = 4,
    [EnumMember] BachMitStau = 5,
    [EnumMember] LöschwasserBehälter = 6,
    [EnumMember] Pumpe = 7,
    [EnumMember] Saugstelle = 8,
    [EnumMember] Sonstiges = 9,
    [EnumMember] Steigleitung = 10, // 0x0000000A
  }
}
