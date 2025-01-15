using IEL.Models;
using IEL.Repositório;
using Microsoft.AspNetCore.Mvc;

namespace IEL.Controllers
{
    public class EstudanteController : Controller // Renomeado para EstudanteController
    {
        private readonly IEL.Repositório.IEstudanteRepositorio _estudanteRepositorio;

        public EstudanteController(IEstudanteRepositorio estudanteRepositorio) // Usando construtor primário
        {
            _estudanteRepositorio = estudanteRepositorio;
        }

        public IActionResult Index()
        {
            List<EstudanteModel> estudantes = _estudanteRepositorio.BuscarRegistros();
            
            return View(estudantes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            EstudanteModel estudantes=_estudanteRepositorio.ListarId(id);
            return View(estudantes);
        }

        public IActionResult Apagar_Confirmacao(int id)
        {
            EstudanteModel estudantes = _estudanteRepositorio.ListarId(id);
            return View(estudantes);
        }

        public IActionResult Apagar(int id)
        {
            _estudanteRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Criar(EstudanteModel estudante)
        {
            if (ModelState.IsValid)
            {
                _estudanteRepositorio.Adicionar(estudante);
                return RedirectToAction("Index");
            }
            return View(estudante);
            }
        
        [HttpPost]
        public IActionResult Editar(EstudanteModel estudante)
        {
            if (ModelState.IsValid)
            {

                _estudanteRepositorio.Atualizar(estudante);
                return RedirectToAction("Index");
            }
            return View(estudante);
        }
    }
}