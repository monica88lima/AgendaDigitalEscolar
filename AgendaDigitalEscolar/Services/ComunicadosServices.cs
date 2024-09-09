using AutoMapper;
using Entidades;
using NuGet.Protocol.Core.Types;
using Repositorios.Interfaces;
using Services.DTO;
using Services.Interfaces;

namespace Services;

public class ComunicadosServices : BaseServices<Comunicados, ComunicadoDto>, IComunicadoServices
{
    private readonly IComunicadoTurmaRepositorio comunicadoTurmaRepositorio;
    private readonly IMapper _mapper;
    IBaseRepositorio<Comunicados> _repositorio;

    public ComunicadosServices(
        IBaseRepositorio<Comunicados> repositorio,
        IMapper mapper,
        IComunicadoTurmaRepositorio comunicadoTurmaRepositorio
        ) : base(repositorio, mapper)
    {
        this.comunicadoTurmaRepositorio = comunicadoTurmaRepositorio;
        _mapper = mapper;
        _repositorio = repositorio;
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

    public async Task<bool> MarcarComunicadoLidoAsync(int comunicadoId) { 

        var comunicado = await _repositorio.BuscarPorIdAsync(comunicadoId);
        comunicado.Lido = true;

        return await _repositorio.AlterarAsync(comunicadoId, comunicado);

    }
}
