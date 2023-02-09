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
        title: Text(widget.receita.titulo!),
      ),
      body: SafeArea(
        child: Column(
          children: [
            SizedBox(
              height: 300,
              width: double.infinity,
              child: Image.network(widget.receita.imageUrl!,),
            ),
            const SizedBox(height: 4,),
            Text(
              widget.receita.titulo!,
              style: const TextStyle(
                fontSize: 18,
                color: Colors.white,
                fontWeight: FontWeight.bold
              ),
            ),
            Expanded(
              child: ListView.builder(
                itemCount: widget.receita.listaIngredientes?.length,
                itemBuilder:((context, index) {
                  final ingrediente = widget.receita.listaIngredientes![index];
                  return Text(
                    '${ingrediente.qtd} ${ingrediente.tipo} ${ingrediente.produto}'
                  );
                })
              )
            ),
            Expanded(
              child: ListView.builder(
                itemCount: widget.receita.listaEtapas!.length,
                itemBuilder: ((context, index) {
                  final etapas = widget.receita.listaEtapas![index];

                  return Column(
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
                      const SizedBox(height: 10,),
                      Text('$etapas')
                    ],
                  );
                }),
              ),
            )
          ],
        ),
      ),
    );
  }
}