import 'dart:ffi';

import 'package:epas_app/models/availability.dart';
import 'package:epas_app/models/operation.dart';
import 'package:epas_app/pages/alarmPage.dart';
import 'package:epas_app/services/operationService.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

import 'pageAnimations.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return const MaterialApp(
      title: 'EPAS App',
      debugShowCheckedModeBanner: false,
      home: MyHomePage(title: 'Alarmübersicht'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key, required this.title});
  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  late Future<List<Operation>> operations;

  Color getAvailabilityColor() {
    // TODO: Implement Availability from State
    Availability availability = Availability.notAvailable;
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

  @override
  void initState() {
    super.initState();
    operations = operation_service.fetchOperations_MOCK();
  }

  void _incrementCounter() {
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _appBar(),
      body: Container(
        height: MediaQuery.sizeOf(context).height * 1,
        color: const Color.fromRGBO(40, 50, 60, 1),
        child: SingleChildScrollView(
          child: Column(
            children: [
              FutureBuilder(
                  future: operations,
                  builder: (context, snapshot) {
                    if (snapshot.hasData) {
                      List<Widget> allOperations = [];
                      for (var item in snapshot.data!) {
                        allOperations.add(_getOperationWidget(context, item));
                      }
                      return Column(children: allOperations);
                    } else if (snapshot.hasError) {
                      return Text("Fehler beim Laden der Daten...");
                    }

                    return const CircularProgressIndicator();
                  })
            ],
          ),
        ),
      ),
    );
  }

  GestureDetector _getOperationWidget(
      BuildContext context, Operation operation) {
    return GestureDetector(
      onTap: () {
        Navigator.push(
            context,
            SlideRightRoute(
                page: AlarmPage(
              operation: operation,
            )));
      },
      child: Padding(
        padding: const EdgeInsets.only(top: 10),
        child: Container(
          height: 110,
          color: const Color.fromRGBO(40, 50, 60, 1),
          child: Padding(
            padding: const EdgeInsets.only(top: 10, bottom: 10),
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
                      Padding(
                        padding: EdgeInsets.only(top: 8),
                        child: Row(
                          mainAxisSize: MainAxisSize.max,
                          children: [
                            Text(
                              'arrow_undo',
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
                Expanded(
                  flex: 2,
                  child: Column(
                    mainAxisSize: MainAxisSize.max,
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      Container(
                        decoration: const BoxDecoration(),
                        alignment: const AlignmentDirectional(0, 0),
                        child: const Text(
                          'arrow-right',
                          style: TextStyle(
                              fontFamily: "Fronius-Symbols",
                              color: Colors.white,
                              letterSpacing: 0),
                        ),
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  AppBar _appBar() {
    return AppBar(
      automaticallyImplyLeading: false,
      backgroundColor: const Color.fromRGBO(47, 56, 66, 1),
      title: Row(
        mainAxisAlignment: MainAxisAlignment.spaceAround,
        children: [
          TextButton(
            onPressed: () {
              // TODO: Implement Availability Settings Page
            },
            style: ButtonStyle(
              overlayColor: MaterialStateProperty.all(Colors.transparent),
            ),
            child: Text("clock",
                style: TextStyle(
                    fontFamily: 'Fronius-Symbols',
                    color: getAvailabilityColor())),
          ),
          Text(widget.title,
              style: const TextStyle(
                  color: Colors.white, fontFamily: 'rationaldisplay-book')),
          TextButton(
            onPressed: () {
              // TODO: Implement Settings Page
            },
            style: ButtonStyle(
              overlayColor: MaterialStateProperty.all(Colors.transparent),
            ),
            child: const Text("gear",
                style: TextStyle(
                    fontFamily: 'Fronius-Symbols', color: Colors.white)),
          )
        ],
      ),
    );
  }
}
