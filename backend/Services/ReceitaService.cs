using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    public class ReceitaService : IReceitaService
    {
        private readonly AppDbContext _context;

        public ReceitaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Receita>> GetAllReceitas()
        {
            var receitas = await _context.Receitas.ToListAsync();
            foreach (var receita in receitas)
            {
                receita.ListaIngredientes = await _context.Ingredientes.Where(i => i.ReceitaId == receita.Id).ToListAsync();
                receita.ListaEtapas = await _context.Etapas.Where(e => e.ReceitaId == receita.Id).ToListAsync();
            }

            return receitas;
        }

        public async Task<IEnumerable<Receita>> GetReceitas()
        {
            return await _context.Receitas.ToListAsync();
        }
    }
}