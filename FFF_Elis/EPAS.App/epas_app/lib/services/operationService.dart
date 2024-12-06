import 'dart:io';
import 'package:epas_app/models/Dtos/OperationResponseDto.dart';
import 'package:epas_app/models/Enums/OperationResponseEnum.dart';
import 'package:epas_app/models/Qualifications.dart';
import 'package:epas_app/services/tokenInterceptor.dart';
import 'package:http/http.dart' as http;
import 'package:http_interceptor/http_interceptor.dart';
import 'dart:convert';

import '../models/operation.dart';

class OperationService {
  static const String baseUrl = "https://localhost:44306/api";
  Client client = InterceptedClient.build(interceptors: [
    AuthenticationInterceptor(),
  ]);

  static Future<List<Operation>> fetchOperations() async {
    http.Response response = await http.get(Uri.dataFromString(
        'https://localhost:44306/api/Operation/GetOperationsWithKey?firebrigade=FREILING&apiKey=9945b8c9fd3a184b50ac930a4da4d863'));
    var res = jsonDecode(response.body);
    print(res);
    return res;
  }

  static Future<List<Operation>> fetchOperations_MOCK() async {
    sleep(const Duration(seconds: 5));

    List<Operation> mockOperations = [];

    List<OperationResponseDto> responses = [];
    List<Qualification> qualifications = [];
    qualifications.add(Qualification(1, 'EL', 'FEB800'));
    qualifications.add(Qualification(2, 'GRKDT', 'D73237'));
    qualifications.add(Qualification(3, 'FMD', '6E323A'));
    qualifications.add(Qualification(4, 'AS', '404B9A'));
    qualifications.add(Qualification(5, 'C', '02A28A'));

    responses.add(OperationResponseDto('E123', "Haunschmied.Bastian",
        OperationResponseEnum.Coming, qualifications));
    responses.add(OperationResponseDto('E123', "Leutgöb Fabian",
        OperationResponseEnum.NotAvailable, qualifications));
    responses.add(OperationResponseDto('E123', "Leutgöb Lukas",
        OperationResponseEnum.Available, qualifications));
    responses.add(OperationResponseDto('E123', "Eisenmann Liliane",
        OperationResponseEnum.Coming, qualifications));

    mockOperations.add(Operation(
        "E123",
        "SIMULATOR",
        "FEUER",
        "133",
        "Bamsti",
        "BMA Almi",
        DateTime.parse("2024-10-21 13:56:00"),
        null,
        1,
        "Rauch sichtbar",
        "Hörschingerstraße 1, 4064 Oftering",
        responses,
        48.226990,
        14.160770));

    mockOperations.add(
      Operation(
          "E456",
          "SIMULATOR",
          "Technisch",
          "133",
          "Bamsti",
          "VU Eingeklemmt",
          DateTime.parse("2024-09-20 20:27:00"),
          DateTime.parse("2024-09-20 20:27:00"),
          2,
          "Rauch sichtbar",
          "Tischlerweg 2, 4064 Oftering",
          responses,
          48.229680,
          14.118800),
    );

    mockOperations.add(Operation(
      "E123",
      "SIMULATOR",
      "FEUER",
      "133",
      "Bamsti",
      "BMA Almi",
      DateTime.parse("2024-10-20 13:27:00"),
      DateTime.parse("2024-10-20 20:27:00"),
      3,
      "Rauch sichtbar",
      "Freilingerstraße 3a, 4064 Oftering",
      responses,
      48.235540,
      14.127480,
    ));

    mockOperations.add(Operation(
      "E123",
      "SIMULATOR",
      "FEUER",
      "133",
      "Bamsti",
      "BMA Almi",
      DateTime.parse("2024-10-20 13:27:00"),
      DateTime.parse("2024-10-20 20:27:00"),
      3,
      "Rauch sichtbar",
      "Freilingerstraße 3a, 4064 Oftering",
      responses,
      48.235540,
      14.127480,
    ));

    mockOperations.add(Operation(
      "E123",
      "SIMULATOR",
      "FEUER",
      "133",
      "Bamsti",
      "BMA Almi",
      DateTime.parse("2024-10-20 13:27:00"),
      DateTime.parse("2024-10-20 20:27:00"),
      3,
      "Rauch sichtbar",
      "Freilingerstraße 3a, 4064 Oftering",
      responses,
      48.235540,
      14.127480,
    ));
    return mockOperations;
  }

  Future<bool> TestApiAuthorization() async {
    try {
      final response =
          await client.get("$baseUrl/Operation/TestAuthorization".toUri());
      if (response.statusCode == 200) {
        return true;
      } else {
        return false;
      }
    } catch (e) {
      print(e);
      return false;
    }
  }
}
