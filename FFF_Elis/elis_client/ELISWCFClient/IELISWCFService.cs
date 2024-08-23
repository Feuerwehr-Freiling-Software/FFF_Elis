// Decompiled with JetBrains decompiler
// Type: IELISWCFService
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using ELIS.ELISWCF;
using ELIS.ELISWCF.ApDataContracts;
using ELIS.ServiceConfigBase;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;

#nullable disable
[GeneratedCode("System.ServiceModel", "3.0.0.0")]
[ServiceContract(ConfigurationName = "IELISWCFService")]
public interface IELISWCFService
{
  [OperationContract(Action = "http://tempuri.org/IELISWCFService/NewWASNrGet", ReplyAction = "http://tempuri.org/IELISWCFService/NewWASNrGetResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/NewWASNrGetWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string NewWASNrGet();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/NewWASNrGet", ReplyAction = "http://tempuri.org/IELISWCFService/NewWASNrGetResponse")]
  IAsyncResult BeginNewWASNrGet(AsyncCallback callback, object asyncState);

  string EndNewWASNrGet(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/NewEinsatzGuidGet", ReplyAction = "http://tempuri.org/IELISWCFService/NewEinsatzGuidGetResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/NewEinsatzGuidGetWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string NewEinsatzGuidGet();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/NewEinsatzGuidGet", ReplyAction = "http://tempuri.org/IELISWCFService/NewEinsatzGuidGetResponse")]
  IAsyncResult BeginNewEinsatzGuidGet(AsyncCallback callback, object asyncState);

  string EndNewEinsatzGuidGet(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzPersonenStatusAktiviert", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzPersonenStatusAktiviertResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzPersonenStatusAktiviertWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EinsatzPersonenStatusAktiviert();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzPersonenStatusAktiviert", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzPersonenStatusAktiviertResponse")]
  IAsyncResult BeginEinsatzPersonenStatusAktiviert(AsyncCallback callback, object asyncState);

  bool EndEinsatzPersonenStatusAktiviert(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzPersonPersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzPersonPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzPersonPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EinsatzPersonPersist(string einsatzNr, string mail, string status, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzPersonPersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzPersonPersistResponse")]
  IAsyncResult BeginEinsatzPersonPersist(
    string einsatzNr,
    string mail,
    string status,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEinsatzPersonPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzPersonGetByEinsatz", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzPersonGetByEinsatzResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzPersonGetByEinsatzWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  Dictionary<string, bool> EinsatzPersonGetByEinsatz(string einsatzNr, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzPersonGetByEinsatz", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzPersonGetByEinsatzResponse")]
  IAsyncResult BeginEinsatzPersonGetByEinsatz(
    string einsatzNr,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  Dictionary<string, bool> EndEinsatzPersonGetByEinsatz(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FileDownload", ReplyAction = "http://tempuri.org/IELISWCFService/FileDownloadResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FileDownloadWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  Stream FileDownload(string fileName, WCFFileTyp ft, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FileDownload", ReplyAction = "http://tempuri.org/IELISWCFService/FileDownloadResponse")]
  IAsyncResult BeginFileDownload(
    string fileName,
    WCFFileTyp ft,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  Stream EndFileDownload(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FileUpload", ReplyAction = "http://tempuri.org/IELISWCFService/FileUploadResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FileUploadWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void FileUpload(string fileName, byte[] data, WCFFileTyp ft, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FileUpload", ReplyAction = "http://tempuri.org/IELISWCFService/FileUploadResponse")]
  IAsyncResult BeginFileUpload(
    string fileName,
    byte[] data,
    WCFFileTyp ft,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndFileUpload(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FileCheckExists", ReplyAction = "http://tempuri.org/IELISWCFService/FileCheckExistsResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FileCheckExistsWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool FileCheckExists(string fileName, WCFFileTyp ft, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FileCheckExists", ReplyAction = "http://tempuri.org/IELISWCFService/FileCheckExistsResponse")]
  IAsyncResult BeginFileCheckExists(
    string fileName,
    WCFFileTyp ft,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndFileCheckExists(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FileGetLastModificationDate", ReplyAction = "http://tempuri.org/IELISWCFService/FileGetLastModificationDateResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FileGetLastModificationDateWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  DateTime? FileGetLastModificationDate(string fileName, WCFFileTyp ft, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FileGetLastModificationDate", ReplyAction = "http://tempuri.org/IELISWCFService/FileGetLastModificationDateResponse")]
  IAsyncResult BeginFileGetLastModificationDate(
    string fileName,
    WCFFileTyp ft,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  DateTime? EndFileGetLastModificationDate(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WCFTicketGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/WCFTicketGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WCFTicketGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFTicket[] WCFTicketGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WCFTicketGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/WCFTicketGetAllResponse")]
  IAsyncResult BeginWCFTicketGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFTicket[] EndWCFTicketGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WCFTicketGetFiltered", ReplyAction = "http://tempuri.org/IELISWCFService/WCFTicketGetFilteredResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WCFTicketGetFilteredWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFTicket[] WCFTicketGetFiltered(string name, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WCFTicketGetFiltered", ReplyAction = "http://tempuri.org/IELISWCFService/WCFTicketGetFilteredResponse")]
  IAsyncResult BeginWCFTicketGetFiltered(
    string name,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFTicket[] EndWCFTicketGetFiltered(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WCFLogGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WCFLogGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFLog[] WCFLogGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WCFLogGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogGetAllResponse")]
  IAsyncResult BeginWCFLogGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFLog[] EndWCFLogGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WCFLogGetbyNr", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogGetbyNrResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WCFLogGetbyNrWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFLog[] WCFLogGetbyNr(int start, int end, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WCFLogGetbyNr", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogGetbyNrResponse")]
  IAsyncResult BeginWCFLogGetbyNr(
    int start,
    int end,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFLog[] EndWCFLogGetbyNr(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WCFLogGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogGetCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WCFLogGetCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int WCFLogGetCount(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WCFLogGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogGetCountResponse")]
  IAsyncResult BeginWCFLogGetCount(Guid TicketID, AsyncCallback callback, object asyncState);

  int EndWCFLogGetCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WCFLogGetByTicket", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogGetByTicketResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WCFLogGetByTicketWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFLog[] WCFLogGetByTicket(Guid QueryTicket, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WCFLogGetByTicket", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogGetByTicketResponse")]
  IAsyncResult BeginWCFLogGetByTicket(
    Guid QueryTicket,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFLog[] EndWCFLogGetByTicket(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WCFLogDeleteAll", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogDeleteAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WCFLogDeleteAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int WCFLogDeleteAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WCFLogDeleteAll", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogDeleteAllResponse")]
  IAsyncResult BeginWCFLogDeleteAll(Guid TicketID, AsyncCallback callback, object asyncState);

  int EndWCFLogDeleteAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WCFLogDeleteTicket", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogDeleteTicketResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WCFLogDeleteTicketWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool WCFLogDeleteTicket(WCFTicket ticket, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WCFLogDeleteTicket", ReplyAction = "http://tempuri.org/IELISWCFService/WCFLogDeleteTicketResponse")]
  IAsyncResult BeginWCFLogDeleteTicket(
    WCFTicket ticket,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndWCFLogDeleteTicket(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SystemLogGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SystemLogGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFSystemLog[] SystemLogGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SystemLogGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogGetAllResponse")]
  IAsyncResult BeginSystemLogGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFSystemLog[] EndSystemLogGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SystemLogWrite", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogWriteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SystemLogWriteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool SystemLogWrite(WCFSystemLog log);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SystemLogWrite", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogWriteResponse")]
  IAsyncResult BeginSystemLogWrite(WCFSystemLog log, AsyncCallback callback, object asyncState);

  bool EndSystemLogWrite(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AppLogWrite", ReplyAction = "http://tempuri.org/IELISWCFService/AppLogWriteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AppLogWriteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool AppLogWrite(WCFAppLog log, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AppLogWrite", ReplyAction = "http://tempuri.org/IELISWCFService/AppLogWriteResponse")]
  IAsyncResult BeginAppLogWrite(
    WCFAppLog log,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndAppLogWrite(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SystemLogGetAllModuleNames", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogGetAllModuleNamesResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SystemLogGetAllModuleNamesWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] SystemLogGetAllModuleNames(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SystemLogGetAllModuleNames", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogGetAllModuleNamesResponse")]
  IAsyncResult BeginSystemLogGetAllModuleNames(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  string[] EndSystemLogGetAllModuleNames(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SystemLogGetRowCount", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogGetRowCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SystemLogGetRowCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int SystemLogGetRowCount(string modulFilter, string eventTypFilter, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SystemLogGetRowCount", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogGetRowCountResponse")]
  IAsyncResult BeginSystemLogGetRowCount(
    string modulFilter,
    string eventTypFilter,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndSystemLogGetRowCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SystemLogGetFilteredRange", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogGetFilteredRangeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SystemLogGetFilteredRangeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFSystemLog[] SystemLogGetFilteredRange(
    int startRowIndex,
    int maximumRows,
    string modulFilter,
    string eventTypFilter,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SystemLogGetFilteredRange", ReplyAction = "http://tempuri.org/IELISWCFService/SystemLogGetFilteredRangeResponse")]
  IAsyncResult BeginSystemLogGetFilteredRange(
    int startRowIndex,
    int maximumRows,
    string modulFilter,
    string eventTypFilter,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFSystemLog[] EndSystemLogGetFilteredRange(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFTimerServiceLog[] TimerServiceLogGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAllResponse")]
  IAsyncResult BeginTimerServiceLogGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFTimerServiceLog[] EndTimerServiceLogGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAllTimerServiceNames", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAllTimerServiceNamesResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAllTimerServiceNamesWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] TimerServiceLogGetAllTimerServiceNames(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAllTimerServiceNames", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServiceLogGetAllTimerServiceNamesResponse")]
  IAsyncResult BeginTimerServiceLogGetAllTimerServiceNames(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  string[] EndTimerServiceLogGetAllTimerServiceNames(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetRowCount", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServiceLogGetRowCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetRowCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int TimerServiceLogGetRowCount(string modulFilter, string eventTypFilter, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetRowCount", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServiceLogGetRowCountResponse")]
  IAsyncResult BeginTimerServiceLogGetRowCount(
    string modulFilter,
    string eventTypFilter,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndTimerServiceLogGetRowCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetFilteredRange", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServiceLogGetFilteredRangeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetFilteredRangeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFTimerServiceLog[] TimerServiceLogGetFilteredRange(
    int startRowIndex,
    int maximumRows,
    string modulFilter,
    string eventTypFilter,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/TimerServiceLogGetFilteredRange", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServiceLogGetFilteredRangeResponse")]
  IAsyncResult BeginTimerServiceLogGetFilteredRange(
    int startRowIndex,
    int maximumRows,
    string modulFilter,
    string eventTypFilter,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFTimerServiceLog[] EndTimerServiceLogGetFilteredRange(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/PrintKartei", ReplyAction = "http://tempuri.org/IELISWCFService/PrintKarteiResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/PrintKarteiWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void PrintKartei(string address, string printer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/PrintKartei", ReplyAction = "http://tempuri.org/IELISWCFService/PrintKarteiResponse")]
  IAsyncResult BeginPrintKartei(
    string address,
    string printer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndPrintKartei(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/PrintWASEinsatzbericht", ReplyAction = "http://tempuri.org/IELISWCFService/PrintWASEinsatzberichtResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/PrintWASEinsatzberichtWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void PrintWASEinsatzbericht(WCFEinsatzdaten wed, string printer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/PrintWASEinsatzbericht", ReplyAction = "http://tempuri.org/IELISWCFService/PrintWASEinsatzberichtResponse")]
  IAsyncResult BeginPrintWASEinsatzbericht(
    WCFEinsatzdaten wed,
    string printer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndPrintWASEinsatzbericht(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/PrintLFKEinsatzmeldung", ReplyAction = "http://tempuri.org/IELISWCFService/PrintLFKEinsatzmeldungResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/PrintLFKEinsatzmeldungWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void PrintLFKEinsatzmeldung(WCFEinsatzdaten wed, string printer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/PrintLFKEinsatzmeldung", ReplyAction = "http://tempuri.org/IELISWCFService/PrintLFKEinsatzmeldungResponse")]
  IAsyncResult BeginPrintLFKEinsatzmeldung(
    WCFEinsatzdaten wed,
    string printer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndPrintLFKEinsatzmeldung(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/PrintCheckliste", ReplyAction = "http://tempuri.org/IELISWCFService/PrintChecklisteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/PrintChecklisteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void PrintCheckliste(string einsatzGrund, string printer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/PrintCheckliste", ReplyAction = "http://tempuri.org/IELISWCFService/PrintChecklisteResponse")]
  IAsyncResult BeginPrintCheckliste(
    string einsatzGrund,
    string printer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndPrintCheckliste(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/PrintEinsatzprotokoll", ReplyAction = "http://tempuri.org/IELISWCFService/PrintEinsatzprotokollResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/PrintEinsatzprotokollWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void PrintEinsatzprotokoll(WCFEinsatzdaten wed, string printer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/PrintEinsatzprotokoll", ReplyAction = "http://tempuri.org/IELISWCFService/PrintEinsatzprotokollResponse")]
  IAsyncResult BeginPrintEinsatzprotokoll(
    WCFEinsatzdaten wed,
    string printer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndPrintEinsatzprotokoll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/PrintAnfahrtEinsatzortübersicht", ReplyAction = "http://tempuri.org/IELISWCFService/PrintAnfahrtEinsatzortübersichtResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/PrintAnfahrtEinsatzortübersichtWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void PrintAnfahrtEinsatzortübersicht(WCFEinsatzdaten wed, string printer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/PrintAnfahrtEinsatzortübersicht", ReplyAction = "http://tempuri.org/IELISWCFService/PrintAnfahrtEinsatzortübersichtResponse")]
  IAsyncResult BeginPrintAnfahrtEinsatzortübersicht(
    WCFEinsatzdaten wed,
    string printer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndPrintAnfahrtEinsatzortübersicht(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/PrintGetPrinters", ReplyAction = "http://tempuri.org/IELISWCFService/PrintGetPrintersResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/PrintGetPrintersWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] PrintGetPrinters(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/PrintGetPrinters", ReplyAction = "http://tempuri.org/IELISWCFService/PrintGetPrintersResponse")]
  IAsyncResult BeginPrintGetPrinters(Guid TicketID, AsyncCallback callback, object asyncState);

  string[] EndPrintGetPrinters(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungenGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungenGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAusfahrtsrichtung[] AusfahrtsrichtungenGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungenGetAllResponse")]
  IAsyncResult BeginAusfahrtsrichtungenGetAll(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAusfahrtsrichtung[] EndAusfahrtsrichtungenGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungPersist", ReplyAction = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int AusfahrtsrichtungPersist(WCFAusfahrtsrichtung wa, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungPersist", ReplyAction = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungPersistResponse")]
  IAsyncResult BeginAusfahrtsrichtungPersist(
    WCFAusfahrtsrichtung wa,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndAusfahrtsrichtungPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool AusfahrtsrichtungDelete(WCFAusfahrtsrichtung wa, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AusfahrtsrichtungDeleteResponse")]
  IAsyncResult BeginAusfahrtsrichtungDelete(
    WCFAusfahrtsrichtung wa,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndAusfahrtsrichtungDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SystemTestStart", ReplyAction = "http://tempuri.org/IELISWCFService/SystemTestStartResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SystemTestStartWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool SystemTestStart(WCFEinsatzOptionen optionen, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SystemTestStart", ReplyAction = "http://tempuri.org/IELISWCFService/SystemTestStartResponse")]
  IAsyncResult BeginSystemTestStart(
    WCFEinsatzOptionen optionen,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndSystemTestStart(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppePersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppePersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppePersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EinsatzTyp_GruppePersist(WCFEinsatzTypGruppe etg, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppePersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppePersistResponse")]
  IAsyncResult BeginEinsatzTyp_GruppePersist(
    WCFEinsatzTypGruppe etg,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEinsatzTyp_GruppePersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppeRemove", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppeRemoveResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppeRemoveWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EinsatzTyp_GruppeRemove(int etg, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppeRemove", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppeRemoveResponse")]
  IAsyncResult BeginEinsatzTyp_GruppeRemove(
    int etg,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEinsatzTyp_GruppeRemove(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeGetByEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppeGetByEinsatzTypResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeGetByEinsatzTypWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFBenutzerGruppe[] BenutzerGruppeGetByEinsatzTyp(string EinsatzTyp, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeGetByEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppeGetByEinsatzTypResponse")]
  IAsyncResult BeginBenutzerGruppeGetByEinsatzTyp(
    string EinsatzTyp,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFBenutzerGruppe[] EndBenutzerGruppeGetByEinsatzTyp(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFBenutzerGruppe[] BenutzerGruppenGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetAllResponse")]
  IAsyncResult BeginBenutzerGruppenGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFBenutzerGruppe[] EndBenutzerGruppenGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetByBenutzer", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetByBenutzerResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetByBenutzerWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFBenutzerGruppe[] BenutzerGruppenGetByBenutzer(WCFBenutzer benutzer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetByBenutzer", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppenGetByBenutzerResponse")]
  IAsyncResult BeginBenutzerGruppenGetByBenutzer(
    WCFBenutzer benutzer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFBenutzerGruppe[] EndBenutzerGruppenGetByBenutzer(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzTypGruppe[] EinsatzTyp_GruppenGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetAllResponse")]
  IAsyncResult BeginEinsatzTyp_GruppenGetAll(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzTypGruppe[] EndEinsatzTyp_GruppenGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetByGruppe", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetByGruppeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetByGruppeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzTypGruppe[] EinsatzTyp_GruppenGetByGruppe(WCFBenutzerGruppe gruppe, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetByGruppe", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTyp_GruppenGetByGruppeResponse")]
  IAsyncResult BeginEinsatzTyp_GruppenGetByGruppe(
    WCFBenutzerGruppe gruppe,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzTypGruppe[] EndEinsatzTyp_GruppenGetByGruppe(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGetByBenutzerGruppenId", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGetByBenutzerGruppenIdResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGetByBenutzerGruppenIdWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFBenutzer[] BenutzerGetByBenutzerGruppenId(int gruppeId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGetByBenutzerGruppenId", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGetByBenutzerGruppenIdResponse")]
  IAsyncResult BeginBenutzerGetByBenutzerGruppenId(
    int gruppeId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFBenutzer[] EndBenutzerGetByBenutzerGruppenId(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerResetPasswordEnabled", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerResetPasswordEnabledResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerResetPasswordEnabledWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool BenutzerResetPasswordEnabled();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerResetPasswordEnabled", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerResetPasswordEnabledResponse")]
  IAsyncResult BeginBenutzerResetPasswordEnabled(AsyncCallback callback, object asyncState);

  bool EndBenutzerResetPasswordEnabled(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerResetPassword", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerResetPasswordResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerResetPasswordWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool BenutzerResetPassword(string email);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerResetPassword", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerResetPasswordResponse")]
  IAsyncResult BeginBenutzerResetPassword(string email, AsyncCallback callback, object asyncState);

  bool EndBenutzerResetPassword(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerSendPIN", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerSendPINResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerSendPINWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool BenutzerSendPIN(string email);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerSendPIN", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerSendPINResponse")]
  IAsyncResult BeginBenutzerSendPIN(string email, AsyncCallback callback, object asyncState);

  bool EndBenutzerSendPIN(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGetDeviceRegistration", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGetDeviceRegistrationResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGetDeviceRegistrationWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string BenutzerGetDeviceRegistration(string email, string PIN, string deviceName);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGetDeviceRegistration", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGetDeviceRegistrationResponse")]
  IAsyncResult BeginBenutzerGetDeviceRegistration(
    string email,
    string PIN,
    string deviceName,
    AsyncCallback callback,
    object asyncState);

  string EndBenutzerGetDeviceRegistration(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/GCalenderGetList", ReplyAction = "http://tempuri.org/IELISWCFService/GCalenderGetListResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/GCalenderGetListWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFGCalenderObj[] GCalenderGetList(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/GCalenderGetList", ReplyAction = "http://tempuri.org/IELISWCFService/GCalenderGetListResponse")]
  IAsyncResult BeginGCalenderGetList(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFGCalenderObj[] EndGCalenderGetList(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrName", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrNameResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrNameWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetFeuerwehrName();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrName", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrNameResponse")]
  IAsyncResult BeginInfoGetFeuerwehrName(AsyncCallback callback, object asyncState);

  string EndInfoGetFeuerwehrName(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresse", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetFeuerwehrAdresse();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresse", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseResponse")]
  IAsyncResult BeginInfoGetFeuerwehrAdresse(AsyncCallback callback, object asyncState);

  string EndInfoGetFeuerwehrAdresse(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdressePLZGemeinde", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdressePLZGemeindeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdressePLZGemeindeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetFeuerwehrAdressePLZGemeinde();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdressePLZGemeinde", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdressePLZGemeindeResponse")]
  IAsyncResult BeginInfoGetFeuerwehrAdressePLZGemeinde(AsyncCallback callback, object asyncState);

  string EndInfoGetFeuerwehrAdressePLZGemeinde(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLatitude", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLatitudeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLatitudeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  double InfoGetFeuerwehrAdresseGPSLatitude();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLatitude", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLatitudeResponse")]
  IAsyncResult BeginInfoGetFeuerwehrAdresseGPSLatitude(AsyncCallback callback, object asyncState);

  double EndInfoGetFeuerwehrAdresseGPSLatitude(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLongitude", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLongitudeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLongitudeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  double InfoGetFeuerwehrAdresseGPSLongitude();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLongitude", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSLongitudeResponse")]
  IAsyncResult BeginInfoGetFeuerwehrAdresseGPSLongitude(AsyncCallback callback, object asyncState);

  double EndInfoGetFeuerwehrAdresseGPSLongitude(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSKoordinatenString", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSKoordinatenStringResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSKoordinatenStringWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetFeuerwehrAdresseGPSKoordinatenString();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSKoordinatenString", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetFeuerwehrAdresseGPSKoordinatenStringResponse")]
  IAsyncResult BeginInfoGetFeuerwehrAdresseGPSKoordinatenString(
    AsyncCallback callback,
    object asyncState);

  string EndInfoGetFeuerwehrAdresseGPSKoordinatenString(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetPLZ", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetPLZResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetPLZWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetPLZ();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetPLZ", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetPLZResponse")]
  IAsyncResult BeginInfoGetPLZ(AsyncCallback callback, object asyncState);

  string EndInfoGetPLZ(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahl", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahlResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahlWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetGemeindeKennzahl();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahl", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahlResponse")]
  IAsyncResult BeginInfoGetGemeindeKennzahl(AsyncCallback callback, object asyncState);

  string EndInfoGetGemeindeKennzahl(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahlRegion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahlRegionResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahlRegionWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetGemeindeKennzahlRegion();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahlRegion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGemeindeKennzahlRegionResponse")]
  IAsyncResult BeginInfoGetGemeindeKennzahlRegion(AsyncCallback callback, object asyncState);

  string EndInfoGetGemeindeKennzahlRegion(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetGemeinde", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGemeindeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetGemeindeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetGemeinde();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetGemeinde", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGemeindeResponse")]
  IAsyncResult BeginInfoGetGemeinde(AsyncCallback callback, object asyncState);

  string EndInfoGetGemeinde(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetBezirk", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetBezirkResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetBezirkWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetBezirk();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetBezirk", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetBezirkResponse")]
  IAsyncResult BeginInfoGetBezirk(AsyncCallback callback, object asyncState);

  string EndInfoGetBezirk(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetLand", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetLandResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetLandWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetLand();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetLand", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetLandResponse")]
  IAsyncResult BeginInfoGetLand(AsyncCallback callback, object asyncState);

  string EndInfoGetLand(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetWetter", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetWetterResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetWetterWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWetterObj InfoGetWetter();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetWetter", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetWetterResponse")]
  IAsyncResult BeginInfoGetWetter(AsyncCallback callback, object asyncState);

  WCFWetterObj EndInfoGetWetter(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetObjDBVersion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetObjDBVersionResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetObjDBVersionWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetObjDBVersion();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetObjDBVersion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetObjDBVersionResponse")]
  IAsyncResult BeginInfoGetObjDBVersion(AsyncCallback callback, object asyncState);

  string EndInfoGetObjDBVersion(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetSysDBVersion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetSysDBVersionResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetSysDBVersionWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetSysDBVersion();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetSysDBVersion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetSysDBVersionResponse")]
  IAsyncResult BeginInfoGetSysDBVersion(AsyncCallback callback, object asyncState);

  string EndInfoGetSysDBVersion(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetAPDBVersion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetAPDBVersionResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetAPDBVersionWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetAPDBVersion();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetAPDBVersion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetAPDBVersionResponse")]
  IAsyncResult BeginInfoGetAPDBVersion(AsyncCallback callback, object asyncState);

  string EndInfoGetAPDBVersion(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetWCFVersion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetWCFVersionResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetWCFVersionWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  double InfoGetWCFVersion();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetWCFVersion", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetWCFVersionResponse")]
  IAsyncResult BeginInfoGetWCFVersion(AsyncCallback callback, object asyncState);

  double EndInfoGetWCFVersion(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetWCFEinsatzOptionKonfig", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetWCFEinsatzOptionKonfigResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetWCFEinsatzOptionKonfigWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzOptionKonfig InfoGetWCFEinsatzOptionKonfig(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetWCFEinsatzOptionKonfig", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetWCFEinsatzOptionKonfigResponse")]
  IAsyncResult BeginInfoGetWCFEinsatzOptionKonfig(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzOptionKonfig EndInfoGetWCFEinsatzOptionKonfig(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetELISBenutzerverwaltungsSystem", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetELISBenutzerverwaltungsSystemResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetELISBenutzerverwaltungsSystemWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  ELISServiceConfigBenutzerVerwaltungsSystemTyp InfoGetELISBenutzerverwaltungsSystem(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetELISBenutzerverwaltungsSystem", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetELISBenutzerverwaltungsSystemResponse")]
  IAsyncResult BeginInfoGetELISBenutzerverwaltungsSystem(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  ELISServiceConfigBenutzerVerwaltungsSystemTyp EndInfoGetELISBenutzerverwaltungsSystem(
    IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetSystemBuildDate", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetSystemBuildDateResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetSystemBuildDateWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  DateTime InfoGetSystemBuildDate();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetSystemBuildDate", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetSystemBuildDateResponse")]
  IAsyncResult BeginInfoGetSystemBuildDate(AsyncCallback callback, object asyncState);

  DateTime EndInfoGetSystemBuildDate(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetELISSystemID", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetELISSystemIDResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetELISSystemIDWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetELISSystemID();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetELISSystemID", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetELISSystemIDResponse")]
  IAsyncResult BeginInfoGetELISSystemID(AsyncCallback callback, object asyncState);

  string EndInfoGetELISSystemID(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetELISPublicURL", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetELISPublicURLResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetELISPublicURLWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetELISPublicURL();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetELISPublicURL", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetELISPublicURLResponse")]
  IAsyncResult BeginInfoGetELISPublicURL(AsyncCallback callback, object asyncState);

  string EndInfoGetELISPublicURL(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetEinsatzZonenDetails", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetEinsatzZonenDetailsResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetEinsatzZonenDetailsWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzzonenInfo InfoGetEinsatzZonenDetails(string einsatzzonenId);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetEinsatzZonenDetails", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetEinsatzZonenDetailsResponse")]
  IAsyncResult BeginInfoGetEinsatzZonenDetails(
    string einsatzzonenId,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzzonenInfo EndInfoGetEinsatzZonenDetails(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetGMapLadezeit", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGMapLadezeitResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetGMapLadezeitWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int InfoGetGMapLadezeit();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetGMapLadezeit", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGMapLadezeitResponse")]
  IAsyncResult BeginInfoGetGMapLadezeit(AsyncCallback callback, object asyncState);

  int EndInfoGetGMapLadezeit(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetGAPIClientKey", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGAPIClientKeyResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetGAPIClientKeyWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetGAPIClientKey(ELISProgram program, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetGAPIClientKey", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGAPIClientKeyResponse")]
  IAsyncResult BeginInfoGetGAPIClientKey(
    ELISProgram program,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  string EndInfoGetGAPIClientKey(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/InfoGetGAPIServerKey", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGAPIServerKeyResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/InfoGetGAPIServerKeyWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string InfoGetGAPIServerKey(ELISProgram program, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/InfoGetGAPIServerKey", ReplyAction = "http://tempuri.org/IELISWCFService/InfoGetGAPIServerKeyResponse")]
  IAsyncResult BeginInfoGetGAPIServerKey(
    ELISProgram program,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  string EndInfoGetGAPIServerKey(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ProtocolWrite", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolWriteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ProtocolWriteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void ProtocolWrite(WCFJournalEntry je, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ProtocolWrite", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolWriteResponse")]
  IAsyncResult BeginProtocolWrite(
    WCFJournalEntry je,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndProtocolWrite(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ProtocolDeleteEntry", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolDeleteEntryResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ProtocolDeleteEntryWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool ProtocolDeleteEntry(WCFJournalEntry je, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ProtocolDeleteEntry", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolDeleteEntryResponse")]
  IAsyncResult BeginProtocolDeleteEntry(
    WCFJournalEntry je,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndProtocolDeleteEntry(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredCount", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int ProtocolGetFilteredCount(
    string artFilter,
    DateTime fromDate,
    DateTime toDate,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredCount", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredCountResponse")]
  IAsyncResult BeginProtocolGetFilteredCount(
    string artFilter,
    DateTime fromDate,
    DateTime toDate,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndProtocolGetFilteredCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredRange", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredRangeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredRangeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFJournalEntry[] ProtocolGetFilteredRange(
    int startRowIndex,
    int maximumRows,
    string artFilter,
    DateTime fromDate,
    DateTime toDate,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredRange", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolGetFilteredRangeResponse")]
  IAsyncResult BeginProtocolGetFilteredRange(
    int startRowIndex,
    int maximumRows,
    string artFilter,
    DateTime fromDate,
    DateTime toDate,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFJournalEntry[] EndProtocolGetFilteredRange(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ProtocolGetArtList", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolGetArtListResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ProtocolGetArtListWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] ProtocolGetArtList(DateTime fromDate, DateTime toDate, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ProtocolGetArtList", ReplyAction = "http://tempuri.org/IELISWCFService/ProtocolGetArtListResponse")]
  IAsyncResult BeginProtocolGetArtList(
    DateTime fromDate,
    DateTime toDate,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  string[] EndProtocolGetArtList(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/JournalFzInfoGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/JournalFzInfoGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/JournalFzInfoGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFJournalFzInfo[] JournalFzInfoGetAll(Guid TicketId);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/JournalFzInfoGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/JournalFzInfoGetAllResponse")]
  IAsyncResult BeginJournalFzInfoGetAll(Guid TicketId, AsyncCallback callback, object asyncState);

  WCFJournalFzInfo[] EndJournalFzInfoGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/JournalFzInfoPersist", ReplyAction = "http://tempuri.org/IELISWCFService/JournalFzInfoPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/JournalFzInfoPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFJournalFzInfo JournalFzInfoPersist(WCFJournalFzInfo fzInfo, Guid TicketId);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/JournalFzInfoPersist", ReplyAction = "http://tempuri.org/IELISWCFService/JournalFzInfoPersistResponse")]
  IAsyncResult BeginJournalFzInfoPersist(
    WCFJournalFzInfo fzInfo,
    Guid TicketId,
    AsyncCallback callback,
    object asyncState);

  WCFJournalFzInfo EndJournalFzInfoPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/JournalFzInfoDelete", ReplyAction = "http://tempuri.org/IELISWCFService/JournalFzInfoDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/JournalFzInfoDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool JournalFzInfoDelete(WCFJournalFzInfo fzInfo, Guid TicketId);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/JournalFzInfoDelete", ReplyAction = "http://tempuri.org/IELISWCFService/JournalFzInfoDeleteResponse")]
  IAsyncResult BeginJournalFzInfoDelete(
    WCFJournalFzInfo fzInfo,
    Guid TicketId,
    AsyncCallback callback,
    object asyncState);

  bool EndJournalFzInfoDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SMSSendNEW", ReplyAction = "http://tempuri.org/IELISWCFService/SMSSendNEWResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SMSSendNEWWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool SMSSendNEW(string Message, string TelNumber, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SMSSendNEW", ReplyAction = "http://tempuri.org/IELISWCFService/SMSSendNEWResponse")]
  IAsyncResult BeginSMSSendNEW(
    string Message,
    string TelNumber,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndSMSSendNEW(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SMSSendWithSender", ReplyAction = "http://tempuri.org/IELISWCFService/SMSSendWithSenderResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SMSSendWithSenderWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool SMSSendWithSender(
    string Message,
    string TelNumber,
    string fromTel,
    string fromName,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SMSSendWithSender", ReplyAction = "http://tempuri.org/IELISWCFService/SMSSendWithSenderResponse")]
  IAsyncResult BeginSMSSendWithSender(
    string Message,
    string TelNumber,
    string fromTel,
    string fromName,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndSMSSendWithSender(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EmailSend", ReplyAction = "http://tempuri.org/IELISWCFService/EmailSendResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EmailSendWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EmailSend(string Betreff, string Message, string to, string toName, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EmailSend", ReplyAction = "http://tempuri.org/IELISWCFService/EmailSendResponse")]
  IAsyncResult BeginEmailSend(
    string Betreff,
    string Message,
    string to,
    string toName,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEmailSend(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EmailSend2", ReplyAction = "http://tempuri.org/IELISWCFService/EmailSend2Response")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EmailSend2WCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EmailSend2(
    string Betreff,
    string Message,
    string to,
    string toName,
    string from,
    string fromName,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EmailSend2", ReplyAction = "http://tempuri.org/IELISWCFService/EmailSend2Response")]
  IAsyncResult BeginEmailSend2(
    string Betreff,
    string Message,
    string to,
    string toName,
    string from,
    string fromName,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEmailSend2(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EmailSendAttachments", ReplyAction = "http://tempuri.org/IELISWCFService/EmailSendAttachmentsResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EmailSendAttachmentsWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EmailSendAttachments(
    string Betreff,
    string Message,
    string[] toEMail,
    string[] toName,
    string from,
    string fromName,
    string[] attList,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EmailSendAttachments", ReplyAction = "http://tempuri.org/IELISWCFService/EmailSendAttachmentsResponse")]
  IAsyncResult BeginEmailSendAttachments(
    string Betreff,
    string Message,
    string[] toEMail,
    string[] toName,
    string from,
    string fromName,
    string[] attList,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEmailSendAttachments(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ConnectedWAS", ReplyAction = "http://tempuri.org/IELISWCFService/ConnectedWASResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ConnectedWASWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool ConnectedWAS();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ConnectedWAS", ReplyAction = "http://tempuri.org/IELISWCFService/ConnectedWASResponse")]
  IAsyncResult BeginConnectedWAS(AsyncCallback callback, object asyncState);

  bool EndConnectedWAS(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ConnectedELIS", ReplyAction = "http://tempuri.org/IELISWCFService/ConnectedELISResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ConnectedELISWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool ConnectedELIS();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ConnectedELIS", ReplyAction = "http://tempuri.org/IELISWCFService/ConnectedELISResponse")]
  IAsyncResult BeginConnectedELIS(AsyncCallback callback, object asyncState);

  bool EndConnectedELIS(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzDataGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzDataGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzDataGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzdaten[] EinsatzDataGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzDataGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzDataGetAllResponse")]
  IAsyncResult BeginEinsatzDataGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFEinsatzdaten[] EndEinsatzDataGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int EinsatzHistoryDataGetCount(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCountResponse")]
  IAsyncResult BeginEinsatzHistoryDataGetCount(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndEinsatzHistoryDataGetCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCountTimeSpan", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCountTimeSpanResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCountTimeSpanWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int EinsatzHistoryDataGetCountTimeSpan(DateTime begin, DateTime end, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCountTimeSpan", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetCountTimeSpanResponse")]
  IAsyncResult BeginEinsatzHistoryDataGetCountTimeSpan(
    DateTime begin,
    DateTime end,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndEinsatzHistoryDataGetCountTimeSpan(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRangeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRangeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzdaten[] EinsatzHistoryDataGetRange(int startRowIndex, int maximumRows, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRangeResponse")]
  IAsyncResult BeginEinsatzHistoryDataGetRange(
    int startRowIndex,
    int maximumRows,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzdaten[] EndEinsatzHistoryDataGetRange(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRangeTimeSpan", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRangeTimeSpanResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRangeTimeSpanWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzdaten[] EinsatzHistoryDataGetRangeTimeSpan(
    DateTime begin,
    DateTime end,
    int startRowIndex,
    int maximumRows,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRangeTimeSpan", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetRangeTimeSpanResponse")]
  IAsyncResult BeginEinsatzHistoryDataGetRangeTimeSpan(
    DateTime begin,
    DateTime end,
    int startRowIndex,
    int maximumRows,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzdaten[] EndEinsatzHistoryDataGetRangeTimeSpan(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetbyId", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetbyIdResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetbyIdWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzdaten EinsatzHistoryDataGetbyId(int einsatzId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetbyId", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataGetbyIdResponse")]
  IAsyncResult BeginEinsatzHistoryDataGetbyId(
    int einsatzId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzdaten EndEinsatzHistoryDataGetbyId(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataDeletebyId", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataDeletebyIdResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataDeletebyIdWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EinsatzHistoryDataDeletebyId(int einsatzId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataDeletebyId", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataDeletebyIdResponse")]
  IAsyncResult BeginEinsatzHistoryDataDeletebyId(
    int einsatzId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEinsatzHistoryDataDeletebyId(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzDataPersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzDataPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzDataPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EinsatzDataPersist(WCFEinsatzdaten ed, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzDataPersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzDataPersistResponse")]
  IAsyncResult BeginEinsatzDataPersist(
    WCFEinsatzdaten ed,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEinsatzDataPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataPersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EinsatzHistoryDataPersist(WCFEinsatzdaten ed, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataPersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzHistoryDataPersistResponse")]
  IAsyncResult BeginEinsatzHistoryDataPersist(
    WCFEinsatzdaten ed,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEinsatzHistoryDataPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzGetFahrzeuge", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzGetFahrzeugeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzGetFahrzeugeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatz_Fahrzeug[] EinsatzGetFahrzeuge(int einsatzId, bool historyEinsatz, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzGetFahrzeuge", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzGetFahrzeugeResponse")]
  IAsyncResult BeginEinsatzGetFahrzeuge(
    int einsatzId,
    bool historyEinsatz,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatz_Fahrzeug[] EndEinsatzGetFahrzeuge(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool FremdSystemDelete(WCFFremdSystem fs, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemDeleteResponse")]
  IAsyncResult BeginFremdSystemDelete(
    WCFFremdSystem fs,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndFremdSystemDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemDeleteSyncData", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemDeleteSyncDataResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemDeleteSyncDataWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool FremdSystemDeleteSyncData(WCFFremdSystem fs, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemDeleteSyncData", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemDeleteSyncDataResponse")]
  IAsyncResult BeginFremdSystemDeleteSyncData(
    WCFFremdSystem fs,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndFremdSystemDeleteSyncData(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EigeneFeuerwehrSet", ReplyAction = "http://tempuri.org/IELISWCFService/EigeneFeuerwehrSetResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EigeneFeuerwehrSetWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EigeneFeuerwehrSet(WCFFeuerwehr fwId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EigeneFeuerwehrSet", ReplyAction = "http://tempuri.org/IELISWCFService/EigeneFeuerwehrSetResponse")]
  IAsyncResult BeginEigeneFeuerwehrSet(
    WCFFeuerwehr fwId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEigeneFeuerwehrSet(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KontaktObjDelete", ReplyAction = "http://tempuri.org/IELISWCFService/KontaktObjDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KontaktObjDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool KontaktObjDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KontaktObjDelete", ReplyAction = "http://tempuri.org/IELISWCFService/KontaktObjDeleteResponse")]
  IAsyncResult BeginKontaktObjDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndKontaktObjDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KontaktGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/KontaktGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KontaktGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFKontakt[] KontaktGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KontaktGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/KontaktGetAllResponse")]
  IAsyncResult BeginKontaktGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFKontakt[] EndKontaktGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FeuerwehrenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrenGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FeuerwehrenGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFeuerwehr[] FeuerwehrenGetAll(Guid TicketID, bool withDisabled);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FeuerwehrenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrenGetAllResponse")]
  IAsyncResult BeginFeuerwehrenGetAll(
    Guid TicketID,
    bool withDisabled,
    AsyncCallback callback,
    object asyncState);

  WCFFeuerwehr[] EndFeuerwehrenGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FeuerwehrGetEigene", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrGetEigeneResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FeuerwehrGetEigeneWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFeuerwehr FeuerwehrGetEigene(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FeuerwehrGetEigene", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrGetEigeneResponse")]
  IAsyncResult BeginFeuerwehrGetEigene(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFFeuerwehr EndFeuerwehrGetEigene(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FeuerwehrPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FeuerwehrPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFeuerwehr FeuerwehrPersist(WCFFeuerwehr fw, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FeuerwehrPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrPersistResponse")]
  IAsyncResult BeginFeuerwehrPersist(
    WCFFeuerwehr fw,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFeuerwehr EndFeuerwehrPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FeuerwehrDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FeuerwehrDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] FeuerwehrDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FeuerwehrDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrDeleteResponse")]
  IAsyncResult BeginFeuerwehrDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  string[] EndFeuerwehrDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFahrzeug[] FahrzeugeGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllResponse")]
  IAsyncResult BeginFahrzeugeGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFFahrzeug[] EndFahrzeugeGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetByFeuerwehr", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetByFeuerwehrResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetByFeuerwehrWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFahrzeug[] FahrzeugeGetByFeuerwehr(int fwId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetByFeuerwehr", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetByFeuerwehrResponse")]
  IAsyncResult BeginFahrzeugeGetByFeuerwehr(
    int fwId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFahrzeug[] EndFahrzeugeGetByFeuerwehr(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetByEigenerFeuerwehr", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetByEigenerFeuerwehrResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetByEigenerFeuerwehrWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFahrzeug[] FahrzeugeGetByEigenerFeuerwehr(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetByEigenerFeuerwehr", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetByEigenerFeuerwehrResponse")]
  IAsyncResult BeginFahrzeugeGetByEigenerFeuerwehr(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFahrzeug[] EndFahrzeugeGetByEigenerFeuerwehr(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllVerfuegbar", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllVerfuegbarResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllVerfuegbarWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFahrzeug[] FahrzeugeGetAllVerfuegbar(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllVerfuegbar", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllVerfuegbarResponse")]
  IAsyncResult BeginFahrzeugeGetAllVerfuegbar(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFahrzeug[] EndFahrzeugeGetAllVerfuegbar(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllDisponierbar", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllDisponierbarResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllDisponierbarWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFahrzeug[] FahrzeugeGetAllDisponierbar(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllDisponierbar", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugeGetAllDisponierbarResponse")]
  IAsyncResult BeginFahrzeugeGetAllDisponierbar(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFahrzeug[] EndFahrzeugeGetAllDisponierbar(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFahrzeug FahrzeugPersist(WCFFahrzeug fz, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugPersistResponse")]
  IAsyncResult BeginFahrzeugPersist(
    WCFFahrzeug fz,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFahrzeug EndFahrzeugPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool FahrzeugDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugDeleteResponse")]
  IAsyncResult BeginFahrzeugDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndFahrzeugDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugChangeImDienst", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugChangeImDienstResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugChangeImDienstWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFahrzeug FahrzeugChangeImDienst(WCFFahrzeug fz, bool imDienst, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugChangeImDienst", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugChangeImDienstResponse")]
  IAsyncResult BeginFahrzeugChangeImDienst(
    WCFFahrzeug fz,
    bool imDienst,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFahrzeug EndFahrzeugChangeImDienst(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FahrzeugSetStatusInfo", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugSetStatusInfoResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FahrzeugSetStatusInfoWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFahrzeug FahrzeugSetStatusInfo(
    string statusInfo,
    string logKategorie,
    WCFFahrzeug fz,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FahrzeugSetStatusInfo", ReplyAction = "http://tempuri.org/IELISWCFService/FahrzeugSetStatusInfoResponse")]
  IAsyncResult BeginFahrzeugSetStatusInfo(
    string statusInfo,
    string logKategorie,
    WCFFahrzeug fz,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFahrzeug EndFahrzeugSetStatusInfo(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanKategorieGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanKategorieGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanKategorieGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAlarmplanKategorie[] AlarmplanKategorieGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanKategorieGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanKategorieGetAllResponse")]
  IAsyncResult BeginAlarmplanKategorieGetAll(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAlarmplanKategorie[] EndAlarmplanKategorieGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanKategoriePersist", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanKategoriePersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanKategoriePersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAlarmplanKategorie AlarmplanKategoriePersist(WCFAlarmplanKategorie ap, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanKategoriePersist", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanKategoriePersistResponse")]
  IAsyncResult BeginAlarmplanKategoriePersist(
    WCFAlarmplanKategorie ap,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAlarmplanKategorie EndAlarmplanKategoriePersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanKategorieDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanKategorieDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanKategorieDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool AlarmplanKategorieDelete(WCFAlarmplanKategorie apKat, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanKategorieDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanKategorieDeleteResponse")]
  IAsyncResult BeginAlarmplanKategorieDelete(
    WCFAlarmplanKategorie apKat,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndAlarmplanKategorieDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAlarmplan[] AlarmplanGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanGetAllResponse")]
  IAsyncResult BeginAlarmplanGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFAlarmplan[] EndAlarmplanGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanPersist", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAlarmplan AlarmplanPersist(WCFAlarmplan ap, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanPersist", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanPersistResponse")]
  IAsyncResult BeginAlarmplanPersist(
    WCFAlarmplan ap,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAlarmplan EndAlarmplanPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool AlarmplanDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanDeleteResponse")]
  IAsyncResult BeginAlarmplanDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndAlarmplanDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanGeneratorStart", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanGeneratorStartResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanGeneratorStartWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] AlarmplanGeneratorStart(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanGeneratorStart", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanGeneratorStartResponse")]
  IAsyncResult BeginAlarmplanGeneratorStart(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  string[] EndAlarmplanGeneratorStart(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanGetCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanGetCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int AlarmplanGetCount(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanGetCountResponse")]
  IAsyncResult BeginAlarmplanGetCount(Guid TicketID, AsyncCallback callback, object asyncState);

  int EndAlarmplanGetCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanGetRangeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanGetRangeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAlarmplan[] AlarmplanGetRange(int start, int count, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanGetRangeResponse")]
  IAsyncResult BeginAlarmplanGetRange(
    int start,
    int count,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAlarmplan[] EndAlarmplanGetRange(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanObjGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanObjGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanObjGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAlarmplanObj[] AlarmplanObjGetAll(int apId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanObjGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanObjGetAllResponse")]
  IAsyncResult BeginAlarmplanObjGetAll(
    int apId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAlarmplanObj[] EndAlarmplanObjGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanObjPersist", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanObjPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanObjPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAlarmplanObj AlarmplanObjPersist(WCFAlarmplanObj apo, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanObjPersist", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanObjPersistResponse")]
  IAsyncResult BeginAlarmplanObjPersist(
    WCFAlarmplanObj apo,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAlarmplanObj EndAlarmplanObjPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AlarmplanObjDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanObjDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AlarmplanObjDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool AlarmplanObjDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AlarmplanObjDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AlarmplanObjDeleteResponse")]
  IAsyncResult BeginAlarmplanObjDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndAlarmplanObjDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTypObjGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzTyp[] EinsatzTypObjGetAll(bool withDeativated, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTypObjGetAllResponse")]
  IAsyncResult BeginEinsatzTypObjGetAll(
    bool withDeativated,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzTyp[] EndEinsatzTypObjGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjPersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTypObjPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFEinsatzTyp EinsatzTypObjPersist(WCFEinsatzTyp et, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjPersist", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTypObjPersistResponse")]
  IAsyncResult BeginEinsatzTypObjPersist(
    WCFEinsatzTyp et,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFEinsatzTyp EndEinsatzTypObjPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjDelete", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTypObjDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool EinsatzTypObjDelete(WCFEinsatzTyp et, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EinsatzTypObjDelete", ReplyAction = "http://tempuri.org/IELISWCFService/EinsatzTypObjDeleteResponse")]
  IAsyncResult BeginEinsatzTypObjDelete(
    WCFEinsatzTyp et,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndEinsatzTypObjDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAusrueckeOrdnung[] AusrueckeOrdnungGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetAllResponse")]
  IAsyncResult BeginAusrueckeOrdnungGetAll(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAusrueckeOrdnung[] EndAusrueckeOrdnungGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetByEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetByEinsatzTypResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetByEinsatzTypWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAusrueckeOrdnung[] AusrueckeOrdnungGetByEinsatzTyp(string typName, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetByEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungGetByEinsatzTypResponse")]
  IAsyncResult BeginAusrueckeOrdnungGetByEinsatzTyp(
    string typName,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAusrueckeOrdnung[] EndAusrueckeOrdnungGetByEinsatzTyp(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungPersist", ReplyAction = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAusrueckeOrdnung AusrueckeOrdnungPersist(WCFAusrueckeOrdnung ao, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungPersist", ReplyAction = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungPersistResponse")]
  IAsyncResult BeginAusrueckeOrdnungPersist(
    WCFAusrueckeOrdnung ao,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFAusrueckeOrdnung EndAusrueckeOrdnungPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool AusrueckeOrdnungDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungDelete", ReplyAction = "http://tempuri.org/IELISWCFService/AusrueckeOrdnungDeleteResponse")]
  IAsyncResult BeginAusrueckeOrdnungDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndAusrueckeOrdnungDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SondergeraeteGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/SondergeraeteGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SondergeraeteGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFSondergeraet[] SondergeraeteGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SondergeraeteGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/SondergeraeteGetAllResponse")]
  IAsyncResult BeginSondergeraeteGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFSondergeraet[] EndSondergeraeteGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SondergeraeteGetByFeuerwehr", ReplyAction = "http://tempuri.org/IELISWCFService/SondergeraeteGetByFeuerwehrResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SondergeraeteGetByFeuerwehrWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFSondergeraet[] SondergeraeteGetByFeuerwehr(int fwId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SondergeraeteGetByFeuerwehr", ReplyAction = "http://tempuri.org/IELISWCFService/SondergeraeteGetByFeuerwehrResponse")]
  IAsyncResult BeginSondergeraeteGetByFeuerwehr(
    int fwId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFSondergeraet[] EndSondergeraeteGetByFeuerwehr(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SondergeraetPersist", ReplyAction = "http://tempuri.org/IELISWCFService/SondergeraetPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SondergeraetPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFSondergeraet SondergeraetPersist(WCFSondergeraet wsg, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SondergeraetPersist", ReplyAction = "http://tempuri.org/IELISWCFService/SondergeraetPersistResponse")]
  IAsyncResult BeginSondergeraetPersist(
    WCFSondergeraet wsg,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFSondergeraet EndSondergeraetPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SondergeraetDelete", ReplyAction = "http://tempuri.org/IELISWCFService/SondergeraetDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SondergeraetDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool SondergeraetDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SondergeraetDelete", ReplyAction = "http://tempuri.org/IELISWCFService/SondergeraetDeleteResponse")]
  IAsyncResult BeginSondergeraetDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndSondergeraetDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeArtenGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtenGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFremdhilfeArt[] FremdhilfeArtenGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtenGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeArtenGetAllResponse")]
  IAsyncResult BeginFremdhilfeArtenGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFFremdhilfeArt[] EndFremdhilfeArtenGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeArtPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFremdhilfeArt FremdhilfeArtPersist(WCFFremdhilfeArt fha, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeArtPersistResponse")]
  IAsyncResult BeginFremdhilfeArtPersist(
    WCFFremdhilfeArt fha,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFremdhilfeArt EndFremdhilfeArtPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeArtDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool FremdhilfeArtDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdhilfeArtDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeArtDeleteResponse")]
  IAsyncResult BeginFremdhilfeArtDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndFremdhilfeArtDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFremdhilfeLeister[] FremdhilfeLeisterGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetAllResponse")]
  IAsyncResult BeginFremdhilfeLeisterGetAll(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFremdhilfeLeister[] EndFremdhilfeLeisterGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetByArt", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetByArtResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetByArtWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFremdhilfeLeister[] FremdhilfeLeisterGetByArt(int artId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetByArt", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterGetByArtResponse")]
  IAsyncResult BeginFremdhilfeLeisterGetByArt(
    int artId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFremdhilfeLeister[] EndFremdhilfeLeisterGetByArt(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFremdhilfeLeister FremdhilfeLeisterPersist(WCFFremdhilfeLeister wfhl, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterPersistResponse")]
  IAsyncResult BeginFremdhilfeLeisterPersist(
    WCFFremdhilfeLeister wfhl,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFFremdhilfeLeister EndFremdhilfeLeisterPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool FremdhilfeLeisterDelete(WCFFremdhilfeLeister wfhl, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterDelete", ReplyAction = "http://tempuri.org/IELISWCFService/FremdhilfeLeisterDeleteResponse")]
  IAsyncResult BeginFremdhilfeLeisterDelete(
    WCFFremdhilfeLeister wfhl,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndFremdhilfeLeisterDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CreateTicket", ReplyAction = "http://tempuri.org/IELISWCFService/CreateTicketResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CreateTicketWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFTicket CreateTicket(string userName, string password);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CreateTicket", ReplyAction = "http://tempuri.org/IELISWCFService/CreateTicketResponse")]
  IAsyncResult BeginCreateTicket(
    string userName,
    string password,
    AsyncCallback callback,
    object asyncState);

  WCFTicket EndCreateTicket(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CheckTicket", ReplyAction = "http://tempuri.org/IELISWCFService/CheckTicketResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CheckTicketWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFTicket CheckTicket(Guid queryTicketID, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CheckTicket", ReplyAction = "http://tempuri.org/IELISWCFService/CheckTicketResponse")]
  IAsyncResult BeginCheckTicket(
    Guid queryTicketID,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFTicket EndCheckTicket(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CloseTicket", ReplyAction = "http://tempuri.org/IELISWCFService/CloseTicketResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CloseTicketWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool CloseTicket(Guid queryTicketID, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CloseTicket", ReplyAction = "http://tempuri.org/IELISWCFService/CloseTicketResponse")]
  IAsyncResult BeginCloseTicket(
    Guid queryTicketID,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndCloseTicket(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/LogELISProgramUse", ReplyAction = "http://tempuri.org/IELISWCFService/LogELISProgramUseResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/LogELISProgramUseWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool LogELISProgramUse(ELISProgram program, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/LogELISProgramUse", ReplyAction = "http://tempuri.org/IELISWCFService/LogELISProgramUseResponse")]
  IAsyncResult BeginLogELISProgramUse(
    ELISProgram program,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndLogELISProgramUse(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CheckELISClientVersionValid", ReplyAction = "http://tempuri.org/IELISWCFService/CheckELISClientVersionValidResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CheckELISClientVersionValidWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool CheckELISClientVersionValid(ELISProgram program, double clientVersion);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CheckELISClientVersionValid", ReplyAction = "http://tempuri.org/IELISWCFService/CheckELISClientVersionValidResponse")]
  IAsyncResult BeginCheckELISClientVersionValid(
    ELISProgram program,
    double clientVersion,
    AsyncCallback callback,
    object asyncState);

  bool EndCheckELISClientVersionValid(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/UserGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/UserGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/UserGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFBenutzer[] UserGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/UserGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/UserGetAllResponse")]
  IAsyncResult BeginUserGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFBenutzer[] EndUserGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/UserGetByLoginAndPw", ReplyAction = "http://tempuri.org/IELISWCFService/UserGetByLoginAndPwResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/UserGetByLoginAndPwWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFBenutzer UserGetByLoginAndPw(Guid TicketID, string login, string password);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/UserGetByLoginAndPw", ReplyAction = "http://tempuri.org/IELISWCFService/UserGetByLoginAndPwResponse")]
  IAsyncResult BeginUserGetByLoginAndPw(
    Guid TicketID,
    string login,
    string password,
    AsyncCallback callback,
    object asyncState);

  WCFBenutzer EndUserGetByLoginAndPw(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/UserGetActive", ReplyAction = "http://tempuri.org/IELISWCFService/UserGetActiveResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/UserGetActiveWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFBenutzer[] UserGetActive(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/UserGetActive", ReplyAction = "http://tempuri.org/IELISWCFService/UserGetActiveResponse")]
  IAsyncResult BeginUserGetActive(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFBenutzer[] EndUserGetActive(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/UserPersist", ReplyAction = "http://tempuri.org/IELISWCFService/UserPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/UserPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool UserPersist(WCFBenutzer benutzer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/UserPersist", ReplyAction = "http://tempuri.org/IELISWCFService/UserPersistResponse")]
  IAsyncResult BeginUserPersist(
    WCFBenutzer benutzer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndUserPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/UserDelete", ReplyAction = "http://tempuri.org/IELISWCFService/UserDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/UserDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool UserDelete(WCFBenutzer benutzer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/UserDelete", ReplyAction = "http://tempuri.org/IELISWCFService/UserDeleteResponse")]
  IAsyncResult BeginUserDelete(
    WCFBenutzer benutzer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndUserDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/UserSendEMailLogin", ReplyAction = "http://tempuri.org/IELISWCFService/UserSendEMailLoginResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/UserSendEMailLoginWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool UserSendEMailLogin(WCFBenutzer benutzer, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/UserSendEMailLogin", ReplyAction = "http://tempuri.org/IELISWCFService/UserSendEMailLoginResponse")]
  IAsyncResult BeginUserSendEMailLogin(
    WCFBenutzer benutzer,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndUserSendEMailLogin(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/EmailSMSGetActive", ReplyAction = "http://tempuri.org/IELISWCFService/EmailSMSGetActiveResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/EmailSMSGetActiveWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFBenutzer[] EmailSMSGetActive(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/EmailSMSGetActive", ReplyAction = "http://tempuri.org/IELISWCFService/EmailSMSGetActiveResponse")]
  IAsyncResult BeginEmailSMSGetActive(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFBenutzer[] EndEmailSMSGetActive(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGruppePersist", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppePersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGruppePersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool BenutzerGruppePersist(WCFBenutzerGruppe gruppe, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGruppePersist", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppePersistResponse")]
  IAsyncResult BeginBenutzerGruppePersist(
    WCFBenutzerGruppe gruppe,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndBenutzerGruppePersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeDelete", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppeDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool BenutzerGruppeDelete(int gruppeID, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeDelete", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppeDeleteResponse")]
  IAsyncResult BeginBenutzerGruppeDelete(
    int gruppeID,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndBenutzerGruppeDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeAddBenutzer", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppeAddBenutzerResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeAddBenutzerWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool BenutzerGruppeAddBenutzer(WCFBenutzer benutzer, int gruppeId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeAddBenutzer", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppeAddBenutzerResponse")]
  IAsyncResult BeginBenutzerGruppeAddBenutzer(
    WCFBenutzer benutzer,
    int gruppeId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndBenutzerGruppeAddBenutzer(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeRemoveBenutzer", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppeRemoveBenutzerResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeRemoveBenutzerWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool BenutzerGruppeRemoveBenutzer(WCFBenutzer benutzer, int gruppeId, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/BenutzerGruppeRemoveBenutzer", ReplyAction = "http://tempuri.org/IELISWCFService/BenutzerGruppeRemoveBenutzerResponse")]
  IAsyncResult BeginBenutzerGruppeRemoveBenutzer(
    WCFBenutzer benutzer,
    int gruppeId,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndBenutzerGruppeRemoveBenutzer(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AppLogLastGPS", ReplyAction = "http://tempuri.org/IELISWCFService/AppLogLastGPSResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AppLogLastGPSWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAppLog[] AppLogLastGPS(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AppLogLastGPS", ReplyAction = "http://tempuri.org/IELISWCFService/AppLogLastGPSResponse")]
  IAsyncResult BeginAppLogLastGPS(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFAppLog[] EndAppLogLastGPS(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/AppLogLastMonthGPS", ReplyAction = "http://tempuri.org/IELISWCFService/AppLogLastMonthGPSResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/AppLogLastMonthGPSWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFAppLog[] AppLogLastMonthGPS(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/AppLogLastMonthGPS", ReplyAction = "http://tempuri.org/IELISWCFService/AppLogLastMonthGPSResponse")]
  IAsyncResult BeginAppLogLastMonthGPS(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFAppLog[] EndAppLogLastMonthGPS(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SucheDaten", ReplyAction = "http://tempuri.org/IELISWCFService/SucheDatenResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SucheDatenWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFSuchergebnis[] SucheDaten(
    string query,
    WCFSuchergebnis.WCFSuchergebnisTyp abfrageFilter,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SucheDaten", ReplyAction = "http://tempuri.org/IELISWCFService/SucheDatenResponse")]
  IAsyncResult BeginSucheDaten(
    string query,
    WCFSuchergebnis.WCFSuchergebnisTyp abfrageFilter,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFSuchergebnis[] EndSucheDaten(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSave", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSaveResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSaveWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void WasserentnahmestelleSave(WCFWasserentnahmen wcfwe, bool updateChangeDate, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSave", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSaveResponse")]
  IAsyncResult BeginWasserentnahmestelleSave(
    WCFWasserentnahmen wcfwe,
    bool updateChangeDate,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndWasserentnahmestelleSave(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int WasserentnahmestellenGetCount(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetCountResponse")]
  IAsyncResult BeginWasserentnahmestellenGetCount(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndWasserentnahmestellenGetCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetRangeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetRangeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWasserentnahmen[] WasserentnahmestellenGetRange(
    int startRowIndex,
    int maximumRows,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGetRangeResponse")]
  IAsyncResult BeginWasserentnahmestellenGetRange(
    int startRowIndex,
    int maximumRows,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFWasserentnahmen[] EndWasserentnahmestellenGetRange(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSearch", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSearchResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSearchWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWasserentnahmen[] WasserentnahmestelleSearch(string keyword, int typ, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSearch", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleSearchResponse")]
  IAsyncResult BeginWasserentnahmestelleSearch(
    string keyword,
    int typ,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFWasserentnahmen[] EndWasserentnahmestelleSearch(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleGetByNumber", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleGetByNumberResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleGetByNumberWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWasserentnahmen WasserentnahmestelleGetByNumber(int number, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleGetByNumber", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleGetByNumberResponse")]
  IAsyncResult BeginWasserentnahmestelleGetByNumber(
    int number,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFWasserentnahmen EndWasserentnahmestelleGetByNumber(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleDelete", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void WasserentnahmestelleDelete(WCFWasserentnahmen wcfwe, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleDelete", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleDeleteResponse")]
  IAsyncResult BeginWasserentnahmestelleDelete(
    WCFWasserentnahmen wcfwe,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndWasserentnahmestelleDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleIconRefresh", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleIconRefreshResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleIconRefreshWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int WasserentnahmestelleIconRefresh(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestelleIconRefresh", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestelleIconRefreshResponse")]
  IAsyncResult BeginWasserentnahmestelleIconRefresh(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndWasserentnahmestelleIconRefresh(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWEBild[] WasserentnahmestellenBilderGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetAllResponse")]
  IAsyncResult BeginWasserentnahmestellenBilderGetAll(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFWEBild[] EndWasserentnahmestellenBilderGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetByWasserentnahmestelle", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetByWasserentnahmestelleResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetByWasserentnahmestelleWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWEBild[] WasserentnahmestellenBilderGetByWasserentnahmestelle(
    WCFWasserentnahmen we,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetByWasserentnahmestelle", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBilderGetByWasserentnahmestelleResponse")]
  IAsyncResult BeginWasserentnahmestellenBilderGetByWasserentnahmestelle(
    WCFWasserentnahmen we,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFWEBild[] EndWasserentnahmestellenBilderGetByWasserentnahmestelle(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildPersist", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWEBild WasserentnahmestellenBildPersist(WCFWEBild b, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildPersist", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildPersistResponse")]
  IAsyncResult BeginWasserentnahmestellenBildPersist(
    WCFWEBild b,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFWEBild EndWasserentnahmestellenBildPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildDelete", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool WasserentnahmestellenBildDelete(WCFWEBild b, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildDelete", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenBildDeleteResponse")]
  IAsyncResult BeginWasserentnahmestellenBildDelete(
    WCFWEBild b,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndWasserentnahmestellenBildDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGMLAttributUpdate", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGMLAttributUpdateResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGMLAttributUpdateWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool WasserentnahmestellenGMLAttributUpdate(
    WCFWasserentnahmen we,
    WCFWEGMLAttribut[] attribute,
    Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGMLAttributUpdate", ReplyAction = "http://tempuri.org/IELISWCFService/WasserentnahmestellenGMLAttributUpdateResponse")]
  IAsyncResult BeginWasserentnahmestellenGMLAttributUpdate(
    WCFWasserentnahmen we,
    WCFWEGMLAttribut[] attribute,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndWasserentnahmestellenGMLAttributUpdate(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ConfigNeuEinlesen", ReplyAction = "http://tempuri.org/IELISWCFService/ConfigNeuEinlesenResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ConfigNeuEinlesenWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool ConfigNeuEinlesen(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ConfigNeuEinlesen", ReplyAction = "http://tempuri.org/IELISWCFService/ConfigNeuEinlesenResponse")]
  IAsyncResult BeginConfigNeuEinlesen(Guid TicketID, AsyncCallback callback, object asyncState);

  bool EndConfigNeuEinlesen(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FeuerwehrhausKoordinatenSet", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrhausKoordinatenSetResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FeuerwehrhausKoordinatenSetWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool FeuerwehrhausKoordinatenSet(double GPSLatitude, double GPSLongitude, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FeuerwehrhausKoordinatenSet", ReplyAction = "http://tempuri.org/IELISWCFService/FeuerwehrhausKoordinatenSetResponse")]
  IAsyncResult BeginFeuerwehrhausKoordinatenSet(
    double GPSLatitude,
    double GPSLongitude,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndFeuerwehrhausKoordinatenSet(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/DokumenteBereinigen", ReplyAction = "http://tempuri.org/IELISWCFService/DokumenteBereinigenResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/DokumenteBereinigenWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int DokumenteBereinigen(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/DokumenteBereinigen", ReplyAction = "http://tempuri.org/IELISWCFService/DokumenteBereinigenResponse")]
  IAsyncResult BeginDokumenteBereinigen(Guid TicketID, AsyncCallback callback, object asyncState);

  int EndDokumenteBereinigen(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/DokumenteValidieren", ReplyAction = "http://tempuri.org/IELISWCFService/DokumenteValidierenResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/DokumenteValidierenWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] DokumenteValidieren(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/DokumenteValidieren", ReplyAction = "http://tempuri.org/IELISWCFService/DokumenteValidierenResponse")]
  IAsyncResult BeginDokumenteValidieren(Guid TicketID, AsyncCallback callback, object asyncState);

  string[] EndDokumenteValidieren(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/TimerServicesGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServicesGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/TimerServicesGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFTimerService[] TimerServicesGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/TimerServicesGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServicesGetAllResponse")]
  IAsyncResult BeginTimerServicesGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFTimerService[] EndTimerServicesGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/TimerServicesPersist", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServicesPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/TimerServicesPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool TimerServicesPersist(WCFTimerService ts, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/TimerServicesPersist", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServicesPersistResponse")]
  IAsyncResult BeginTimerServicesPersist(
    WCFTimerService ts,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndTimerServicesPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/TimerServicesDelete", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServicesDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/TimerServicesDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool TimerServicesDelete(WCFTimerService ts, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/TimerServicesDelete", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServicesDeleteResponse")]
  IAsyncResult BeginTimerServicesDelete(
    WCFTimerService ts,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndTimerServicesDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/TimerServicesExecuteJobManual", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServicesExecuteJobManualResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/TimerServicesExecuteJobManualWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool TimerServicesExecuteJobManual(WCFTimerService ts, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/TimerServicesExecuteJobManual", ReplyAction = "http://tempuri.org/IELISWCFService/TimerServicesExecuteJobManualResponse")]
  IAsyncResult BeginTimerServicesExecuteJobManual(
    WCFTimerService ts,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndTimerServicesExecuteJobManual(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientPersist", ReplyAction = "http://tempuri.org/IELISWCFService/WakeOnLanClientPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool WakeOnLanClientPersist(WCFWakeOnLanClientObj client, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientPersist", ReplyAction = "http://tempuri.org/IELISWCFService/WakeOnLanClientPersistResponse")]
  IAsyncResult BeginWakeOnLanClientPersist(
    WCFWakeOnLanClientObj client,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndWakeOnLanClientPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientDelete", ReplyAction = "http://tempuri.org/IELISWCFService/WakeOnLanClientDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool WakeOnLanClientDelete(WCFWakeOnLanClientObj client, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientDelete", ReplyAction = "http://tempuri.org/IELISWCFService/WakeOnLanClientDeleteResponse")]
  IAsyncResult BeginWakeOnLanClientDelete(
    WCFWakeOnLanClientObj client,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndWakeOnLanClientDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientWAKEClient", ReplyAction = "http://tempuri.org/IELISWCFService/WakeOnLanClientWAKEClientResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientWAKEClientWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool WakeOnLanClientWAKEClient(WCFWakeOnLanClientObj client, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientWAKEClient", ReplyAction = "http://tempuri.org/IELISWCFService/WakeOnLanClientWAKEClientResponse")]
  IAsyncResult BeginWakeOnLanClientWAKEClient(
    WCFWakeOnLanClientObj client,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndWakeOnLanClientWAKEClient(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/WakeOnLanClientGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWakeOnLanClientObj[] WakeOnLanClientGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/WakeOnLanClientGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/WakeOnLanClientGetAllResponse")]
  IAsyncResult BeginWakeOnLanClientGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFWakeOnLanClientObj[] EndWakeOnLanClientGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SirenenprogrammGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/SirenenprogrammGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SirenenprogrammGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFSirenenprogramm[] SirenenprogrammGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SirenenprogrammGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/SirenenprogrammGetAllResponse")]
  IAsyncResult BeginSirenenprogrammGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFSirenenprogramm[] EndSirenenprogrammGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/SirenenprogrammPersist", ReplyAction = "http://tempuri.org/IELISWCFService/SirenenprogrammPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/SirenenprogrammPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool SirenenprogrammPersist(WCFSirenenprogramm sp, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/SirenenprogrammPersist", ReplyAction = "http://tempuri.org/IELISWCFService/SirenenprogrammPersistResponse")]
  IAsyncResult BeginSirenenprogrammPersist(
    WCFSirenenprogramm sp,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndSirenenprogrammPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/DatenValidieren", ReplyAction = "http://tempuri.org/IELISWCFService/DatenValidierenResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/DatenValidierenWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] DatenValidieren(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/DatenValidieren", ReplyAction = "http://tempuri.org/IELISWCFService/DatenValidierenResponse")]
  IAsyncResult BeginDatenValidieren(Guid TicketID, AsyncCallback callback, object asyncState);

  string[] EndDatenValidieren(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/DatenReparieren", ReplyAction = "http://tempuri.org/IELISWCFService/DatenReparierenResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/DatenReparierenWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] DatenReparieren(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/DatenReparieren", ReplyAction = "http://tempuri.org/IELISWCFService/DatenReparierenResponse")]
  IAsyncResult BeginDatenReparieren(Guid TicketID, AsyncCallback callback, object asyncState);

  string[] EndDatenReparieren(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiBlattGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiBlattGetCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiBlattGetCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int KarteiBlattGetCount(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiBlattGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiBlattGetCountResponse")]
  IAsyncResult BeginKarteiBlattGetCount(Guid TicketID, AsyncCallback callback, object asyncState);

  int EndKarteiBlattGetCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ObjektKarteiGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiGetCountResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ObjektKarteiGetCountWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int ObjektKarteiGetCount(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ObjektKarteiGetCount", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiGetCountResponse")]
  IAsyncResult BeginObjektKarteiGetCount(Guid TicketID, AsyncCallback callback, object asyncState);

  int EndObjektKarteiGetCount(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiBlattGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiBlattGetRangeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiBlattGetRangeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFKarteiBlatt[] KarteiBlattGetRange(int startRowIndex, int maximumRows, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiBlattGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiBlattGetRangeResponse")]
  IAsyncResult BeginKarteiBlattGetRange(
    int startRowIndex,
    int maximumRows,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFKarteiBlatt[] EndKarteiBlattGetRange(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ObjektKarteiGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiGetRangeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ObjektKarteiGetRangeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFObjektKartei[] ObjektKarteiGetRange(int startRowIndex, int maximumRows, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ObjektKarteiGetRange", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiGetRangeResponse")]
  IAsyncResult BeginObjektKarteiGetRange(
    int startRowIndex,
    int maximumRows,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFObjektKartei[] EndObjektKarteiGetRange(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiBlattCheckAlternativName", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiBlattCheckAlternativNameResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiBlattCheckAlternativNameWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool KarteiBlattCheckAlternativName(string name, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiBlattCheckAlternativName", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiBlattCheckAlternativNameResponse")]
  IAsyncResult BeginKarteiBlattCheckAlternativName(
    string name,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndKarteiBlattCheckAlternativName(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiblattSave", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiblattSaveResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiblattSaveWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFKarteiBlatt KarteiblattSave(WCFKarteiBlatt wkb, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiblattSave", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiblattSaveResponse")]
  IAsyncResult BeginKarteiblattSave(
    WCFKarteiBlatt wkb,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFKarteiBlatt EndKarteiblattSave(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ObjektKarteiPersist", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ObjektKarteiPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFObjektKartei ObjektKarteiPersist(WCFObjektKartei wkb, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ObjektKarteiPersist", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiPersistResponse")]
  IAsyncResult BeginObjektKarteiPersist(
    WCFObjektKartei wkb,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFObjektKartei EndObjektKarteiPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiblattDelete", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiblattDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiblattDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void KarteiblattDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiblattDelete", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiblattDeleteResponse")]
  IAsyncResult BeginKarteiblattDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndKarteiblattDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ObjektKarteiDelete", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ObjektKarteiDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  void ObjektKarteiDelete(int id, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ObjektKarteiDelete", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiDeleteResponse")]
  IAsyncResult BeginObjektKarteiDelete(
    int id,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  void EndObjektKarteiDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiblattCopy", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiblattCopyResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiblattCopyWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool KarteiblattCopy(WCFKarteiBlatt wkb, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiblattCopy", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiblattCopyResponse")]
  IAsyncResult BeginKarteiblattCopy(
    WCFKarteiBlatt wkb,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndKarteiblattCopy(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ObjektKarteiCopy", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiCopyResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ObjektKarteiCopyWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool ObjektKarteiCopy(WCFObjektKartei wok, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ObjektKarteiCopy", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKarteiCopyResponse")]
  IAsyncResult BeginObjektKarteiCopy(
    WCFObjektKartei wok,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndObjektKarteiCopy(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiDokumentPersist", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiDokumentPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  int KarteiDokumentPersist(WCFKarteiDokument kd, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiDokumentPersist", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentPersistResponse")]
  IAsyncResult BeginKarteiDokumentPersist(
    WCFKarteiDokument kd,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  int EndKarteiDokumentPersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiDokumentDelete", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiDokumentDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool KarteiDokumentDelete(WCFKarteiDokument kd, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiDokumentDelete", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentDeleteResponse")]
  IAsyncResult BeginKarteiDokumentDelete(
    WCFKarteiDokument kd,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndKarteiDokumentDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiDokumentAddEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentAddEinsatzTypResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiDokumentAddEinsatzTypWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool KarteiDokumentAddEinsatzTyp(WCFKarteiDokument dok, string et, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiDokumentAddEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentAddEinsatzTypResponse")]
  IAsyncResult BeginKarteiDokumentAddEinsatzTyp(
    WCFKarteiDokument dok,
    string et,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndKarteiDokumentAddEinsatzTyp(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiDokumentRemoveEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentRemoveEinsatzTypResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiDokumentRemoveEinsatzTypWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool KarteiDokumentRemoveEinsatzTyp(WCFKarteiDokument dok, string et, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiDokumentRemoveEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentRemoveEinsatzTypResponse")]
  IAsyncResult BeginKarteiDokumentRemoveEinsatzTyp(
    WCFKarteiDokument dok,
    string et,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndKarteiDokumentRemoveEinsatzTyp(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/KarteiDokumentGetEinsatzTypen", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentGetEinsatzTypenResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/KarteiDokumentGetEinsatzTypenWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  string[] KarteiDokumentGetEinsatzTypen(WCFKarteiDokument dok, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/KarteiDokumentGetEinsatzTypen", ReplyAction = "http://tempuri.org/IELISWCFService/KarteiDokumentGetEinsatzTypenResponse")]
  IAsyncResult BeginKarteiDokumentGetEinsatzTypen(
    WCFKarteiDokument dok,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  string[] EndKarteiDokumentGetEinsatzTypen(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ObjektKategorieGet", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKategorieGetResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ObjektKategorieGetWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFObjektKategorie[] ObjektKategorieGet();

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ObjektKategorieGet", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKategorieGetResponse")]
  IAsyncResult BeginObjektKategorieGet(AsyncCallback callback, object asyncState);

  WCFObjektKategorie[] EndObjektKategorieGet(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ObjektKategoriePersist", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKategoriePersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ObjektKategoriePersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFObjektKategorie ObjektKategoriePersist(WCFObjektKategorie ok, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ObjektKategoriePersist", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKategoriePersistResponse")]
  IAsyncResult BeginObjektKategoriePersist(
    WCFObjektKategorie ok,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFObjektKategorie EndObjektKategoriePersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/ObjektKategorieDelete", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKategorieDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/ObjektKategorieDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool ObjektKategorieDelete(WCFObjektKategorie ok, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/ObjektKategorieDelete", ReplyAction = "http://tempuri.org/IELISWCFService/ObjektKategorieDeleteResponse")]
  IAsyncResult BeginObjektKategorieDelete(
    WCFObjektKategorie ok,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndObjektKategorieDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CheckListeGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListeGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CheckListeGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFCheckliste[] CheckListeGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CheckListeGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListeGetAllResponse")]
  IAsyncResult BeginCheckListeGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFCheckliste[] EndCheckListeGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CheckListePersist", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListePersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CheckListePersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFCheckliste CheckListePersist(WCFCheckliste ch, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CheckListePersist", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListePersistResponse")]
  IAsyncResult BeginCheckListePersist(
    WCFCheckliste ch,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFCheckliste EndCheckListePersist(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CheckListeDelete", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListeDeleteResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CheckListeDeleteWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool CheckListeDelete(WCFCheckliste ch, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CheckListeDelete", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListeDeleteResponse")]
  IAsyncResult BeginCheckListeDelete(
    WCFCheckliste ch,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndCheckListeDelete(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CheckListeAddEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListeAddEinsatzTypResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CheckListeAddEinsatzTypWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool CheckListeAddEinsatzTyp(WCFCheckliste ch, string et, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CheckListeAddEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListeAddEinsatzTypResponse")]
  IAsyncResult BeginCheckListeAddEinsatzTyp(
    WCFCheckliste ch,
    string et,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndCheckListeAddEinsatzTyp(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/CheckListeRemoveEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListeRemoveEinsatzTypResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/CheckListeRemoveEinsatzTypWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool CheckListeRemoveEinsatzTyp(WCFCheckliste ch, string et, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/CheckListeRemoveEinsatzTyp", ReplyAction = "http://tempuri.org/IELISWCFService/CheckListeRemoveEinsatzTypResponse")]
  IAsyncResult BeginCheckListeRemoveEinsatzTyp(
    WCFCheckliste ch,
    string et,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndCheckListeRemoveEinsatzTyp(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiByEinsatz", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiByEinsatzResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiByEinsatzWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  Guid FremdSystemGetEinsatzkarteiByEinsatz(WCFEinsatzdaten ed, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiByEinsatz", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiByEinsatzResponse")]
  IAsyncResult BeginFremdSystemGetEinsatzkarteiByEinsatz(
    WCFEinsatzdaten ed,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  Guid EndFremdSystemGetEinsatzkarteiByEinsatz(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiListe", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiListeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiListeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  Dictionary<Guid, DateTime> FremdSystemGetEinsatzkarteiListe(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiListe", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetEinsatzkarteiListeResponse")]
  IAsyncResult BeginFremdSystemGetEinsatzkarteiListe(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  Dictionary<Guid, DateTime> EndFremdSystemGetEinsatzkarteiListe(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiListe", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiListeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiListeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  Dictionary<Guid, DateTime> FremdSystemGetObjektKarteiListe(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiListe", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiListeResponse")]
  IAsyncResult BeginFremdSystemGetObjektKarteiListe(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  Dictionary<Guid, DateTime> EndFremdSystemGetObjektKarteiListe(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmenListe", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmenListeResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmenListeWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  Dictionary<Guid, DateTime> FremdSystemGetWasserEntnahmenListe(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmenListe", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmenListeResponse")]
  IAsyncResult BeginFremdSystemGetWasserEntnahmenListe(
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  Dictionary<Guid, DateTime> EndFremdSystemGetWasserEntnahmenListe(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemGetKarteiByKBGuid", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetKarteiByKBGuidResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemGetKarteiByKBGuidWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFKarteiBlatt FremdSystemGetKarteiByKBGuid(Guid karteiGuid, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemGetKarteiByKBGuid", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetKarteiByKBGuidResponse")]
  IAsyncResult BeginFremdSystemGetKarteiByKBGuid(
    Guid karteiGuid,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFKarteiBlatt EndFremdSystemGetKarteiByKBGuid(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiByKBGuid", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiByKBGuidResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiByKBGuidWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFObjektKartei FremdSystemGetObjektKarteiByKBGuid(Guid karteiGuid, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiByKBGuid", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetObjektKarteiByKBGuidResponse")]
  IAsyncResult BeginFremdSystemGetObjektKarteiByKBGuid(
    Guid karteiGuid,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFObjektKartei EndFremdSystemGetObjektKarteiByKBGuid(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmeByWEGuid", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmeByWEGuidResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmeByWEGuidWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFWasserentnahmen FremdSystemGetWasserEntnahmeByWEGuid(Guid wasserGuid, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmeByWEGuid", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemGetWasserEntnahmeByWEGuidResponse")]
  IAsyncResult BeginFremdSystemGetWasserEntnahmeByWEGuid(
    Guid wasserGuid,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  WCFWasserentnahmen EndFremdSystemGetWasserEntnahmeByWEGuid(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemeGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemeGetAllResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemeGetAllWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  WCFFremdSystem[] FremdSystemeGetAll(Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemeGetAll", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemeGetAllResponse")]
  IAsyncResult BeginFremdSystemeGetAll(Guid TicketID, AsyncCallback callback, object asyncState);

  WCFFremdSystem[] EndFremdSystemeGetAll(IAsyncResult result);

  [OperationContract(Action = "http://tempuri.org/IELISWCFService/FremdSystemPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemPersistResponse")]
  [FaultContract(typeof (WCFException), Action = "http://tempuri.org/IELISWCFService/FremdSystemPersistWCFExceptionFault", Name = "WCFException", Namespace = "http://schemas.datacontract.org/2004/07/ELIS.ELISWCF")]
  bool FremdSystemPersist(WCFFremdSystem fs, Guid TicketID);

  [OperationContract(AsyncPattern = true, Action = "http://tempuri.org/IELISWCFService/FremdSystemPersist", ReplyAction = "http://tempuri.org/IELISWCFService/FremdSystemPersistResponse")]
  IAsyncResult BeginFremdSystemPersist(
    WCFFremdSystem fs,
    Guid TicketID,
    AsyncCallback callback,
    object asyncState);

  bool EndFremdSystemPersist(IAsyncResult result);
}
