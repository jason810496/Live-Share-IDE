import 'package:flutter/material.dart';
import 'codeEditor.dart';

class EditorView extends StatelessWidget {
  const EditorView({super.key});

  @override
  Widget build(BuildContext context) {
    return Container(
      width: MediaQuery.of(context).size.width * 0.65,
      child: SingleChildScrollView(
        child: Column(
          children: [
            Container(
              color: Colors.red,
            ),
            CodeEditor(),
          ],
        ),
      ),
    );
  }
}
