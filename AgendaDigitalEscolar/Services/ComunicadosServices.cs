using AutoMapper;
using Entidades;
using Repositorios.Interfaces;
using Services.DTO;
using Services.Interfaces;

namespace Services;

public class ComunicadosServices : BaseServices<Comunicados, ComunicadoDto>, IComunicadoServices
{
    private readonly IComunicadoTurmaRepositorio comunicadoTurmaRepositorio;
    private readonly IMapper _mapper;

    public ComunicadosServices(
        IBaseRepositorio<Comunicados> repositorio,
        IMapper mapper,
        IComunicadoTurmaRepositorio comunicadoTurmaRepositorio
        ) : base(repositorio, mapper)
    {
        this.comunicadoTurmaRepositorio = comunicadoTurmaRepositorio;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Comunicados>> BuscarComunicadosPorTurma(int id)
    {
        return await comunicadoTurmaRepositorio.BuscarComunicadosPorTurma(id);
    }

    public async Task<bool> CadastrarComunicadosPorTurma(ComunicadoTurmasDto turmasDto)
    {
        var entidade = _mapper.Map<Comunicado_Turmas>(turmasDto);
        return await comunicadoTurmaRepositorio.InserirAsync(entidade);
    }
}
