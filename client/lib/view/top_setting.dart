import 'package:flutter/material.dart';

class TopSetting extends StatelessWidget {
  const TopSetting({super.key});

  @override
  Widget build(BuildContext context) {
    return Container(
      height: MediaQuery.of(context).size.height * 0.03,
      color: Colors.green,
    );
  }
}