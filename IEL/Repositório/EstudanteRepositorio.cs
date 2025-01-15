using IEL.Data;
using IEL.Models;
using IEL.Repositório;

public class EstudanteRepositorio : IEstudanteRepositorio
{
    private readonly BancoContext _bancoContext;

    public EstudanteRepositorio(BancoContext bancoContext)
    {
        _bancoContext = bancoContext;
    }

    public EstudanteModel ListarId(int id)
    {
        return _bancoContext.Estudantes.FirstOrDefault(x => x.Id == id);
    }
    public List<EstudanteModel> BuscarRegistros()
    {
        return _bancoContext.Estudantes.ToList();
    }

    public EstudanteModel Adicionar(EstudanteModel estudante)
    {
        _bancoContext.Estudantes.Add(estudante);
        _bancoContext.SaveChanges();
        return estudante;
    }

    public EstudanteModel Atualizar(EstudanteModel estudante)
    {
        EstudanteModel estudantedb = ListarId(estudante.Id);

        if (estudantedb == null) throw new Exception("ERRO: atualização de contato Não concluida");

        estudantedb.Nome=estudante.Nome;
        estudantedb.CPF = estudante.CPF;
        estudantedb.Endereco = estudante.Endereco;
        estudantedb.DataDeConclusao = estudante.DataDeConclusao;

        _bancoContext.Estudantes.Update(estudantedb);
        _bancoContext.SaveChanges();
        return estudantedb;
    }

    public bool Apagar(int id)
    {
        EstudanteModel estudantedb = ListarId(id);
        if (estudantedb == null) throw new Exception("ERRO: Exclusão de contato não concluida");
        _bancoContext.Estudantes.Remove(estudantedb);
        _bancoContext.SaveChanges();
        return true; 
    }
}
