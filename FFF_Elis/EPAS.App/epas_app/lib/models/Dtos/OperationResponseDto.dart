import 'package:epas_app/models/Enums/OperationResponseEnum.dart';
import 'package:epas_app/models/Qualifications.dart';

class OperationResponseDto {
  String operationId;
  String username;
  OperationResponseEnum response;
  List<Qualification> Qualifications;

  OperationResponseDto(
      this.operationId, this.username, this.response, this.Qualifications);
}
