using GS_GreenCycle.Filters;
using Microsoft.AspNetCore.Mvc;

namespace GS_GreenCycle.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
