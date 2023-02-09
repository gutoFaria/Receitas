using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Receita> Receitas => Set<Receita>();
        public DbSet<Ingrediente> Ingredientes => Set<Ingrediente>();
        public DbSet<Etapa> Etapas => Set<Etapa>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receita>().HasData
            (
                new Receita
                {
                    Id = 1,
                    Titulo = "Pizza de Margherita",
                    ImageUrl = "https://th.bing.com/th/id/OIP.jblNW-TXQF0K0sGF3APH-gHaE8?w=267&h=180&c=7&r=0&o=5&pid=1.7",
                },
                new Receita
                {
                    Id = 2,
                    Titulo = "Pizza supersaudável",
                    ImageUrl = "https://th.bing.com/th/id/OIP.Hel2mEKk0szh-6uai4s7GQHaE7?w=235&h=180&c=7&r=0&o=5&pid=1.7",
                },
                new Receita
                {
                    Id = 3,
                    Titulo = "Pizza de frigideira",
                    ImageUrl = "https://th.bing.com/th/id/OIP.EZnothEbkm-mopx-RAMaeQAAAA?w=268&h=201&c=7&r=0&o=5&pid=1.7"
                },
                new Receita
                {
                    Id = 4,
                    Titulo = "Pizza com molho caseiro",
                    ImageUrl = "https://th.bing.com/th/id/OIP.9JBrOnlPio4uwPBtJZelLQHaEx?w=252&h=180&c=7&r=0&o=5&pid=1.7"
                },
                new Receita
                {
                    Id = 5,
                    Titulo = "Pizza de frigideira com berinjela, ricota e hortelã",
                    ImageUrl = "https://th.bing.com/th/id/OIP.IhgBRmB3QQ_vutQGkZG0OAHaFj?w=254&h=190&c=7&r=0&o=5&pid=1.7"
                }
            );

            modelBuilder.Entity<Ingrediente>().HasData
            (
                #region INGREDIENTES DA PIZZA DE MARGHERITA
                new Ingrediente
                {
                    Id = 1,
                    Qtd = 500,
                    Tipo = "gramas",
                    Produto = "Farinha de Trigo",
                    ReceitaId = 1
                },

                new Ingrediente
                {
                    Id = 2,
                    Qtd = 7,
                    Tipo = "gramas",
                    Produto = "Fermento Biológico",
                    ReceitaId = 1
                },
                new Ingrediente
                {
                    Id = 3,
                    Qtd = 400,
                    Tipo = "gramas",
                    Produto = "Tomate Fatiado",
                    ReceitaId = 1
                },
                new Ingrediente
                {
                    Id = 4,
                    Qtd = 1,
                    Tipo = "colher de sopa",
                    Produto = "Azeite de Oliva",
                    ReceitaId = 1
                },
                new Ingrediente
                {
                    Id = 5,
                    Qtd = 0.5,
                    Tipo = "colher de sopa",
                    Produto = "Orégano",
                    ReceitaId = 1
                },
                new Ingrediente
                {
                    Id = 6,
                    Qtd = 50,
                    Tipo = "gramas",
                    Produto = "Parmesão",
                    ReceitaId = 1
                },
                new Ingrediente
                {
                    Id = 7,
                    Qtd = 200,
                    Tipo = "gramas",
                    Produto = "Mussarela em pedaços",
                    ReceitaId = 1
                },
                #endregion

                #region INGREDIENTES DA PIZZA SUPERSAUDAVEL
                new Ingrediente
                {
                    Id = 8,
                    Qtd = 100,
                    Tipo = "gramas",
                    Produto = "Farinha",
                    ReceitaId = 2
                },

                new Ingrediente
                {
                    Id = 9,
                    Qtd = 7,
                    Tipo = "gramas",
                    Produto = "Fermento Biológico",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 10,
                    Qtd = 125,
                    Tipo = "ml",
                    Produto = "Água morna",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 11,
                    Qtd = 200,
                    Tipo = "gramas",
                    Produto = "Tomate picado",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 12,
                    Qtd = 200,
                    Tipo = "gramas",
                    Produto = "Abrobrinha Fatiada",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 13,
                    Qtd = 25,
                    Tipo = "gramas",
                    Produto = "Mussarela ralada",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 14,
                    Qtd = 1,
                    Tipo = "colher de chá",
                    Produto = "Alcaparras",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 15,
                    Qtd = 8,
                    Tipo = "",
                    Produto = "Azeitonas verdes ",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 16,
                    Qtd = 1,
                    Tipo = "dente",
                    Produto = "de álho",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 17,
                    Qtd = 1,
                    Tipo = "colher de chá",
                    Produto = "azeite",
                    ReceitaId = 2
                },
                new Ingrediente
                {
                    Id = 18,
                    Qtd = 2,
                    Tipo = "colher de sopa",
                    Produto = "Salsa picada",
                    ReceitaId = 2
                },
                #endregion
            
                #region INGREDIENTES DA PIZZA DE FRIGIDEIRA
                new Ingrediente
                {
                    Id = 19,
                    Qtd = 1,
                    Tipo = "",
                    Produto = "Pimentão amarelo fatiado",
                    ReceitaId = 3
                },
                new Ingrediente
                {
                    Id = 20,
                    Qtd = 1,
                    Tipo = "",
                    Produto = "Abrobrinha fatiada",
                    ReceitaId = 3
                },
                new Ingrediente
                {
                    Id = 21,
                    Qtd = 1,
                    Tipo = "",
                    Produto = "Cebola fatiada em rodelas",
                    ReceitaId = 3
                },
                new Ingrediente
                {
                    Id = 22,
                    Qtd = 225,
                    Tipo = "gramas",
                    Produto = "Farinha de Trigo",
                    ReceitaId = 3
                },
                new Ingrediente
                {
                    Id = 23,
                    Qtd = 2,
                    Tipo = "colher de sopa",
                    Produto = "Azeite",
                    ReceitaId = 3
                },
                new Ingrediente
                {
                    Id = 24,
                    Qtd = 5,
                    Tipo = "colheres de sopa",
                    Produto = "molho de tomate",
                    ReceitaId = 3
                },
                new Ingrediente
                {
                    Id = 25,
                    Qtd = 25,
                    Tipo = "gramas",
                    Produto = "Queijo chedar",
                    ReceitaId = 3
                },
                #endregion

                #region INGREDIENTES PIZZA MOLHO CASEIRO
                new Ingrediente
                {
                    Id = 26,
                    Qtd = 300,
                    Tipo = "gramas",
                    Produto = "Farinha de Trigo",
                    ReceitaId = 4
                },
                new Ingrediente
                {
                    Id = 27,
                    Qtd = 7,
                    Tipo = "gramas",
                    Produto = "Fermento Biológico",
                    ReceitaId = 4
                },
                new Ingrediente
                {
                    Id = 28,
                    Qtd = 1,
                    Tipo = "colher de sopa",
                    Produto = "Azeite",
                    ReceitaId = 4
                },
                new Ingrediente
                {
                    Id = 29,
                    Qtd = 2,
                    Tipo = "dentes",
                    Produto = "de Alho",
                    ReceitaId = 4
                },
                new Ingrediente
                {
                    Id = 30,
                    Qtd = 200,
                    Tipo = "ml",
                    Produto = "passata",
                    ReceitaId = 4
                },
                new Ingrediente
                {
                    Id = 31,
                    Qtd = 8,
                    Tipo = "fatias",
                    Produto = "mussarela",
                    ReceitaId = 4
                },
                new Ingrediente
                {
                    Id = 32,
                    Qtd = 1,
                    Tipo = "cacho",
                    Produto = "de manjericão",
                    ReceitaId = 4
                },
                #endregion
            
                #region PIZZA DE FRIGIDERIA BERINGELA RIQUOTA E HORTELA
                new Ingrediente
                {
                    Id = 33,
                    Qtd = 200,
                    Tipo = "gramas",
                    Produto = "Farinha de trigo",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 34,
                    Qtd = 0.5,
                    Tipo = "colher de sopa",
                    Produto = "Fermento biológico",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 35,
                    Qtd = 0.25,
                    Tipo = "colher de sopa",
                    Produto = "Açúcar",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 36,
                    Qtd = 1,
                    Tipo = "colher de sopa",
                    Produto = "de óleo",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 37,
                    Qtd = 4,
                    Tipo = "colheres de sopa ",
                    Produto = "de azeite",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 38,
                    Qtd = 1,
                    Tipo = "dente",
                    Produto = "de álho",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 39,
                    Qtd = 200,
                    Tipo = "gramas",
                    Produto = "passata",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 40,
                    Qtd = 1,
                    Tipo = "",
                    Produto = "beringela",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 41,
                    Qtd = 100,
                    Tipo = "gramas",
                    Produto = "ricota",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 42,
                    Qtd = 10,
                    Tipo = "folhas",
                    Produto = "de hortelã",
                    ReceitaId = 5
                },
                new Ingrediente
                {
                    Id = 43,
                    Qtd = 200,
                    Tipo = "gramas",
                    Produto = "Farinha de trigo",
                    ReceitaId = 5
                }
                #endregion
            );

            modelBuilder.Entity<Etapa>().HasData
            (
                #region ETAPAS DA PIZZA MARGHERITA
                new Etapa
                {
                    Id = 1,
                    Descricao = "Primeiro, faça a massa. Incline a farinha para uma tigela e adicione 300ml de água morna. Misture e reserve à temperatura ambiente durante 1 hora. Dissolva a levedura em 2 colheres de sopa de água e misture esta e 15g de sal através da massa. Cubra com película aderente e deixe em algum lugar quente para dobrar de tamanho por algumas horas. Para um sabor mais azedo, deixe na geladeira por pelo menos 8 horas e até 24 horas – quanto mais tempo você deixar, mais azedo será.",
                    ReceitaId = 1
                },

                new Etapa
                {
                    Id = 2,
                    Descricao = "Quando a massa estiver pronta, incline-a para uma superfície levemente enfarinhada e divida em quatro. Enrole em bolas e deixe descansar, coberto com uma toalha de chá ou filme aderente por mais uma hora.",
                    ReceitaId = 1
                },

                new Etapa
                {
                    Id = 3,
                    Descricao = "Agora faça o molho de tomate. Escorra um pouco do suco da lata e coloque o resto em uma tigela com o azeite, orégano e uma generosa pitada de sal, em seguida, triture tudo junto com os dedos para um molho volumoso ou blitz com um liquidificador de palito, se você quiser que seja suave. Amarre os talos de manjericão, machuque com as costas de uma faca e coloque no molho. Deixe o molho à temperatura ambiente até que seja necessário.",
                    ReceitaId = 1
                },

                new Etapa
                {
                    Id = 4,
                    Descricao = "Para fazer a pizza, aqueça uma grelha até o seu cenário mais alto e pegue uma frigideira pesada. Em uma superfície enfarinhada, empurre e estique uma das bolas de massa em um círculo aproximadamente do mesmo tamanho que a frigideira. Coloque a rodada em uma assadeira enfarinhada e cubra com um quarto do molho, uma dispersão de queijo, algumas folhas de manjericão e um quarto da mussarela.",
                    ReceitaId = 1
                },

                new Etapa
                {
                    Id = 5,
                    Descricao = "Pegue a panela bem quente e deslize cuidadosamente a pizza sobre ela. Cozinhe por 2 minutos, depois coloque a panela sob a grelha por mais 2 minutos até que as laterais estejam inchadas e o queijo tenha derretido. Levante em uma prancha, regue com um pouco de azeite, se quiser, depois corte em fatias e sirva enquanto faz a próxima.",
                    ReceitaId = 1
                },
                #endregion

                #region ETAPAS DA PIZZA SUPERSAUDAVEL
                new Etapa
                {
                    Id = 6,
                    Descricao = "Misture as farinhas e o fermento com uma pitada de sal em um processador de alimentos equipado com uma lâmina de massa. Despeje na água e misture em uma massa macia, em seguida, trabalhe por 1 min. Retire a massa e enrole em uma superfície levemente enfarinhada até uma volta de cerca de 30 cm de diâmetro. Levante sobre uma assadeira oleada.",
                    ReceitaId = 2
                },
                new Etapa
                {
                    Id = 7,
                    Descricao = "Espalhe os tomates enlatados sobre a massa a menos de 2 cm das bordas. Disponha os tomates cereja e as aboborinhas por cima, depois espalhe com a mussarela. Misture as alcaparras, as azeitonas e o alho, depois espalhe por cima. Regue uniformemente com o óleo. Deixe levantar por 20 minutos. Aqueça o forno a 240C/ventilador 220C/gás 9 ou a configuração mais alta.",
                    ReceitaId = 2
                },
                new Etapa
                {
                    Id = 8,
                    Descricao = "Asse a pizza por 10-12 minutos até ficar crocante e dourada ao redor das bordas. Espalhe com a salsa para servir.",
                    ReceitaId = 2
                },
                #endregion
            
                #region ETAPAS DA PIZZA DE FRIGIDEIRA
                new Etapa
                {
                    Id = 9,
                    Descricao = "Aqueça o forno a 220C/fan 200C/gas 7. Coloque a pimenta, a abobrinha e a cebola roxa em uma assadeira antiaderente grande e regue com 1 colher de chá de azeite. Tempere bem e jogue para combinar. Asse no forno por 20 minutos até ficar macio e comece a dourar. Reservar.",
                    ReceitaId = 3
                },
                new Etapa
                {
                    Id = 10,
                    Descricao = "Aqueça a grelha a médio. Tempere bem a farinha e, em uma tigela grande, misture com o óleo restante e 4-5 colheres de sopa de água para formar uma massa macia. Amasse brevemente e, em seguida, enrole em uma superfície enfarinhada em um círculo áspero de 20 cm. Transfira a massa para uma frigideira grande à prova de forno, antiaderente e frite em fogo médio por 5 minutos, até que a parte de baixo comece a dourar. Vire e cozinhe por mais 5 minutos. Espalhe o molho de tomate sobre a base, espalhe com o vegetal assado e, em seguida, polvilhe com cheddar. Grelhar a pizza por 3-4 minutos até que o queijo tenha derretido. Sirva imediatamente, fatiado em fatias, com uma grande salada verde.",
                    ReceitaId = 3
                },
                #endregion
            
                #region ETAPAS DA PIZZA MOLHO CASEIRO
                new Etapa
                {
                    Id = 11,
                    Descricao = "Incline a farinha em uma tigela, em seguida, misture o fermento e 1 colher de chá de sal. Faça um poço no centro e despeje 200ml de água morna (certifique-se de que não está muito quente) junto com o óleo. Misture com uma colher de pau até ter uma massa macia e bastante molhada.",
                    ReceitaId = 4
                },
                new Etapa
                {
                    Id = 12,
                    Descricao = "Incline a massa para fora em uma superfície levemente enfarinhada e amasse por 5 minutos até ficar homogêneo. Cubra com uma toalha de chá e reserve por uma hora ou mais ou menos ou até que a massa tenha inchado e dobrado de tamanho. Você também pode deixar a massa áspera e não amassada na tigela, cobrir com uma toalha de chá e deixar na geladeira durante a noite e a massa continuará a provar por conta própria.",
                    ReceitaId = 4
                },
                new Etapa
                {
                    Id = 13,
                    Descricao = "Enquanto isso, faça o molho de tomate. Coloque o óleo em uma panela pequena e frite o alho brevemente (não deixe dourar), depois adicione a passata e deixe ferver tudo até o molho engrossar um pouco. Deixe esfriar.",
                    ReceitaId = 4
                },
                new Etapa
                {
                    Id = 14,
                    Descricao = "Uma vez que a massa tenha subido, amasse-a rapidamente na tigela para derrubá-la de volta, depois incline-a para uma superfície levemente enfarinhada e corte em duas bolas. Enrole cada bola em uma grande lágrima que seja muito fina e com cerca de 25 cm de diâmetro (as formas de lágrima se encaixam nas assadeiras mais facilmente do que as rodadas).",
                    ReceitaId = 4
                },
                new Etapa
                {
                    Id = 15,
                    Descricao = "Aqueça o forno a 240C/220C ventilador/gás 9 com uma assadeira grande dentro. Levante uma das bases em outra assadeira enfarinhada. Alise o molho sobre a base com as costas de uma colher, espalhe mais de metade da mussarela, regue com azeite e tempere. Coloque a pizza, ainda em sua assadeira, em cima da folha quente no forno e asse por 8-10 minutos até ficar crocante.",
                    ReceitaId = 4
                },
                
                #endregion

                #region ETAPAS PIZZA FIGIDEIRA BERINGELA HORTELA
                new Etapa
                {
                    Id = 16,
                    Descricao = "Pese os ingredientes para a massa em uma tigela grande e adicione 1/2 colher de chá de sal e 125ml de água morna. Misture para formar uma massa macia, depois incline para a superfície de trabalho e amasse por 5 minutos ou até que a massa pareça elástica. Limpe e unte a tigela e devolva a massa. Cubra com película aderente e deixe em algum lugar quente para subir por 1 hora, ou até que a massa tenha dobrado de tamanho.",
                    ReceitaId = 5
                },
                new Etapa
                {
                    Id = 17,
                    Descricao = "Enquanto isso, faça o molho. Aqueça 1 colher de sopa de azeite em uma panela e adicione o alho. Escalfe suavemente por 30 segundos, certificando-se de que o alho não doura e, em seguida, adicione a passata. Tempere bem e borbulhe por 8-10 minutos até ter um molho rico – adicione uma pitada de açúcar se tiver um gosto um pouco azedo demais. Reservar.",
                    ReceitaId = 5
                },
                new Etapa
                {
                    Id = 18,
                    Descricao = "Quando a massa tiver subido, retire o ar e enrole-a em uma base de pizza do mesmo tamanho de uma frigideira grande. Lubrifique a superfície da massa, cubra com filme aderente e, em seguida, deixe na superfície de trabalho por 15 minutos para inchar um pouco. Enquanto isso, aqueça 2 colheres de sopa de óleo na frigideira e adicione as beringelas em uma única camada (você pode ter que cozinhar em lotes). Tempere bem e cozinhe por 4-5 minutos de cada lado até ficar realmente macio e dourado. Transfira para um prato e cubra com papel alumínio para se manter aquecido.",
                    ReceitaId = 5
                },
                new Etapa
                {
                    Id = 19,
                    Descricao = "Aqueça as 1 colher de sopa restantes de óleo na panela e levante cuidadosamente a massa para dentro dela. Você pode ter que remodelá-lo um pouco para se encaixar. Cozinhe em fogo baixo-médio até que a parte inferior esteja dourada e as bordas da massa estejam começando a parecer secas e ajustadas – isso deve levar cerca de 6 minutos, mas é melhor ir de olho. Vire, regue um pouco mais de óleo ao redor da borda da panela para que ele escorra sob a base da pizza e cozinhe por mais 5-6 minutos até dourar e cozinhar. Reaqueça o molho se precisar e espalhe-o sobre a base. Cubra com as beringelas quentes e pontilhar com colheres de ricota. Espalhe com hortelã e regue com um pouco de azeite extra virgem antes de servir.",
                    ReceitaId = 5
                }
                #endregion
            );
        }
    }
}