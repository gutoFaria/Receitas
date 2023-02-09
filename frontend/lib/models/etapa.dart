class Etapa {
  int? id;
  String? descricao;
  int? receitaId;

  Etapa({this.id, this.descricao, this.receitaId});

  Etapa.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    descricao = json['descricao'];
    receitaId = json['receitaId'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['id'] = this.id;
    data['descricao'] = this.descricao;
    data['receitaId'] = this.receitaId;
    return data;
  }
}