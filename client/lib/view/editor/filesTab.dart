import 'package:flutter/material.dart';

class FilesTab extends StatelessWidget {
  const FilesTab({super.key});

  @override
  Widget build(BuildContext context) {
    return Container(
      alignment: Alignment.topCenter,
      height: MediaQuery.of(context).size.height * 0.04,
      color: Color.fromARGB(255, 5, 83, 11),
    );
  }
}
