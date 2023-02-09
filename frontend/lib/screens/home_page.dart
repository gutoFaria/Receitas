import 'package:flutter/material.dart';
import 'package:frontend/models/receita.dart';
import 'package:dio/dio.dart';
import 'package:frontend/screens/receita_detail.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key, required this.title});

  final String title;

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  List<Receita> listaReceita = List<Receita>.empty(growable: true);
  @override
  void initState() {
    super.initState();
    final dio = Dio();
    const url = 'http://localhost:5098/getallreceitas';

    // ignore: unused_element
    Future<List<Receita>> fetchReceitas() async {
      final res = await dio.get(url);
      final list = res.data as List;

      //List<Receita> listReceita = [];
      for (var json in list) {
        final receita = Receita.fromJson(json);
        listaReceita.add(receita);
      }

      return listaReceita;
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        centerTitle: true,
        title: Text(
          widget.title,
          style:
              const TextStyle(color: Colors.white, fontWeight: FontWeight.bold),
        ),
      ),
      body: ListView.builder(
        itemCount: listaReceita.length,
        itemBuilder: (context, index) {
          return GestureDetector(
            onTap: (){
              Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (context){
                    return ReceitaDetail(receita: listaReceita[index]);
                  }
                )
              );
            },
          );
        }),
    );
  }
}
