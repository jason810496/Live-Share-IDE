import 'package:flutter/material.dart';

class ResponsiveLayout extends StatelessWidget {
  final Widget mobileScreenLayout;
  final Widget normalScreenLayout;
  const ResponsiveLayout(
      {Key? key,
      required this.mobileScreenLayout,
      required this.normalScreenLayout})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return LayoutBuilder(
      builder: (context, constrains) {
        if (constrains.maxWidth > 300) {
          // web screen
          return normalScreenLayout;
        }
        // mobile screen
        return mobileScreenLayout;
      },
    );
  }
}
