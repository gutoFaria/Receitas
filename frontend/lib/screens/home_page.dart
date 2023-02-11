import 'package:flutter/material.dart';
import 'package:frontend/screens/receita_detail.dart';

import '../models/receita.dart';


class HomePage extends StatefulWidget {
  const HomePage({super.key, required this.title});

  final String title;

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  
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
      body: Center(
        child: ListView.builder(
          itemCount:Receita.receitas.length,
          itemBuilder: (context, index) {
            return GestureDetector(
              onTap: (){
                Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context){
                      return ReceitaDetail(receita:Receita.receitas[index]);
                    }
                  )
                );
              },
              child: receitaCard(Receita.receitas[index]),
            );
          }),
      ),
    );
  }

  Widget receitaCard(Receita receita){
    return Card(
      elevation: 2.0,
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(10.0)
      ),
      child: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          children: [
            Image.network(receita.imageUrl),
            const SizedBox(height: 14.0,),
            Text(receita.titulo,
            style: const TextStyle(
              fontSize: 20,
              fontWeight: FontWeight.w700,
              fontFamily: 'Palatino',
              color: Colors.white
            ),
            )
          ],
        ),
      ),
    );
  }
}
