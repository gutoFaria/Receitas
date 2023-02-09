import 'package:frontend/models/etapa.dart';

import 'ingrediente.dart';

class Receita {
  int? id;
  String? titulo;
  String? imageUrl;
  List<Ingrediente>? listaIngredientes;
  List<Etapa>? listaEtapas;

  Receita(
      {this.id,
      this.titulo,
      this.imageUrl,
      this.listaIngredientes,
      this.listaEtapas});

  Receita.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    titulo = json['titulo'];
    imageUrl = json['imageUrl'];
    if (json['listaIngredientes'] != null) {
      listaIngredientes = <Ingrediente>[];
      json['listaIngredientes'].forEach((v) {
        listaIngredientes!.add(Ingrediente.fromJson(v));
      });
    }
    if (json['listaEtapas'] != null) {
      listaEtapas = <Etapa>[];
      json['listaEtapas'].forEach((v) {
        listaEtapas!.add(Etapa.fromJson(v));
      });
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['titulo'] = titulo;
    data['imageUrl'] = imageUrl;
    if (listaIngredientes != null) {
      data['listaIngredientes'] =
          listaIngredientes!.map((v) => v.toJson()).toList();
    }
    if (listaEtapas != null) {
      data['listaEtapas'] = listaEtapas!.map((v) => v.toJson()).toList();
    }
    return data;
  }
}