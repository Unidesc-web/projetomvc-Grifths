
using LanchoneteMVC.Data;
using LanchoneteMVC.Models;
using LanchoneteMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchoneteMVC.Repositories;
public class LancheRepository : ILancheRepository
{
    private readonly AppDbContext _context;
    public LancheRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria).ToList();
    public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido).Include(c => c.Categoria).ToList();
    public Lanche GetLancheById(int lancheId) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
}
