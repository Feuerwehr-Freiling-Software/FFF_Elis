import 'dart:convert';

class AccessTokenResponse {
  String tokenType;
  String accessToken;
  int expiresIn;
  String refreshToken;

  AccessTokenResponse(
      this.tokenType, this.accessToken, this.expiresIn, this.refreshToken);

  static AccessTokenResponse fromJson(String json) {
    Map<String, dynamic> data = jsonDecode(json);
    return AccessTokenResponse(
      data['tokenType'],
      data['accessToken'],
      data['expiresIn'],
      data['refreshToken'],
    );
  }
}
