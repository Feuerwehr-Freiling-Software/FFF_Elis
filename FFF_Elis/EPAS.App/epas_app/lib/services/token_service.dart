import 'dart:convert';

import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:epas_app/models/authentication/AccessTokenResponse.dart';

class TokenService {
  final storage = const FlutterSecureStorage();

  Future<AccessTokenResponse?> GetToken() async {
    var value = await storage.read(key: 'jwt');
    if (value == null) {
      return null;
    }
    return jsonDecode(value);
  }

  Future<void> setToken(AccessTokenResponse token) async {
    await storage.write(key: 'jwt', value: jsonEncode(token));
  }
}
