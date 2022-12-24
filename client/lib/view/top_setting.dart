import 'package:flutter/material.dart';

import 'package:file_picker/file_picker.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

import 'package:client/colors.dart';

class TopSetting extends StatelessWidget {
  const TopSetting({super.key});

  @override
  Widget build(BuildContext context) {
    return Container(
      height: 25,
      color: Colors.green,
      child: DirectorySelector(),
    );
  }
}

class DirectorySelector extends StatefulWidget {
  @override
  _DirectorySelectorState createState() => _DirectorySelectorState();
}

class _DirectorySelectorState extends State<DirectorySelector> {
  final GlobalKey<ScaffoldState> _scaffoldKey = GlobalKey<ScaffoldState>();
  final _scaffoldMessengerKey = GlobalKey<ScaffoldMessengerState>();
  String? _fileName;
  String? _saveAsFileName;
  List<PlatformFile>? _paths;
  String? _directoryPath;
  String? _extension;
  bool _isLoading = false;
  bool _userAborted = false;
  bool _multiPick = false;
  FileType _pickingType = FileType.any;
  TextEditingController _controller = TextEditingController();

  @override
  void initState() {
    super.initState();
    _controller.addListener(() => _extension = _controller.text);
  }

  void _pickFiles() async {
    _resetState();
    try {
      _directoryPath = null;
      _paths = (await FilePicker.platform.pickFiles(
        type: _pickingType,
        allowMultiple: _multiPick,
        onFileLoading: (FilePickerStatus status) => print(status),
        allowedExtensions: (_extension?.isNotEmpty ?? false)
            ? _extension?.replaceAll(' ', '').split(',')
            : null,
      ))
          ?.files;
    } on PlatformException catch (e) {
      _logException('Unsupported operation' + e.toString());
    } catch (e) {
      _logException(e.toString());
    }
    if (!mounted) return;
    setState(() {
      _isLoading = false;
      _fileName =
          _paths != null ? _paths!.map((e) => e.name).toString() : '...';
      _userAborted = _paths == null;
    });
  }

  void _selectFolder() async {
    _resetState();
    try {
      String? path = await FilePicker.platform.getDirectoryPath();
      setState(() {
        _directoryPath = path;
        _userAborted = path == null;
      });
    } on PlatformException catch (e) {
      _logException('Unsupported operation' + e.toString());
    } catch (e) {
      _logException(e.toString());
    } finally {
      setState(() => _isLoading = false);
    }
  }

  Future<void> _saveFile() async {
    _resetState();
    try {
      String? fileName = await FilePicker.platform.saveFile(
        allowedExtensions: (_extension?.isNotEmpty ?? false)
            ? _extension?.replaceAll(' ', '').split(',')
            : null,
        type: _pickingType,
      );
      setState(() {
        _saveAsFileName = fileName;
        _userAborted = fileName == null;
      });
    } on PlatformException catch (e) {
      _logException('Unsupported operation' + e.toString());
    } catch (e) {
      _logException(e.toString());
    } finally {
      setState(() => _isLoading = false);
    }
  }

  void _logException(String message) {
    print(message);
    _scaffoldMessengerKey.currentState?.hideCurrentSnackBar();
    _scaffoldMessengerKey.currentState?.showSnackBar(
      SnackBar(
        content: Text(message),
      ),
    );
  }

  void _resetState() {
    if (!mounted) {
      return;
    }
    setState(() {
      _isLoading = true;
      _directoryPath = null;
      _fileName = null;
      _paths = null;
      _saveAsFileName = null;
      _userAborted = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      color: Colors.red,
      child: Column(
        mainAxisAlignment: MainAxisAlignment.start,
        children: <Widget>[
          Container(
            child: Row(
              children: <Widget>[
                IconButton(
                  padding: EdgeInsets.only(top: 0 , bottom: 0),
                  constraints: BoxConstraints(),
                  icon: Icon(
                    Icons.file_open,
                    size: 15,
                  ),
                  onPressed: () => _pickFiles(),
                  splashRadius: 15,
                ),
                IconButton(
                  padding: EdgeInsets.only(top: 0 , bottom: 0),
                  constraints: BoxConstraints(),
                  icon: Icon(
                    Icons.folder_open,
                    size: 15,
                  ),
                  onPressed: () => _selectFolder(),
                  splashRadius: 15,
                ),
                IconButton(
                  padding: EdgeInsets.only(top: 0 , bottom: 0),
                  constraints: BoxConstraints(),
                  icon: Icon(
                    Icons.save,
                    size: 15,
                  ),
                  onPressed: () => _saveFile(),
                  splashRadius: 15,
                ),
                IconButton(
                  padding: EdgeInsets.only(top: 0 , bottom: 0),
                  constraints: BoxConstraints(),
                  icon: Icon(
                    Icons.create_new_folder,
                    size: 15,
                  ),
                  onPressed: () => _saveFile(),
                  splashRadius: 15,
                ),
                IconButton(
                  padding: EdgeInsets.only(top: 0 , bottom: 0),
                  constraints: BoxConstraints(),
                  icon: Icon(
                    Icons.difference,
                    size: 15,
                  ),
                  onPressed: () => _saveFile(),
                  splashRadius: 15,
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
