namespace backend.Models
{
    public class Etapa
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = String.Empty;
        public int ReceitaId { get; set; }
    }
}