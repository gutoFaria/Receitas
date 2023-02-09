import 'package:flutter/material.dart';
import 'package:frontend/screens/home_page.dart';

import 'repository/temas.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    final theme = Temas.dark();
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      theme: theme,
      home:const HomePage(title: "Receitas",),
    );
  }
}



