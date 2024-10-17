import 'dart:io';

import 'package:http/http.dart' as http;
import 'dart:convert';

import '../models/operation.dart';

class operation_service {
  static Future<List<Operation>> fetchOperations() async {
    http.Response response = await http.get(Uri.dataFromString(
        'https://localhost:44306/api/Operation/GetOperationsWithKey?firebrigade=FREILING&apiKey=9945b8c9fd3a184b50ac930a4da4d863'));
    var res = jsonDecode(response.body);
    print(res);
    return res;
  }

  static Future<List<Operation>> fetchOperations_MOCK() async {
    sleep(const Duration(seconds: 5));
  }
}
