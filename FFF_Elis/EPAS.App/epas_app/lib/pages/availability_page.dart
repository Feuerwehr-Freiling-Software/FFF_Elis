import 'package:epas_app/models/availability.dart';
import 'package:flutter/material.dart';

class AvailabilityPage extends StatefulWidget {
  AvailabilityPage({super.key});
  Availability availability = Availability.available;
  bool availabilityPlanActive = false;

  @override
  State<AvailabilityPage> createState() => _AvailabilityPageState();
}

class _AvailabilityPageState extends State<AvailabilityPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color(0xff28323C),
      appBar: _appBar(context),
      body: SingleChildScrollView(
        child: Container(
          color: Color(0xff28323C),
          width: double.infinity,
          child: Column(
            children: [
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Row(
                  children: [
                    Expanded(
                      child: _getCurrentAvailability(),
                    ),
                  ],
                ),
              ),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Row(
                  children: [
                    Expanded(
                      child: Padding(
                        padding: const EdgeInsets.only(left: 20, right: 20),
                        child: Text(
                          "Hinweis: Ihre aktuelle Verfügbarkeit wird geteilt mit: 'WAS FF Freiling' und 'WAS FF Sattledt'",
                          style: TextStyle(color: Colors.white70, fontSize: 10),
                        ),
                      ),
                    ),
                  ],
                ),
              ),
              Row(
                children: [
                  _getAvailabilityButtons(context),
                ],
              ),
              Row(
                children: [
                  SizedBox(
                    width: MediaQuery.of(context).size.width,
                    child: Padding(
                      padding: EdgeInsets.all(40),
                      child: Container(
                        decoration: BoxDecoration(
                          color: const Color.fromRGBO(47, 56, 66, 1),
                          borderRadius: BorderRadius.circular(15),
                        ),
                        child: Column(
                          children: [
                            Row(
                              children: [
                                Padding(
                                  padding: const EdgeInsets.all(8.0)
                                      .add(EdgeInsets.only(left: 20)),
                                  child: Text(
                                    "Verfügbarkeitsplan",
                                    style: TextStyle(
                                        color: Colors.white,
                                        fontFamily: 'rationaldisplay-book',
                                        fontSize: 15),
                                  ),
                                ),
                              ],
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceAround,
                              children: [
                                Text("Verfügbarkeitsplan aktiv"),
                                Switch(
                                  value: widget.availabilityPlanActive,
                                  onChanged: (bool value) {
                                    setState(
                                      () {
                                        widget.availabilityPlanActive = value;
                                      },
                                    );
                                  },
                                )
                              ],
                            ),
                          ],
                        ),
                      ),
                    ),
                  ),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }

  SizedBox _getAvailabilityButtons(BuildContext context) {
    return SizedBox(
      width: MediaQuery.of(context).size.width,
      child: Center(
        child: Padding(
          padding: const EdgeInsets.all(20.0),
          child: Container(
            decoration: BoxDecoration(
                color: const Color.fromRGBO(47, 56, 66, 1),
                borderRadius: BorderRadius.circular(15)),
            width: MediaQuery.of(context).size.width * 0.9,
            child: Padding(
              padding: EdgeInsets.all(20),
              child: Flex(
                direction: Axis.vertical,
                children: [
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: _getAvailabilityButton(Availability.available),
                  ),
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Row(
                      children: [
                        Expanded(
                          child: _getAvailabilityButton(
                              Availability.conditionallyAvailable),
                        ),
                      ],
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Row(
                      children: [
                        Expanded(
                          child:
                              _getAvailabilityButton(Availability.notAvailable),
                        ),
                      ],
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }

  AppBar _appBar(BuildContext context) {
    return AppBar(
      automaticallyImplyLeading: false,
      backgroundColor: const Color.fromRGBO(47, 56, 66, 1),
      title: Row(
        mainAxisAlignment: MainAxisAlignment.spaceAround,
        children: [
          const Text("      "),
          const Text(
            "Verfügbarkeit",
            style: TextStyle(
                color: Colors.white, fontFamily: 'rationaldisplay-book'),
          ),
          TextButton(
            onPressed: () {
              Navigator.pop(context);
            },
            style: ButtonStyle(
              overlayColor: MaterialStateProperty.all(Colors.transparent),
            ),
            child: const Text("arrow-right",
                style: TextStyle(
                    fontFamily: 'Fronius-Symbols', color: Colors.white)),
          ),
        ],
      ),
    );
  }

  Widget _getAvailabilityButton(Availability availability) {
    String text = getAvailabilityText(availability);
    Color color = getAvailabilityColor(availability);
    var textStyle = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 15);
    var checkIchonStyle = const TextStyle(
        color: Colors.white, fontFamily: 'Fronius-Symbols', fontSize: 20);
    return Row(
      children: [
        Expanded(
          child: ElevatedButton(
            style: ElevatedButton.styleFrom(
              backgroundColor: color,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(15),
              ),
              minimumSize:
                  const Size.fromHeight(75), // Double the height of the button
            ),
            onPressed: () {
              setState(() {
                widget.availability = availability;
              });
            },
            child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text(
                  text,
                  style: textStyle,
                ),
                const SizedBox(width: 10),
                if (widget.availability == availability)
                  Text(
                    'check',
                    style: checkIchonStyle,
                  ),
              ],
            ),
          ),
        ),
      ],
    );
  }

  Widget _getCurrentAvailability() {
    Availability availability = widget.availability;
    Color color = getAvailabilityColor(availability);
    String availabilityText = getAvailabilityText(availability);
    return Padding(
      padding: const EdgeInsets.all(10.0),
      child: Container(
        decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(15), color: color),
        width: double.infinity,
        height: 125,
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: const [
                Text(
                  'Aktuelle Verfügbarkeit',
                  style: TextStyle(fontSize: 20, color: Colors.white),
                ),
              ],
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text(
                  availabilityText,
                  style: TextStyle(fontSize: 25, color: Colors.white),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }

  Color getAvailabilityColor(Availability availability) {
    switch (availability) {
      case Availability.available:
        return const Color.fromRGBO(60, 174, 43, 1);
      case Availability.conditionallyAvailable:
        return const Color.fromRGBO(255, 180, 0, 1);
      case Availability.notAvailable:
        return const Color.fromRGBO(222, 64, 25, 1);
      default:
        return const Color.fromRGBO(222, 64, 25, 1);
    }
  }

  String getAvailabilityText(Availability availability) {
    switch (availability) {
      case Availability.available:
        return "VERFÜGBAR";
      case Availability.conditionallyAvailable:
        return "BEDINGT VERFÜGBAR";
      case Availability.notAvailable:
        return "NICHT VERFÜGBAR";
      default:
        return "NICHT VERFÜGBAR";
    }
  }
}
