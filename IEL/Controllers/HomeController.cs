using System.Diagnostics;
using IEL.Models;
using Microsoft.AspNetCore.Mvc;

namespace IEL.Controllers
{
    public class HomeController : Controller
    {
        // Exibe a p�gina inicial
        public IActionResult Index()
        {
            return View();
        }

        // Exibe a p�gina de privacidade
        public IActionResult Privacy()
        {
            return View();
        }

        // Exibe a p�gina de erro, com um identificador de solicita��o
        // A resposta n�o ser� armazenada em cache
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
