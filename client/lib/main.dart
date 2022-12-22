import 'package:flutter/material.dart';
import 'rwd.dart';
import 'colors.dart';
import 'screens/mobile_screen.dart';
import 'screens/normal_screen.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'LiveShareIDE',
      theme: ThemeData.dark().copyWith(
        backgroundColor: backgroundColor,
      ),
      home: const ResponsiveLayout(
        mobileScreenLayout:  MobileScreenlayout() , 
        normalScreenLayout:  NormalScreenLayout() ,
      ),
    );
  }
}
