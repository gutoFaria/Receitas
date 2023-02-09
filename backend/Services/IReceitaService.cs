using backend.Models;

namespace backend.Services
{
    public interface IReceitaService
    {
        Task<IEnumerable<Receita>> GetAllReceitas();
    }
}