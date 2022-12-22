import 'package:flutter/material.dart';

class NormalScreenLayout extends StatelessWidget {
  const NormalScreenLayout({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Row(children: [
        Container(
          width: MediaQuery.of(context).size.width * 0.15,
          color: Colors.red,
        ),
        Container(
          width: MediaQuery.of(context).size.width * 0.65,
          child: SingleChildScrollView(
            child: Column(
              children: [
                Container(
                  color: Colors.red,
                ),
              ],
            ),
          ),
        ),
        Container(
          width: MediaQuery.of(context).size.width * 0.2,
          color: Colors.yellow,
        )
      ]),
    );
  }
}
