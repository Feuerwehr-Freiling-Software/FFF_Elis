import 'dart:convert';

import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:epas_app/models/authentication/AccessTokenResponse.dart';

class TokenService {
  static Future<AccessTokenResponse?> GetToken() async {
    const storage = FlutterSecureStorage();
    var value = await storage.read(key: 'jwt');
    if (value == null) {
      return null;
    }
    return jsonDecode(value);
  }

  static Future<void> setToken(AccessTokenResponse token) async {
    const storage = FlutterSecureStorage();
    await storage.write(key: 'jwt', value: jsonEncode(token));
  }
}
