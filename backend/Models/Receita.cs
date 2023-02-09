using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Receita
    {
        public int Id { get; set; }
        [Column(name:"Titulo da Receita")]
        public string Titulo { get; set; } =String.Empty;
        [Column(name:"Imagem Url")]
        public string ImageUrl { get; set; } = String.Empty;
        public List<Ingrediente> ListaIngredientes { get; set; } = new List<Ingrediente>();
        public List<Etapa> ListaEtapas { get; set; } = new List<Etapa>();
    }
}