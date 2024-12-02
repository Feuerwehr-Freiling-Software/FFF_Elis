import 'package:epas_app/models/availability.dart';

class AvailabilityPlanModel {
  DateTime from;
  DateTime until;
  Availability availability;
  bool reocurring;

  AvailabilityPlanModel(
      this.from, this.until, this.availability, this.reocurring);
}
