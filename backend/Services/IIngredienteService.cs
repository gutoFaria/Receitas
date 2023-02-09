using backend.Models;

namespace backend.Services
{
    public interface IIngredienteService
    {
        Task<IEnumerable<Ingrediente>> GetAllIngredientes();
    }
}