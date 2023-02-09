using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitulodaReceita = table.Column<string>(name: "Titulo da Receita", type: "TEXT", nullable: false),
                    ImagemUrl = table.Column<string>(name: "Imagem Url", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Etapas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    ReceitaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etapas_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantidade = table.Column<double>(type: "REAL", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    NomedoProduto = table.Column<string>(name: "Nome do Produto", type: "TEXT", nullable: false),
                    ReceitaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredientes_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Receitas",
                columns: new[] { "Id", "Imagem Url", "Titulo da Receita" },
                values: new object[,]
                {
                    { 1, "https://th.bing.com/th/id/OIP.jblNW-TXQF0K0sGF3APH-gHaE8?w=267&h=180&c=7&r=0&o=5&pid=1.7", "Pizza de Margherita" },
                    { 2, "https://th.bing.com/th/id/OIP.Hel2mEKk0szh-6uai4s7GQHaE7?w=235&h=180&c=7&r=0&o=5&pid=1.7", "Pizza supersaudável" },
                    { 3, "https://th.bing.com/th/id/OIP.EZnothEbkm-mopx-RAMaeQAAAA?w=268&h=201&c=7&r=0&o=5&pid=1.7", "Pizza de frigideira" },
                    { 4, "https://th.bing.com/th/id/OIP.9JBrOnlPio4uwPBtJZelLQHaEx?w=252&h=180&c=7&r=0&o=5&pid=1.7", "Pizza com molho caseiro" },
                    { 5, "https://th.bing.com/th/id/OIP.IhgBRmB3QQ_vutQGkZG0OAHaFj?w=254&h=190&c=7&r=0&o=5&pid=1.7", "Pizza de frigideira com berinjela, ricota e hortelã" }
                });

            migrationBuilder.InsertData(
                table: "Etapas",
                columns: new[] { "Id", "Descricao", "ReceitaId" },
                values: new object[,]
                {
                    { 1, "Primeiro, faça a massa. Incline a farinha para uma tigela e adicione 300ml de água morna. Misture e reserve à temperatura ambiente durante 1 hora. Dissolva a levedura em 2 colheres de sopa de água e misture esta e 15g de sal através da massa. Cubra com película aderente e deixe em algum lugar quente para dobrar de tamanho por algumas horas. Para um sabor mais azedo, deixe na geladeira por pelo menos 8 horas e até 24 horas – quanto mais tempo você deixar, mais azedo será.", 1 },
                    { 2, "Quando a massa estiver pronta, incline-a para uma superfície levemente enfarinhada e divida em quatro. Enrole em bolas e deixe descansar, coberto com uma toalha de chá ou filme aderente por mais uma hora.", 1 },
                    { 3, "Agora faça o molho de tomate. Escorra um pouco do suco da lata e coloque o resto em uma tigela com o azeite, orégano e uma generosa pitada de sal, em seguida, triture tudo junto com os dedos para um molho volumoso ou blitz com um liquidificador de palito, se você quiser que seja suave. Amarre os talos de manjericão, machuque com as costas de uma faca e coloque no molho. Deixe o molho à temperatura ambiente até que seja necessário.", 1 },
                    { 4, "Para fazer a pizza, aqueça uma grelha até o seu cenário mais alto e pegue uma frigideira pesada. Em uma superfície enfarinhada, empurre e estique uma das bolas de massa em um círculo aproximadamente do mesmo tamanho que a frigideira. Coloque a rodada em uma assadeira enfarinhada e cubra com um quarto do molho, uma dispersão de queijo, algumas folhas de manjericão e um quarto da mussarela.", 1 },
                    { 5, "Pegue a panela bem quente e deslize cuidadosamente a pizza sobre ela. Cozinhe por 2 minutos, depois coloque a panela sob a grelha por mais 2 minutos até que as laterais estejam inchadas e o queijo tenha derretido. Levante em uma prancha, regue com um pouco de azeite, se quiser, depois corte em fatias e sirva enquanto faz a próxima.", 1 },
                    { 6, "Misture as farinhas e o fermento com uma pitada de sal em um processador de alimentos equipado com uma lâmina de massa. Despeje na água e misture em uma massa macia, em seguida, trabalhe por 1 min. Retire a massa e enrole em uma superfície levemente enfarinhada até uma volta de cerca de 30 cm de diâmetro. Levante sobre uma assadeira oleada.", 2 },
                    { 7, "Espalhe os tomates enlatados sobre a massa a menos de 2 cm das bordas. Disponha os tomates cereja e as aboborinhas por cima, depois espalhe com a mussarela. Misture as alcaparras, as azeitonas e o alho, depois espalhe por cima. Regue uniformemente com o óleo. Deixe levantar por 20 minutos. Aqueça o forno a 240C/ventilador 220C/gás 9 ou a configuração mais alta.", 2 },
                    { 8, "Asse a pizza por 10-12 minutos até ficar crocante e dourada ao redor das bordas. Espalhe com a salsa para servir.", 2 },
                    { 9, "Aqueça o forno a 220C/fan 200C/gas 7. Coloque a pimenta, a abobrinha e a cebola roxa em uma assadeira antiaderente grande e regue com 1 colher de chá de azeite. Tempere bem e jogue para combinar. Asse no forno por 20 minutos até ficar macio e comece a dourar. Reservar.", 3 },
                    { 10, "Aqueça a grelha a médio. Tempere bem a farinha e, em uma tigela grande, misture com o óleo restante e 4-5 colheres de sopa de água para formar uma massa macia. Amasse brevemente e, em seguida, enrole em uma superfície enfarinhada em um círculo áspero de 20 cm. Transfira a massa para uma frigideira grande à prova de forno, antiaderente e frite em fogo médio por 5 minutos, até que a parte de baixo comece a dourar. Vire e cozinhe por mais 5 minutos. Espalhe o molho de tomate sobre a base, espalhe com o vegetal assado e, em seguida, polvilhe com cheddar. Grelhar a pizza por 3-4 minutos até que o queijo tenha derretido. Sirva imediatamente, fatiado em fatias, com uma grande salada verde.", 3 },
                    { 11, "Incline a farinha em uma tigela, em seguida, misture o fermento e 1 colher de chá de sal. Faça um poço no centro e despeje 200ml de água morna (certifique-se de que não está muito quente) junto com o óleo. Misture com uma colher de pau até ter uma massa macia e bastante molhada.", 4 },
                    { 12, "Incline a massa para fora em uma superfície levemente enfarinhada e amasse por 5 minutos até ficar homogêneo. Cubra com uma toalha de chá e reserve por uma hora ou mais ou menos ou até que a massa tenha inchado e dobrado de tamanho. Você também pode deixar a massa áspera e não amassada na tigela, cobrir com uma toalha de chá e deixar na geladeira durante a noite e a massa continuará a provar por conta própria.", 4 },
                    { 13, "Enquanto isso, faça o molho de tomate. Coloque o óleo em uma panela pequena e frite o alho brevemente (não deixe dourar), depois adicione a passata e deixe ferver tudo até o molho engrossar um pouco. Deixe esfriar.", 4 },
                    { 14, "Uma vez que a massa tenha subido, amasse-a rapidamente na tigela para derrubá-la de volta, depois incline-a para uma superfície levemente enfarinhada e corte em duas bolas. Enrole cada bola em uma grande lágrima que seja muito fina e com cerca de 25 cm de diâmetro (as formas de lágrima se encaixam nas assadeiras mais facilmente do que as rodadas).", 4 },
                    { 15, "Aqueça o forno a 240C/220C ventilador/gás 9 com uma assadeira grande dentro. Levante uma das bases em outra assadeira enfarinhada. Alise o molho sobre a base com as costas de uma colher, espalhe mais de metade da mussarela, regue com azeite e tempere. Coloque a pizza, ainda em sua assadeira, em cima da folha quente no forno e asse por 8-10 minutos até ficar crocante.", 4 },
                    { 16, "Pese os ingredientes para a massa em uma tigela grande e adicione 1/2 colher de chá de sal e 125ml de água morna. Misture para formar uma massa macia, depois incline para a superfície de trabalho e amasse por 5 minutos ou até que a massa pareça elástica. Limpe e unte a tigela e devolva a massa. Cubra com película aderente e deixe em algum lugar quente para subir por 1 hora, ou até que a massa tenha dobrado de tamanho.", 5 },
                    { 17, "Enquanto isso, faça o molho. Aqueça 1 colher de sopa de azeite em uma panela e adicione o alho. Escalfe suavemente por 30 segundos, certificando-se de que o alho não doura e, em seguida, adicione a passata. Tempere bem e borbulhe por 8-10 minutos até ter um molho rico – adicione uma pitada de açúcar se tiver um gosto um pouco azedo demais. Reservar.", 5 },
                    { 18, "Quando a massa tiver subido, retire o ar e enrole-a em uma base de pizza do mesmo tamanho de uma frigideira grande. Lubrifique a superfície da massa, cubra com filme aderente e, em seguida, deixe na superfície de trabalho por 15 minutos para inchar um pouco. Enquanto isso, aqueça 2 colheres de sopa de óleo na frigideira e adicione as beringelas em uma única camada (você pode ter que cozinhar em lotes). Tempere bem e cozinhe por 4-5 minutos de cada lado até ficar realmente macio e dourado. Transfira para um prato e cubra com papel alumínio para se manter aquecido.", 5 },
                    { 19, "Aqueça as 1 colher de sopa restantes de óleo na panela e levante cuidadosamente a massa para dentro dela. Você pode ter que remodelá-lo um pouco para se encaixar. Cozinhe em fogo baixo-médio até que a parte inferior esteja dourada e as bordas da massa estejam começando a parecer secas e ajustadas – isso deve levar cerca de 6 minutos, mas é melhor ir de olho. Vire, regue um pouco mais de óleo ao redor da borda da panela para que ele escorra sob a base da pizza e cozinhe por mais 5-6 minutos até dourar e cozinhar. Reaqueça o molho se precisar e espalhe-o sobre a base. Cubra com as beringelas quentes e pontilhar com colheres de ricota. Espalhe com hortelã e regue com um pouco de azeite extra virgem antes de servir.", 5 }
                });

            migrationBuilder.InsertData(
                table: "Ingredientes",
                columns: new[] { "Id", "Nome do Produto", "Quantidade", "ReceitaId", "Tipo" },
                values: new object[,]
                {
                    { 1, "Farinha de Trigo", 500.0, 1, "gramas" },
                    { 2, "Fermento Biológico", 7.0, 1, "gramas" },
                    { 3, "Tomate Fatiado", 400.0, 1, "gramas" },
                    { 4, "Azeite de Oliva", 1.0, 1, "colher de sopa" },
                    { 5, "Orégano", 0.5, 1, "colher de sopa" },
                    { 6, "Parmesão", 50.0, 1, "gramas" },
                    { 7, "Mussarela em pedaços", 200.0, 1, "gramas" },
                    { 8, "Farinha", 100.0, 2, "gramas" },
                    { 9, "Fermento Biológico", 7.0, 2, "gramas" },
                    { 10, "Água morna", 125.0, 2, "ml" },
                    { 11, "Tomate picado", 200.0, 2, "gramas" },
                    { 12, "Abrobrinha Fatiada", 200.0, 2, "gramas" },
                    { 13, "Mussarela ralada", 25.0, 2, "gramas" },
                    { 14, "Alcaparras", 1.0, 2, "colher de chá" },
                    { 15, "Azeitonas verdes ", 8.0, 2, "" },
                    { 16, "de álho", 1.0, 2, "dente" },
                    { 17, "azeite", 1.0, 2, "colher de chá" },
                    { 18, "Salsa picada", 2.0, 2, "colher de sopa" },
                    { 19, "Pimentão amarelo fatiado", 1.0, 3, "" },
                    { 20, "Abrobrinha fatiada", 1.0, 3, "" },
                    { 21, "Cebola fatiada em rodelas", 1.0, 3, "" },
                    { 22, "Farinha de Trigo", 225.0, 3, "gramas" },
                    { 23, "Azeite", 2.0, 3, "colher de sopa" },
                    { 24, "molho de tomate", 5.0, 3, "colheres de sopa" },
                    { 25, "Queijo chedar", 25.0, 3, "gramas" },
                    { 26, "Farinha de Trigo", 300.0, 4, "gramas" },
                    { 27, "Fermento Biológico", 7.0, 4, "gramas" },
                    { 28, "Azeite", 1.0, 4, "colher de sopa" },
                    { 29, "de Alho", 2.0, 4, "dentes" },
                    { 30, "passata", 200.0, 4, "ml" },
                    { 31, "mussarela", 8.0, 4, "fatias" },
                    { 32, "de manjericão", 1.0, 4, "cacho" },
                    { 33, "Farinha de trigo", 200.0, 5, "gramas" },
                    { 34, "Fermento biológico", 0.5, 5, "colher de sopa" },
                    { 35, "Açúcar", 0.25, 5, "colher de sopa" },
                    { 36, "de óleo", 1.0, 5, "colher de sopa" },
                    { 37, "de azeite", 4.0, 5, "colheres de sopa " },
                    { 38, "de álho", 1.0, 5, "dente" },
                    { 39, "passata", 200.0, 5, "gramas" },
                    { 40, "beringela", 1.0, 5, "" },
                    { 41, "ricota", 100.0, 5, "gramas" },
                    { 42, "de hortelã", 10.0, 5, "folhas" },
                    { 43, "Farinha de trigo", 200.0, 5, "gramas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etapas_ReceitaId",
                table: "Etapas",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_ReceitaId",
                table: "Ingredientes",
                column: "ReceitaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etapas");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
