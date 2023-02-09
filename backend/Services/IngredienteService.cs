using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    public class IngredienteService : IIngredienteService
    {
        private readonly AppDbContext _context;

        public IngredienteService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Ingrediente>> GetAllIngredientes()
        {
            return await _context.Ingredientes.ToListAsync();
        }
    }
}