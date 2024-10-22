import 'package:epas_app/extensions/ColorExtension.dart';
import 'package:epas_app/models/Enums/OperationResponseEnum.dart';
import 'package:epas_app/models/Qualifications.dart';
import 'package:epas_app/models/operation.dart';
import 'package:epas_app/pageAnimations.dart';
import 'package:epas_app/pages/operation_responses.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_map/flutter_map.dart';
import 'package:intl/intl.dart';
import 'package:latlong2/latlong.dart';
import 'package:geocoding/geocoding.dart';
import 'package:maps_launcher/maps_launcher.dart';
import 'package:url_launcher/url_launcher.dart';

class AlarmPage extends StatefulWidget {
  final Operation operation;
  OperationResponseEnum response = OperationResponseEnum.Read;

  final String username = "Haunschmied.Bastian";
  AlarmPage({super.key, required this.operation}) {
    final list = operation.operationResponses
        .where((element) => element.username == username);
    var userResponse = list.isEmpty ? null : list.first;
    response = userResponse != null
        ? userResponse.response
        : OperationResponseEnum.Read;
  }

  @override
  State<AlarmPage> createState() => _AlarmPageState();
}

class _AlarmPageState extends State<AlarmPage> {
  var textStyle = const TextStyle(
      color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 15);

  var headingStyle = const TextStyle(
      color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 25);

  late Future<List<Location>> location;

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _appBar(context),
      body: Container(
        height: MediaQuery.of(context).size.height,
        color: const Color.fromRGBO(40, 50, 60, 1),
        child: SingleChildScrollView(
          child: Padding(
            padding: const EdgeInsets.all(20.0),
            child: Column(
              children: [
                _getOperationWidget(context, widget.operation),
                const SizedBox(height: 5),
                _getAlarmInfoWidget(context),
                const SizedBox(height: 10),
                Row(
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    Visibility(
                      visible: widget.operation.completed == null,
                      child: _getResponseButtons(context),
                    ),
                    Visibility(
                      visible: widget.operation.completed != null,
                      child: Column(
                        mainAxisAlignment: MainAxisAlignment.start,
                        children: [
                          Row(
                            mainAxisAlignment: MainAxisAlignment.start,
                            children: [
                              Text(
                                'Rückmeldestatus',
                                style: headingStyle,
                              ),
                            ],
                          ),
                          Center(
                            widthFactor: 1,
                            child: Container(
                              width: MediaQuery.of(context).size.width * 0.8,
                              child: Text(
                                'Einsatz abgeschlossen. Rückmeldung nicht mehr möglich',
                                style: textStyle,
                                softWrap: true,
                              ),
                            ),
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
                const SizedBox(height: 20),
                Container(
                  child: GestureDetector(
                    onTap: () {
                      Navigator.push(
                          context,
                          SlideRightRoute(
                              page: OperationResponses(
                            operationResponses:
                                widget.operation.operationResponses,
                          )));
                    },
                    child: Container(child: _getTotalResponseButtons(context)),
                  ),
                ),
                const SizedBox(
                  height: 20,
                ),
                _getMap(context)
              ],
            ),
          ),
        ),
      ),
    );
  }

  _getMap(BuildContext context) {
    return Column(
      children: [
        Row(
          children: [
            Text(
              "Einsatzort",
              style: headingStyle,
            )
          ],
        ),
        Row(
          children: [
            Flex(
              direction: Axis.horizontal,
              mainAxisAlignment: MainAxisAlignment.start,
              children: [
                FittedBox(
                  fit: BoxFit.contain,
                  child: Center(
                    child: SizedBox(
                      height: 400,
                      // HIER
                      width: MediaQuery.of(context).size.width * 0.8,
                      child: FlutterMap(
                        mapController: MapController(),
                        options: MapOptions(
                          keepAlive: true,
                          initialCenter: LatLng(
                              widget.operation.lat, widget.operation.lon),
                        ),
                        children: [
                          TileLayer(
                            urlTemplate:
                                'https://tile.openstreetmap.org/{z}/{x}/{y}.png',
                          ),
                          MarkerLayer(
                            markers: [
                              Marker(
                                  point: LatLng(widget.operation.lat,
                                      widget.operation.lon),
                                  child: const Icon(
                                    CupertinoIcons.flame_fill,
                                    color: Colors.red,
                                    size: 30,
                                  ),
                                  alignment: Alignment.topCenter),
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
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: [
            Column(
              children: [
                Text(
                  widget.operation.adress,
                  style: textStyle,
                ),
              ],
            ),
            Column(
              children: [
                GestureDetector(
                  onTap: () {
                    MapsLauncher.launchCoordinates(
                        widget.operation.lat, widget.operation.lon);
                  },
                  child: Text(
                    "Route öffnen",
                    style: textStyle.apply(color: Colors.blue),
                  ),
                )
              ],
            )
          ],
        )
      ],
    );
  }

  _getTotalResponseButtons(BuildContext context) {
    var headingStyle = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 25);
    var textStyle = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 15);
    var checkIchonStyle = const TextStyle(
        color: Colors.white, fontFamily: 'Fronius-Symbols', fontSize: 20);
    return Column(
      children: [
        Row(
          children: [
            Text(
              'Rückmeldestatus',
              style: headingStyle,
            ),
          ],
        ),
        const SizedBox(
          height: 10,
        ),
        SingleChildScrollView(
          scrollDirection: Axis.horizontal,
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Container(
                    decoration: BoxDecoration(
                      color: const Color.fromRGBO(60, 174, 43, 1),
                    ),
                    padding: const EdgeInsets.all(8),
                    child: Column(
                      children: [
                        Text("Zusagen", style: textStyle),
                        Text(
                          widget.operation.operationResponses
                              .where((element) =>
                                  element.response ==
                                  OperationResponseEnum.Coming)
                              .length
                              .toString(),
                          style: textStyle,
                        ),
                      ],
                    ),
                  ),
                ],
              ),
              _getQualificationInfos(context, widget.operation),
              GestureDetector(
                onTap: () {},
                child: Container(
                  width: MediaQuery.of(context).size.width * 0.1,
                  height: 50,
                  alignment: Alignment.center,
                  child: const Text(
                    "arrow-right",
                    style: TextStyle(
                        fontFamily: 'Fronius-Symbols', color: Colors.white),
                  ),
                ),
              ),
            ],
          ),
        ),
      ],
    );
  }

  _getQualificationInfos(BuildContext context, Operation operation) {
    Widget qualificationInfos = const Row();
    Map<Qualification, int> qualificationCounts = {};

    TextStyle textStyle = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book');

    for (var response in operation.operationResponses) {
      if (response.response == OperationResponseEnum.Coming) {
        for (var qualification in response.Qualifications) {
          if (qualificationCounts.containsKey(qualification)) {
            qualificationCounts[qualification] =
                qualificationCounts[qualification]! + 1;
          } else {
            qualificationCounts[qualification] = 1;
          }
        }
      }
    }

    qualificationInfos = Row(
      mainAxisAlignment: MainAxisAlignment.center,
      children: qualificationCounts.entries.map((entry) {
        return Padding(
          padding: const EdgeInsets.symmetric(horizontal: 5),
          child: Container(
            color: entry.key.color.toColor(),
            child: Padding(
              padding: const EdgeInsets.all(11.5),
              child: Column(
                children: [
                  Text(entry.key.name,
                      style: const TextStyle(color: Colors.white)),
                  Text(entry.value.toString(), style: textStyle),
                ],
              ),
            ),
          ),
        );
      }).toList(),
    );
    return qualificationInfos;
  }

  _getResponseButtons(BuildContext context) {
    var headingStyle = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 25);
    var textStyle = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 15);
    var checkIchonStyle = const TextStyle(
        color: Colors.white, fontFamily: 'Fronius-Symbols', fontSize: 20);

    return Column(
      children: [
        Row(
          children: [
            Text(
              'Rückmeldung',
              style: headingStyle,
            )
          ],
        ),
        const SizedBox(
            height: 10), // Add some spacing between the heading and buttons
        SizedBox(
          height: 150,
          width: MediaQuery.of(context).size.width * 0.9,
          child: Column(
            children: [
              _getResponseButton(
                  textStyle, checkIchonStyle, OperationResponseEnum.Coming),
              const SizedBox(height: 10),
              _getResponseButton(
                  textStyle, checkIchonStyle, OperationResponseEnum.Available),
              const SizedBox(height: 10),
              _getResponseButton(textStyle, checkIchonStyle,
                  OperationResponseEnum.NotAvailable),
            ],
          ),
        ),
      ],
    );
  }

  Expanded _getResponseButton(TextStyle textStyle, TextStyle checkIchonStyle,
      OperationResponseEnum responseEnum) {
    Color backgroundColor = const Color(0xffDE4019);
    String buttonText = "Komme nicht";

    switch (responseEnum) {
      case OperationResponseEnum.Coming:
        backgroundColor = const Color(0xff3CAE2B);
        buttonText = "Komme";
        break;
      case OperationResponseEnum.Available:
        backgroundColor = const Color(0xffE37909);
        buttonText = "Verfügbar";
        break;
      case OperationResponseEnum.NotAvailable:
        backgroundColor = const Color(0xffDE4019);
        buttonText = "Komme nicht";
        break;
      default:
        backgroundColor = const Color(0xffDE4019);
        buttonText = "Komme nicht";
    }

    return Expanded(
      child: ElevatedButton(
        style: ElevatedButton.styleFrom(
          primary: backgroundColor,
          shape: const RoundedRectangleBorder(
            borderRadius: BorderRadius.zero,
          ),
          minimumSize:
              const Size.fromHeight(75), // Double the height of the button
        ),
        onPressed: () {
          setState(() {
            widget.response = responseEnum;
          });
        },
        child: Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text(
              buttonText,
              style: textStyle,
            ),
            const SizedBox(width: 10),
            if (widget.response == responseEnum)
              Text(
                'check',
                style: checkIchonStyle,
              ),
          ],
        ),
      ),
    );
  }

  _getAlarmInfoWidget(BuildContext context) {
    TextStyle infoText = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book');

    TextStyle infoTextHeadline = const TextStyle(
      color: Colors.white,
      fontFamily: 'rationaldisplay-book',
      decoration: TextDecoration.underline,
    );

    return Container(
      color: const Color(0xff2F3842),
      child: Padding(
        padding: const EdgeInsets.symmetric(vertical: 30, horizontal: 50),
        child: Column(
          children: [
            Row(
              children: [
                Text(
                  widget.operation.operationName,
                  style: infoText,
                )
              ],
            ),
            Row(
              children: [Text('Infos:', style: infoTextHeadline)],
            ),
            Row(
              children: [Text('    ${widget.operation.info}', style: infoText)],
            ),
            Row(
              children: [Text('Adresse:', style: infoTextHeadline)],
            ),
            Row(
              children: [
                Container(
                  width: MediaQuery.of(context).size.width * 0.5,
                  child: Text(
                    '    ${widget.operation.adress}',
                    style: infoText,
                  ),
                )
              ],
            )
          ],
        ),
      ),
    );
  }

  GestureDetector _getOperationWidget(
      BuildContext context, Operation operation) {
    return GestureDetector(
      onTap: () {},
      child: Padding(
        padding: const EdgeInsets.only(top: 10),
        child: Container(
          height: 110,
          color: const Color(0xff2F3842),
          child: Padding(
            padding: const EdgeInsets.only(top: 10, bottom: 10, right: 10),
            child: Row(
              mainAxisSize: MainAxisSize.max,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Column(
                  mainAxisSize: MainAxisSize.max,
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Expanded(
                      child: Container(
                        width: 10,
                        height: MediaQuery.sizeOf(context).height * 1,
                        decoration: const BoxDecoration(
                          color: Color(0xFFDE4019),
                        ),
                      ),
                    ),
                  ],
                ),
                const Padding(
                  padding: EdgeInsets.all(8),
                  child: Column(
                    mainAxisSize: MainAxisSize.max,
                    mainAxisAlignment: MainAxisAlignment.start,
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Padding(
                        padding: EdgeInsets.only(top: 8),
                        child: Row(
                          mainAxisSize: MainAxisSize.max,
                          mainAxisAlignment: MainAxisAlignment.start,
                          children: [
                            Text(
                              'bell-solid',
                              style: TextStyle(
                                  fontFamily: "Fronius-Symbols",
                                  color: Color(0xFFDE4019),
                                  letterSpacing: 0),
                            ),
                          ],
                        ),
                      ),
                    ],
                  ),
                ),
                Expanded(
                  child: Column(
                    mainAxisSize: MainAxisSize.max,
                    children: [
                      Row(
                        mainAxisSize: MainAxisSize.max,
                        children: [
                          Text(
                            operation.originName,
                            style: const TextStyle(
                                fontFamily: "rationaldisplay",
                                color: Colors.white,
                                letterSpacing: 0),
                          ),
                        ],
                      ),
                      Row(
                        mainAxisSize: MainAxisSize.max,
                        children: [
                          Text(
                            operation.level.toString(),
                            style: const TextStyle(
                                fontFamily: "rationaldisplay",
                                color: Colors.white,
                                letterSpacing: 0),
                          ),
                        ],
                      ),
                      Row(
                        mainAxisSize: MainAxisSize.max,
                        children: [
                          Text(
                            operation.programName,
                            style: const TextStyle(
                                fontFamily: "rationaldisplay",
                                color: Colors.white,
                                letterSpacing: 0),
                          ),
                        ],
                      ),
                      Row(
                        mainAxisSize: MainAxisSize.max,
                        children: [
                          Expanded(
                            child: Container(
                              decoration: const BoxDecoration(),
                              child: Text(
                                operation.adress,
                                overflow: TextOverflow.ellipsis,
                                textAlign: TextAlign.start,
                                style: const TextStyle(
                                    fontFamily: "rationaldisplay",
                                    color: Colors.white,
                                    letterSpacing: 0),
                              ),
                            ),
                          ),
                        ],
                      ),
                    ],
                  ),
                ),
                Column(
                  mainAxisSize: MainAxisSize.max,
                  children: [
                    Text(
                      DateFormat('dd.MM.yyyy - HH:mm')
                          .format(operation.recieved),
                      style: const TextStyle(
                          fontFamily: "rationaldisplay",
                          color: Colors.white,
                          letterSpacing: 0),
                    ),
                  ],
                ),
              ],
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
          TextButton(
            onPressed: () {
              Navigator.pop(context);
            },
            style: ButtonStyle(
              overlayColor: MaterialStateProperty.all(Colors.transparent),
            ),
            child: const Text("arrow-left",
                style: TextStyle(
                    fontFamily: 'Fronius-Symbols', color: Colors.white)),
          ),
          const Text("Alarm",
              style: TextStyle(
                  color: Colors.white, fontFamily: 'rationaldisplay-book')),
          const Text('         ')
        ],
      ),
    );
  }
}
