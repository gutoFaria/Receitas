import 'package:flutter/material.dart';


import '../models/receita.dart';

class ReceitaDetail extends StatefulWidget {
  final Receita receita;
  const ReceitaDetail({super.key,required this.receita});

  @override
  State<ReceitaDetail> createState() => _ReceitaDetailState();
}

class _ReceitaDetailState extends State<ReceitaDetail> {
  
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.receita.titulo),
      ),
      body: SafeArea(
        child: Column(
          children: [
            SizedBox(
              height: 200,
              width: 200,
              child: Image.network(widget.receita.imageUrl,),
            ),
            const Text(
              'Ingredientes',
              style:  TextStyle(
                fontSize: 18,
                color: Colors.white,
                fontWeight: FontWeight.bold
              ),
            ),
            Expanded(
              child: ListView.builder(
                itemCount: widget.receita.ingredientes.length,
                itemBuilder:((context, index) {
                  final ingrediente = widget.receita.ingredientes[index];
                  return Center(
                    child: Text(
                      '${ingrediente.qtd} ${ingrediente.tipo} ${ingrediente.produto}'
                    ),
                  );
                })
              )
            ),
            Expanded(
              child: Center(
                child: ListView.builder(
                  itemCount: widget.receita.etapas.length,
                  itemBuilder: ((context, index) {
                    final etapas = widget.receita.etapas[index];
                    return SingleChildScrollView(
                      padding:const EdgeInsets.all(16.0),
                      scrollDirection: Axis.vertical,
                      child: Column(

                        children: [
                          const SizedBox(height: 10,),
                          Text(
                            'ETAPA ${index + 1}',
                            style: const TextStyle(
                              color: Colors.white,
                              fontWeight: FontWeight.bold,
                              fontSize: 20
                            ),
                          ),
                          Center(
                            
                            child: Text(etapas.descricao,textAlign: TextAlign.center,))
                        ],
                      ),
                    );
                  }),
                ),
              ),
            )
          ],
        ),
      ),
    );
  }
}