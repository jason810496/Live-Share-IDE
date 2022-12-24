import 'package:flutter/material.dart';
// main screen
import 'package:client/view/editor/editor.dart';
import 'package:client/view/directory/directory.dart';
import 'package:client/view/chat/chat.dart';

import 'package:client/view/top_setting.dart';

class NormalScreenLayout extends StatelessWidget {
  const NormalScreenLayout({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Column(
        children: [
          TopSetting(),
          Expanded(
            // main screen
            child: Row(children: [
              DirectoryTreeView(),
              EditorView(),
              ChatView(),
            ]),
          ),
        ],
      ),
    );
  }
}
