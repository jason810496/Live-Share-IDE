import 'package:flutter/material.dart';
import 'codeEditor.dart';
import 'filesTab.dart';

class EditorView extends StatelessWidget {
  const EditorView({super.key});

  @override
  Widget build(BuildContext context) {
    
    return Container(
      alignment: Alignment.topCenter,
      width: MediaQuery.of(context).size.width * 0.65,
      child: Column(
        children: [
          FilesTab(),
          CodeEditor(),
      ],),
    );
  }
}
