using IEL.Models;
namespace IEL.Repositório
{
    public interface IEstudanteRepositorio
    {
        EstudanteModel ListarId(int id);
        List<EstudanteModel> BuscarRegistros();
        EstudanteModel Adicionar(EstudanteModel estudante);

        EstudanteModel Atualizar(EstudanteModel estudante);

        bool Apagar(int id);
    }
}
