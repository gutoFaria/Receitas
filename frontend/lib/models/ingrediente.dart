class Ingrediente {
  int? id;
  int? qtd;
  String? tipo;
  String? produto;
  int? receitaId;

  Ingrediente({this.id, this.qtd, this.tipo, this.produto, this.receitaId});

  Ingrediente.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    qtd = json['qtd'];
    tipo = json['tipo'];
    produto = json['produto'];
    receitaId = json['receitaId'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['qtd'] = qtd;
    data['tipo'] = tipo;
    data['produto'] = produto;
    data['receitaId'] = receitaId;
    return data;
  }
}