import 'package:epas_app/models/availability.dart';
import 'package:epas_app/models/operation.dart';
import 'package:epas_app/services/operationService.dart';
import 'package:flutter/material.dart';

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
  List<Operation> operations = [];

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

  void _incrementCounter() {
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: _appBar(),
      body: Container(
          color: const Color.fromRGBO(40, 50, 60, 1),
          child: const Row(
            mainAxisAlignment: MainAxisAlignment.spaceAround,
            children: [],
          )),
    );
  }

  AppBar _appBar() {
    return AppBar(
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
                  color: Colors.white, fontFamily: 'rationaldisplay')),
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
