using Entidades;
using Services.DTO;

namespace Services.Interfaces
{
    public interface IComunicadoServices : IBaseServices<Comunicados, ComunicadoDto>
    {
        Task<IEnumerable<Comunicados>> BuscarComunicadosPorTurma(int id);

        Task<bool> CadastrarComunicadosPorTurma(ComunicadoTurmasDto turmasDto);

        Task<bool> MarcarComunicadoLidoAsync(int comunicadoId);
    }
}



