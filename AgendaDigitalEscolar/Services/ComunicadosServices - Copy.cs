using AutoMapper;
using Entidades;
using Repositorios.Interfaces;
using Services.DTO;
using Services.Interfaces;

namespace Services;

public class ResponsavelServices : BaseServices<Responsavel, ComunicadoDto>, IResponsavelServices
{
    public ResponsavelServices(IBaseRepositorio<Responsavel> repositorio, IMapper mapper) : base(repositorio, mapper)
    {
    }
}
