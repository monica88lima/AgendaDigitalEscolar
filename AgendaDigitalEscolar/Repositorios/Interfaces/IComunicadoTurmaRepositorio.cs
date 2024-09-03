using Entidades;

namespace Repositorios.Interfaces;

public interface IComunicadoTurmaRepositorio : IBaseRepositorio<Comunicado_Turmas>
{
    Task<IEnumerable<Comunicados>> BuscarComunicadosPorTurma(int id);
}
