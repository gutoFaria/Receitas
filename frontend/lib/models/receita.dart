import 'package:frontend/models/etapa.dart';

import 'ingrediente.dart';

class Receita {
  String titulo;
  String imageUrl;

  List<Ingrediente> ingredientes;
  List<Etapa> etapas;

  Receita(this.titulo, this.imageUrl, this.ingredientes, this.etapas);


  static List<Receita> receitas =[
    Receita(
      "Pizza de Margherita", 
       "https://th.bing.com/th/id/OIP.jblNW-TXQF0K0sGF3APH-gHaE8?w=267&h=180&c=7&r=0&o=5&pid=1.7", 
      [
        Ingrediente(500, "gramas", "Farinha de Trigo"),
        Ingrediente(7,"gramas","Fermento Biológico"),
        Ingrediente(400,"gramas","Tomate Fatiado"),
        Ingrediente(1, "colher de sopa", "Azeite de Oliva"),
        Ingrediente(0.5, "colher de sopa","Orégano"),
        Ingrediente(50, "gramas", "Parmesão"),
        Ingrediente(200, "gramas","Parmesão")
      ], 
      [
        Etapa("Primeiro, faça a massa. Incline a farinha para uma tigela e adicione 300ml de água morna. Misture e reserve à temperatura ambiente durante 1 hora. Dissolva a levedura em 2 colheres de sopa de água e misture esta e 15g de sal através da massa. Cubra com película aderente e deixe em algum lugar quente para dobrar de tamanho por algumas horas. Para um sabor mais azedo, deixe na geladeira por pelo menos 8 horas e até 24 horas – quanto mais tempo você deixar, mais azedo será."),
        Etapa("Quando a massa estiver pronta, incline-a para uma superfície levemente enfarinhada e divida em quatro. Enrole em bolas e deixe descansar, coberto com uma toalha de chá ou filme aderente por mais uma hora."),
        Etapa( "Agora faça o molho de tomate. Escorra um pouco do suco da lata e coloque o resto em uma tigela com o azeite, orégano e uma generosa pitada de sal, em seguida, triture tudo junto com os dedos para um molho volumoso ou blitz com um liquidificador de palito, se você quiser que seja suave. Amarre os talos de manjericão, machuque com as costas de uma faca e coloque no molho. Deixe o molho à temperatura ambiente até que seja necessário."),
        Etapa( "Para fazer a pizza, aqueça uma grelha até o seu cenário mais alto e pegue uma frigideira pesada. Em uma superfície enfarinhada, empurre e estique uma das bolas de massa em um círculo aproximadamente do mesmo tamanho que a frigideira. Coloque a rodada em uma assadeira enfarinhada e cubra com um quarto do molho, uma dispersão de queijo, algumas folhas de manjericão e um quarto da mussarela."),
        Etapa("Pegue a panela bem quente e deslize cuidadosamente a pizza sobre ela. Cozinhe por 2 minutos, depois coloque a panela sob a grelha por mais 2 minutos até que as laterais estejam inchadas e o queijo tenha derretido. Levante em uma prancha, regue com um pouco de azeite, se quiser, depois corte em fatias e sirva enquanto faz a próxima.")
      ]
    ),

    Receita(
      "Pizza supersaudável", 
      "https://th.bing.com/th/id/OIP.Hel2mEKk0szh-6uai4s7GQHaE7?w=235&h=180&c=7&r=0&o=5&pid=1.7", 
      [
        Ingrediente(100, "gramas", "Farinha de trigo"),
        Ingrediente(7, "gramas","Fermento Biológico"),
        Ingrediente( 125,  "ml", "Água morna"),
        Ingrediente(200, "gramas", "Tomate picado"),
        Ingrediente(200, "gramas", "Abrobrinha Fatiada"),
        Ingrediente(25, "gramas", "Mussarela ralada"),
        Ingrediente(1, "colher de chá", "Alcaparras"),
        Ingrediente(8, "de",  "azeitonas verdes "),
        Ingrediente(1, "dente", "de álho"),
        Ingrediente(1, "colher de chá","de azeite"),
        Ingrediente(2, "colher de sopa", "Salsa picada")
      ], 
      [
        Etapa("Misture as farinhas e o fermento com uma pitada de sal em um processador de alimentos equipado com uma lâmina de massa. Despeje na água e misture em uma massa macia, em seguida, trabalhe por 1 min. Retire a massa e enrole em uma superfície levemente enfarinhada até uma volta de cerca de 30 cm de diâmetro. Levante sobre uma assadeira oleada."),
        Etapa( "Espalhe os tomates enlatados sobre a massa a menos de 2 cm das bordas. Disponha os tomates cereja e as aboborinhas por cima, depois espalhe com a mussarela. Misture as alcaparras, as azeitonas e o alho, depois espalhe por cima. Regue uniformemente com o óleo. Deixe levantar por 20 minutos. Aqueça o forno a 240C/ventilador 220C/gás 9 ou a configuração mais alta."),
        Etapa("Asse a pizza por 10-12 minutos até ficar crocante e dourada ao redor das bordas. Espalhe com a salsa para servir."),

      ]
    ),

    Receita(
      "Pizza de frigideira", 
      "https://th.bing.com/th/id/OIP.EZnothEbkm-mopx-RAMaeQAAAA?w=268&h=201&c=7&r=0&o=5&pid=1.7", 
      [
        Ingrediente(1, "pequeno", "Pimentão amarelo fatiado"),
        Ingrediente(1, "pequena","Abrobrinha fatiada"),
        Ingrediente(1, "pequena", "Cebola fatiada em rodelas"),
        Ingrediente(225, "gramas", "Farinha de Trigo"),
        Ingrediente(2, "colher de sopa", "azeite"),
        Ingrediente(5, "colheres de sopa", "molho de tomate"),
        Ingrediente(25,"gramas",  "Queijo chedar")
      ], 
      [
        Etapa("Aqueça o forno a 220C/fan 200C/gas 7. Coloque a pimenta, a abobrinha e a cebola roxa em uma assadeira antiaderente grande e regue com 1 colher de chá de azeite. Tempere bem e jogue para combinar. Asse no forno por 20 minutos até ficar macio e comece a dourar. Reservar."),
        Etapa( "Aqueça a grelha a médio. Tempere bem a farinha e, em uma tigela grande, misture com o óleo restante e 4-5 colheres de sopa de água para formar uma massa macia. Amasse brevemente e, em seguida, enrole em uma superfície enfarinhada em um círculo áspero de 20 cm. Transfira a massa para uma frigideira grande à prova de forno, antiaderente e frite em fogo médio por 5 minutos, até que a parte de baixo comece a dourar. Vire e cozinhe por mais 5 minutos. Espalhe o molho de tomate sobre a base, espalhe com o vegetal assado e, em seguida, polvilhe com cheddar. Grelhar a pizza por 3-4 minutos até que o queijo tenha derretido. Sirva imediatamente, fatiado em fatias, com uma grande salada verde."),

      ]
    ),
  
    Receita(
      "Pizza com molho caseiro", 
       "https://th.bing.com/th/id/OIP.9JBrOnlPio4uwPBtJZelLQHaEx?w=252&h=180&c=7&r=0&o=5&pid=1.7", 
      [
        Ingrediente(300, "gramas", "Farinha de Trigo"),
        Ingrediente(7, "gramas", "Fermento Biológico"),
        Ingrediente(1, "colher de sopa", "de azeite"),
        Ingrediente(2, "dentes", "de alho"),
        Ingrediente(500, "ml", "molho de tomate"),
        Ingrediente(8, "fatias", "mussarela"),
        Ingrediente(1, "cacho", "de manjericão"),
      ], 
      [
        Etapa("Incline a farinha em uma tigela, em seguida, misture o fermento e 1 colher de chá de sal. Faça um poço no centro e despeje 200ml de água morna (certifique-se de que não está muito quente) junto com o óleo. Misture com uma colher de pau até ter uma massa macia e bastante molhada."),
        Etapa( "Incline a massa para fora em uma superfície levemente enfarinhada e amasse por 5 minutos até ficar homogêneo. Cubra com uma toalha de chá e reserve por uma hora ou mais ou menos ou até que a massa tenha inchado e dobrado de tamanho. Você também pode deixar a massa áspera e não amassada na tigela, cobrir com uma toalha de chá e deixar na geladeira durante a noite e a massa continuará a provar por conta própria."),
        Etapa("Enquanto isso, faça o molho de tomate. Coloque o óleo em uma panela pequena e frite o alho brevemente (não deixe dourar), depois adicione a passata e deixe ferver tudo até o molho engrossar um pouco. Deixe esfriar."),
        Etapa("Uma vez que a massa tenha subido, amasse-a rapidamente na tigela para derrubá-la de volta, depois incline-a para uma superfície levemente enfarinhada e corte em duas bolas. Enrole cada bola em uma grande lágrima que seja muito fina e com cerca de 25 cm de diâmetro (as formas de lágrima se encaixam nas assadeiras mais facilmente do que as rodadas)."),
        Etapa("Aqueça o forno a 240C/220C ventilador/gás 9 com uma assadeira grande dentro. Levante uma das bases em outra assadeira enfarinhada. Alise o molho sobre a base com as costas de uma colher, espalhe mais de metade da mussarela, regue com azeite e tempere. Coloque a pizza, ainda em sua assadeira, em cima da folha quente no forno e asse por 8-10 minutos até ficar crocante.")
      ]
    ),
  
    Receita(
      "Pizza de frigideira com berinjela, ricota e hortelã", 
      "https://th.bing.com/th/id/OIP.IhgBRmB3QQ_vutQGkZG0OAHaFj?w=254&h=190&c=7&r=0&o=5&pid=1.7", 
      [
        Ingrediente(200, "gramas", "de farinha de trigo"),
        Ingrediente(0.5, "colher de sopa", "de fermento biológico"),
        Ingrediente(0.25 , "colher de sopa", "Açúcar"),
        Ingrediente(1, "colher de sopa", "de óleo"),
        Ingrediente(4, "colheres de sopa ", "de azeite"),
        Ingrediente(1, "dente", "de álho"),
        Ingrediente(200, "gramas"," molho de tomate"),
        Ingrediente(1, "pequena", "beringela"),
        Ingrediente(100, "gramas", "de ricota"),
        Ingrediente(10, "folhas", "de hortelã"),
        Ingrediente(200, "gramas", "de farinha de trigo")
      ], 
      [
        Etapa("Pese os ingredientes para a massa em uma tigela grande e adicione 1/2 colher de chá de sal e 125ml de água morna. Misture para formar uma massa macia, depois incline para a superfície de trabalho e amasse por 5 minutos ou até que a massa pareça elástica. Limpe e unte a tigela e devolva a massa. Cubra com película aderente e deixe em algum lugar quente para subir por 1 hora, ou até que a massa tenha dobrado de tamanho."),
        Etapa( "Enquanto isso, faça o molho. Aqueça 1 colher de sopa de azeite em uma panela e adicione o alho. Escalfe suavemente por 30 segundos, certificando-se de que o alho não doura e, em seguida, adicione a passata. Tempere bem e borbulhe por 8-10 minutos até ter um molho rico – adicione uma pitada de açúcar se tiver um gosto um pouco azedo demais. Reservar."),
        Etapa("Quando a massa tiver subido, retire o ar e enrole-a em uma base de pizza do mesmo tamanho de uma frigideira grande. Lubrifique a superfície da massa, cubra com filme aderente e, em seguida, deixe na superfície de trabalho por 15 minutos para inchar um pouco. Enquanto isso, aqueça 2 colheres de sopa de óleo na frigideira e adicione as beringelas em uma única camada (você pode ter que cozinhar em lotes). Tempere bem e cozinhe por 4-5 minutos de cada lado até ficar realmente macio e dourado. Transfira para um prato e cubra com papel alumínio para se manter aquecido."),
        Etapa( "Aqueça as 1 colher de sopa restantes de óleo na panela e levante cuidadosamente a massa para dentro dela. Você pode ter que remodelá-lo um pouco para se encaixar. Cozinhe em fogo baixo-médio até que a parte inferior esteja dourada e as bordas da massa estejam começando a parecer secas e ajustadas – isso deve levar cerca de 6 minutos, mas é melhor ir de olho. Vire, regue um pouco mais de óleo ao redor da borda da panela para que ele escorra sob a base da pizza e cozinhe por mais 5-6 minutos até dourar e cozinhar. Reaqueça o molho se precisar e espalhe-o sobre a base. Cubra com as beringelas quentes e pontilhar com colheres de ricota. Espalhe com hortelã e regue com um pouco de azeite extra virgem antes de servir.")
      ]
    )
  ];
}