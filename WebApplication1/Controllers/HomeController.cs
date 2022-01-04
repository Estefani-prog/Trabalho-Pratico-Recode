using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult controle()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }

        public IActionResult EscolhaDisney()
        {
            return View();
        }

        public IActionResult EscolhaDubai()
        {
            return View();
        }

        public IActionResult EscolhaParis()
        {
            return View();
        }

        public IActionResult EscolhaPolinesia()
        {
            return View();
        }

        public IActionResult EscolhaRioDeJaneiro()
        {
            return View();
        }

        public IActionResult EscolhaRoma()
        {
            return View();
        }

        public IActionResult FinalDisney()
        {
            return View();
        }

        public IActionResult FinalDubai()
        {
            return View();
        }

        public IActionResult FinalParis()
        {
            return View();
        }

        public IActionResult FinalPolinesia()
        {
            return View();
        }

        public IActionResult FinalPromocao()
        {
            return View();
        }

        public IActionResult FinalRioDeJaneiro()
        {
            return View();
        }

        public IActionResult FinalRoma()
        {
            return View();
        }

        public IActionResult FinalizadaComSucesso()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}