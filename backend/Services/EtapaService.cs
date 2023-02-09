using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    public class EtapaService : IEtapaService
    {
        private readonly AppDbContext _context;

        public EtapaService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Etapa>> GetAllEtapas()
        {
            return await _context.Etapas.ToListAsync();
        }
    }
}