import 'package:flutter/material.dart';

import 'package:flutter/material.dart';

// list all files
import 'dart:io';
// file diolog
import 'directory_selector.dart';

class DirectoryTreeView extends StatelessWidget {
  const DirectoryTreeView({super.key});

  

  @override
  Widget build(BuildContext context) {
    return Container(
      width: MediaQuery.of(context).size.width * 0.15,
      color: Colors.red,
      // child: Column(
        // children: [
          // DirectorySelector(),
          // ElevatedButton(onPressed: onPressed, child: child)
          // FutureText(),
        // ],
      // ),

      child: DirectorySelector(),
      // child: FutureText(),
    );
  }
}

class FutureText extends StatefulWidget {
  const FutureText({super.key});

  @override
  State<FutureText> createState() => _FutureTextState();
}

class _FutureTextState extends State<FutureText> {
  @override
  final Future<String> _calculation = Future<String>.delayed(
    const Duration(seconds: 2),
    () => 'Data Loaded',
  );

  // final Future<String> val = CurrentDir();

  Future<List<String>> allCurrentFiles(Directory pat) async {
    List<String> res = [];
    await for (var v in pat.list()) {
      // print(v);
      res.add(v.path);
    }

    // print(res);
    return res;
  }

  Widget build(BuildContext context) {
    return Container(
      width: MediaQuery.of(context).size.width * 0.15,
      color: Colors.red,
      child: FutureBuilder(
        future: allCurrentFiles(Directory("/")),
        builder: ((context, snapshot) {
          Widget str;
          if (snapshot.connectionState == ConnectionState.waiting) {
            str = Text("loading");
          } else if (snapshot.hasData) {
            // str = Text(snapshot.data as String);
            // print( (snapshot.data==null ? snapshot.data:"Null error"));
            print(snapshot.data);
            str = ListView.builder(
              itemCount: snapshot.data!.length,
              prototypeItem: ListTile(
                title: Text(snapshot.data!.first),
              ),
              itemBuilder: (context, index) {
                return ListTile(
                  title: Text(snapshot.data![index]),
                );
              },
            );
          } else {
            str = Text("OK");
          }

          return str;
        }),
      ),
    );
  }
}
