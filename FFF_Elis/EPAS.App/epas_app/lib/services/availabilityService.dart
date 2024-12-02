import 'package:epas_app/models/availability.dart';
import 'package:shared_preferences/shared_preferences.dart';

class AvailabilityService {
  static const String _availabilityKey = 'user_availability';

  static Future<void> saveAvailability(Availability availability) async {
    final SharedPreferences prefs = await SharedPreferences.getInstance();
    await prefs.setInt(_availabilityKey, availability.index);
  }

  static Future<Availability> getAvailability() async {
    final SharedPreferences prefs = await SharedPreferences.getInstance();
    int? availabilityIndex = prefs.getInt(_availabilityKey);
    Availability availability = availabilityIndex != null
        ? Availability.values[availabilityIndex]
        : Availability.available;
    return availability;
  }
}
