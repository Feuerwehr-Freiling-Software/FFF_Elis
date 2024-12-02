import 'package:epas_app/models/Dtos/OperationResponseDto.dart';
import 'package:epas_app/models/Enums/OperationResponseEnum.dart';
import 'package:flutter/material.dart';

// ignore: must_be_immutable
class OperationResponses extends StatelessWidget {
  List<OperationResponseDto> responseList = [];
  OperationResponses(
      {super.key, required List<OperationResponseDto> operationResponses})
      : responseList = operationResponses;
  final TextStyle headLineStyle = const TextStyle(
      fontFamily: 'rationaldisplay-book', fontSize: 30, color: Colors.white);
  final TextStyle textStyle = const TextStyle(
      fontFamily: 'rationaldisplay-book', fontSize: 20, color: Colors.white);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color(0xff28323C),
      appBar: _getAppbar(context),
      body: SingleChildScrollView(
        scrollDirection: Axis.vertical,
        child: Column(
          children: [
            for (var group in _groupResponsesByEnum(responseList).entries)
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: Center(
                      child: Text(
                        _getTitleForResponse(group.key),
                        style: headLineStyle,
                      ),
                    ),
                  ),
                  for (var response in group.value)
                    Padding(
                      padding: const EdgeInsets.only(top: 5),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          Container(
                            alignment: Alignment.center,
                            width: MediaQuery.of(context).size.width * 0.9,
                            padding: const EdgeInsets.all(8.0),
                            color: _getColorForResponse(response),
                            child: Text(response.username, style: textStyle),
                          ),
                        ],
                      ),
                    ),
                ],
              ),
          ],
        ),
      ),
    );
  }

  AppBar _getAppbar(BuildContext context) {
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
          const Text("Rückmeldungen",
              style: TextStyle(
                  color: Colors.white, fontFamily: 'rationaldisplay-book')),
          const Text('         ')
        ],
      ),
    );
  }

  Color _getColorForResponse(OperationResponseDto response) {
    switch (response.response) {
      case OperationResponseEnum.Coming:
        return const Color.fromRGBO(60, 174, 43, 1);
      case OperationResponseEnum.Available:
        return const Color.fromRGBO(255, 180, 0, 1);
      case OperationResponseEnum.NotAvailable:
        return const Color.fromRGBO(222, 64, 25, 1);
      default:
        return const Color.fromRGBO(222, 64, 25, 1);
    }
  }

  String _getTitleForResponse(OperationResponseEnum response) {
    switch (response) {
      case OperationResponseEnum.Coming:
        return "Komme";
      case OperationResponseEnum.Available:
        return "Verfügbar";
      case OperationResponseEnum.NotAvailable:
        return "Komme nicht";
      default:
        return "??????";
    }
  }

  Map<OperationResponseEnum, List<OperationResponseDto>> _groupResponsesByEnum(
      List<OperationResponseDto> responses) {
    Map<OperationResponseEnum, List<OperationResponseDto>> groupedResponses = {
      OperationResponseEnum.Coming: [],
      OperationResponseEnum.Available: [],
      OperationResponseEnum.NotAvailable: [],
    };

    for (var response in responses) {
      groupedResponses[response.response]?.add(response);
    }

    return groupedResponses;
  }
}
