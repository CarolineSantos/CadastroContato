using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestePratico.Models;
using TestePratico.Repository;

namespace TestePratico.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContatoRepository _contato;

        public HomeController(IContatoRepository contato)
        {
            _contato = contato;
        }

        public IActionResult Index()
        {
            List<ContatoModel> listaContatos = _contato.ListaContatos();
            ContatoViewModel contatoViewModel = new ContatoViewModel();
            contatoViewModel.Lista = listaContatos;
            return View(contatoViewModel);
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
        public IActionResult AdicionarContato(ContatoViewModel Contato)
        {
            if (!String.IsNullOrEmpty(Contato.Registro.Nome) || !String.IsNullOrEmpty(Contato.Registro.Telefone))
            {
                _contato.AdicionarContato(Contato.Registro);
                return RedirectToAction("Index");
            }
            else 
            {
                ModelState.AddModelError("Email", "O email é inválido.");
                return RedirectToAction("Index");
            }            
        }

        public IActionResult ExcluirContato(int id)
        {
            _contato.ExcluirContato(id);
            return RedirectToAction("Index");
        }
    }
}
