using backend.Models;

namespace backend.Services
{
    public interface IEtapaService
    {
        Task<IEnumerable<Etapa>> GetAllEtapas();
    }
}