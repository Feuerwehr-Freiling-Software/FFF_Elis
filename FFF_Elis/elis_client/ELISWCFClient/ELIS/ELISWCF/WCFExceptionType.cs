// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCF.WCFExceptionType
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace ELIS.ELISWCF
{
  [GeneratedCode("System.Runtime.Serialization", "3.0.0.0")]
  [DataContract(Name = "WCFExceptionType", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  public enum WCFExceptionType
  {
    [EnumMember] FORBIDDEN,
    [EnumMember] NOUSER,
    [EnumMember] INVALIDTICKET,
    [EnumMember] ERROR,
    [EnumMember] USERINACTIVE,
    [EnumMember] CLIENTVERSIONUPDATEREQUIRED,
    [EnumMember] PASSWORDPOLICYMISSMATCH,
  }
}
