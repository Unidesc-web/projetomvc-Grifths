
using LanchoneteMVC.Repositories.Interfaces;
using LanchoneteMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchoneteMVC.Controllers;
public class LancheController : Controller
{
    private readonly ILancheRepository _lancheRepository;
    public LancheController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }
    public IActionResult List()
    {
        var lancheListViewModel = new LancheListViewModel
        {
            Lanches = _lancheRepository.Lanches,
            CategoriaAtual = "Nosso Cardápio"
        };
        return View(lancheListViewModel);
    }
}
