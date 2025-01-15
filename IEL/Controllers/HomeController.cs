using System.Diagnostics;
using IEL.Models;
using Microsoft.AspNetCore.Mvc;

namespace IEL.Controllers
{
    public class HomeController : Controller
    {
        // Exibe a página inicial
        public IActionResult Index()
        {
            return View();
        }

        // Exibe a página de privacidade
        public IActionResult Privacy()
        {
            return View();
        }

        // Exibe a página de erro, com um identificador de solicitação
        // A resposta não será armazenada em cache
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
