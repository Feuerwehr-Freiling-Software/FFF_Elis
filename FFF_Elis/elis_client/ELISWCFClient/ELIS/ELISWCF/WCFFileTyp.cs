// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFFileTyp
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFFileTyp", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public enum WCFFileTyp
  {
    [EnumMember] Document,
    [EnumMember] Checkliste,
    [EnumMember] WasserentnahmestellenIcon,
    [EnumMember] WasserentnahmestellenBild,
    [EnumMember] EMailAttachment,
    [EnumMember] StraßenKarteiDeckblatt,
    [EnumMember] EinsatzDruckarchivdokument,
    [EnumMember] Wasserentnahmestellenbericht,
    [EnumMember] FahrzeugBild,
    [EnumMember] ObjektKarteiDeckblatt,
    [EnumMember] ObjektKategorieIcon,
  }
}
