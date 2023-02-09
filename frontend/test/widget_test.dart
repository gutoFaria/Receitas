



import 'package:flutter_test/flutter_test.dart';
import 'package:frontend/repository/receita_repository.dart';

void main() {
 final repo = ReceitaRepository();

 test("trazer lista de receitas", () async{
  final list  = repo.fetchReceitas();
  print(list);
 });
}
