using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestePratico.Models;
using TestePratico.ViewModel;

namespace TestePratico.Controllers
{
    public class HomeController : Controller
    {
        AplicacaoRegras aplicacaoRegras = new AplicacaoRegras();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult AdicionarContato(ContatoModel Contato)
        {
            aplicacaoRegras.AdicionarContato(Contato);
            return View(Contato);
        }

        public IActionResult ApagarContato(ContatoModel Contato)
        {
            return View();
        }
    }
}
