import 'package:epas_app/models/Dtos/OperationResponseDto.dart';

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
  List<OperationResponseDto> operationResponses;
  double lat;
  double lon;

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
    this.operationResponses,
    this.lat,
    this.lon,
  );
}
