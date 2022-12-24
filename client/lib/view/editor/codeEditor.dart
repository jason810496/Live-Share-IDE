import 'package:flutter/material.dart';
import 'package:code_text_field/code_text_field.dart';
// Import the language & theme
import 'package:highlight/languages/cpp.dart';
import 'package:flutter_highlight/themes/monokai-sublime.dart';
import 'package:flutter_highlight/themes/darcula.dart';
import 'package:flutter_highlight/themes/atom-one-dark.dart';

class CodeEditor extends StatefulWidget {
  @override
  _CodeEditorState createState() => _CodeEditorState();
}

class _CodeEditorState extends State<CodeEditor> {
  CodeController? _codeController;

  @override
  void initState() {
    super.initState();
    final source =
        "#include<iostream>\nusing namespace std;\nint main() {\n    cout<<\"Hello, world!\";\n}";
    // Instantiate the CodeController
    _codeController = CodeController(
      text: source,
      language: cpp,
      // theme: monokaiSublimeTheme,
    );
  }

  @override
  void dispose() {
    _codeController?.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return CodeTheme(
      child: CodeField(
        minLines: 30,
        maxLines: 30,
        controller: _codeController!,
        textStyle: TextStyle(fontFamily: 'SourceCode'),
      ),
      data: const CodeThemeData(styles: atomOneDarkTheme),
    );
  }
}
