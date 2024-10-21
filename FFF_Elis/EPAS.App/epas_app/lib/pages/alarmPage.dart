import 'package:epas_app/models/Dtos/OperationResponseDto.dart';
import 'package:epas_app/models/Enums/OperationResponseEnum.dart';
import 'package:epas_app/models/operation.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class AlarmPage extends StatefulWidget {
  final Operation operation;
  OperationResponseEnum response = OperationResponseEnum.Read;

  final String username = "Haunschmied Bastian";
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
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: _appBar(context),
        body: Container(
          height: MediaQuery.sizeOf(context).height,
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
                  _getResponseButtons(context),
                  const SizedBox(height: 20),
                  GestureDetector(
                    onTap: () {
                      // TODO: Add navigation to total Responses Page
                    },
                    child: _getTotalResponseButtons(context),
                  )
                ],
              ),
            ),
          ),
        ));
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
        Row(
          children: [
            Column(
              children: [
                Container(
                  height: 110,
                  child: Row(
                    children: [
                      Container(
                        height: 160,
                        width: 10,
                        color: const Color(0xff3CAE2B),
                      )
                    ],
                  ),
                )
              ],
            )
          ],
        )
      ],
    );
  }

  _getResponseButtons(BuildContext context) {
    var headingStyle = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 25);
    var textStyle = const TextStyle(
        color: Colors.white, fontFamily: 'rationaldisplay-book', fontSize: 15);
    var checkIchonStyle = const TextStyle(
        color: Colors.white, fontFamily: 'Fronius-Symbols', fontSize: 20);

    return Column(children: [
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
      Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          _getResponseButton(
              textStyle, checkIchonStyle, OperationResponseEnum.Coming),
          const SizedBox(width: 10),
          _getResponseButton(
              textStyle, checkIchonStyle, OperationResponseEnum.Available),
          const SizedBox(width: 10),
          _getResponseButton(
              textStyle, checkIchonStyle, OperationResponseEnum.NotAvailable),
        ],
      )
    ]);
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
      child: SizedBox(
        height: 75, // Double the height of the button
        child: ElevatedButton(
          style: ButtonStyle(
              backgroundColor: MaterialStateProperty.all(backgroundColor),
              shape: MaterialStateProperty.all<RoundedRectangleBorder>(
                const RoundedRectangleBorder(
                  borderRadius: BorderRadius.zero,
                ),
              )),
          onPressed: () {
            setState(() {
              widget.response = responseEnum;
            });
          },
          child: FittedBox(
            fit: BoxFit.fitWidth,
            child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text(
                  buttonText,
                  style: textStyle,
                ),
                const SizedBox(
                  width: 10,
                ),
                Visibility(
                  visible: widget.response == responseEnum,
                  child: Text(
                    'check',
                    style: checkIchonStyle,
                  ),
                )
              ],
            ),
          ),
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
                Text(
                  '    ${widget.operation.adress}',
                  style: infoText,
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
                  flex: 7,
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
