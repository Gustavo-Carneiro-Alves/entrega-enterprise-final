using GS_GreenCycle.Models;
using Microsoft.AspNetCore.Mvc;

namespace GS_GreenCycle.Controllers
{
    public class SuporteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Problema(Suporte suporte)
        {
            return View(suporte);
        }
    }
}
