class Operation {
  String operationId;
  String originName;
  String programName;
  String callerName;
  String injured;
  String operationName;
  DateTime recieved;
  DateTime? completed;
  int level;
  String info;
  String adress;

  Operation(
    this.operationId,
    this.originName,
    this.programName,
    this.callerName,
    this.injured,
    this.operationName,
    this.recieved,
    this.completed,
    this.level,
    this.info,
    this.adress,
  );
}
