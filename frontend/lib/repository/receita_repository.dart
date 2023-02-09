import 'package:dio/dio.dart';

 //import 'dart:convert';
 //import 'package:http/http.dart' show Client;

import '../models/receita.dart';

class ReceitaRepository {
  final dio = Dio();
  final url = 'http://localhost:5098/getallreceitas';

  Future<List<Receita>> fetchReceitas() async {
    final res = await dio.get(url);
    final list = res.data as List;

    List<Receita> listReceita = [];
    for (var json in list) {
      final receita = Receita.fromJson(json);
      listReceita.add(receita);
    }
    print(listReceita);
    return listReceita;
  }

  // final String baseUrl = 'http://localhost:5098/getallreceitas';
  // Client client = Client();

  // Future<List<Receita>> fetchReceitas() async{
  //   final res = await client.get(Uri.parse(baseUrl));
  //   if(res.statusCode == 200){
  //     var json = jsonDecode(res.body);
  //     return json;
  //   }else {
  //     // ignore: null_check_always_fails
  //     return null!;
  //   }
  // }
}
