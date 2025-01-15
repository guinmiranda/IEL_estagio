using IEL.Models;
using IEL.Repositório;
using Microsoft.AspNetCore.Mvc;

namespace IEL.Controllers
{
    public class EstudanteController : Controller
    {
        // Dependência do repositório para interagir com os dados dos estudantes
        private readonly IEL.Repositório.IEstudanteRepositorio _estudanteRepositorio;

        public EstudanteController(IEstudanteRepositorio estudanteRepositorio)
        {
            _estudanteRepositorio = estudanteRepositorio;
        }

        // Exibe a lista de estudantes
        public IActionResult Index()
        {
            List<EstudanteModel> estudantes = _estudanteRepositorio.BuscarRegistros();
            return View(estudantes);
        }

        // Exibe o formulário para criação de um novo estudante
        public IActionResult Criar()
        {
            return View();
        }

        // Exibe os dados de um estudante específico para edição
        public IActionResult Editar(int id)
        {
            EstudanteModel estudantes = _estudanteRepositorio.ListarId(id);
            return View(estudantes);
        }

        // Exibe a confirmação antes de excluir um estudante
        public IActionResult Apagar_Confirmacao(int id)
        {
            EstudanteModel estudantes = _estudanteRepositorio.ListarId(id);
            return View(estudantes);
        }

        // Exclui o estudante após a confirmação
        public IActionResult Apagar(int id)
        {
            _estudanteRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        // Processa a criação de um novo estudante
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

        // Processa a edição de um estudante existente
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
