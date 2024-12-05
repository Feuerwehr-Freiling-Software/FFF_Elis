import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:epas_app/models/authentication/AccessTokenResponse.dart';

class AuthenticationService {
  final String _baseUrl = "https://localhost:44306";

  Future<bool> Register(String email, String password) async {
    final response = await http.post(
      Uri.parse('$_baseUrl/register'),
      headers: {'Content-Type': 'application/json'},
      body: json.encode({'email': email, 'password': password}),
    );

    if (response.statusCode == 200) {
      print(response.body);
      print('User registered successfully');
      return true;
    } else {
      print('Failed to register user');
      return false;
    }
  }

  Future<bool> Login(String email, String password) async {
    try {
      final response = await http.post(
        Uri.parse('$_baseUrl/login'),
        headers: {'Content-Type': 'application/json'},
        body: json.encode({'email': email, 'password': password}),
      );

      if (response.statusCode == 200) {
        AccessTokenResponse token = AccessTokenResponse.fromJson(response.body);
        print('User logged in successfully');
        return true;
      } else {
        print(response.body);
        print('Failed to login user');
        return false;
      }
    } catch (e) {
      print(e);
      return false;
    }
  }
}
