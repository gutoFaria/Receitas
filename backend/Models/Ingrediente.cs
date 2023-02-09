using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        [Column(name:"Quantidade")]
        public double Qtd { get; set; }
        public string Tipo { get; set; } = String.Empty;
        [Column(name:"Nome do Produto")]
        public string Produto { get; set; } = String.Empty;
        public int ReceitaId { get; set; }
    }
}