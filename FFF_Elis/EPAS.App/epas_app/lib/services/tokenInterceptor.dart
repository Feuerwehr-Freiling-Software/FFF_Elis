import 'dart:io';

import 'package:epas_app/services/token_service.dart';
import 'package:http_interceptor/http_interceptor.dart';

class AuthenticationInterceptor implements InterceptorContract {
  TokenService tokenService = TokenService();
  @override
  Future<bool> shouldInterceptRequest() {
    return Future.value(true);
  }

  @override
  Future<BaseRequest> interceptRequest({required BaseRequest request}) async {
    try {
      var token = await tokenService.GetToken();

      if (token == null) return request;

      request.headers[HttpHeaders.contentTypeHeader] = "application/json";
      request.headers[HttpHeaders.authorizationHeader] = token.accessToken;
    } catch (e) {
      print(e);
    }
    return request;
  }

  @override
  Future<BaseResponse> interceptResponse(
          {required BaseResponse response}) async =>
      response;

  @override
  Future<bool> shouldInterceptResponse() {
    return Future.value(false);
  }
}
