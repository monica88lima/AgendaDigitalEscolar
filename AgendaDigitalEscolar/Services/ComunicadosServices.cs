using AutoMapper;
using Entidades;
using Repositorios.Interfaces;
using Services.DTO;
using Services.Interfaces;

namespace Services;

public class ComunicadosServices : BaseServices<Comunicados, ComunicadoDto>, IComunicadoServices
{
    public ComunicadosServices(IBaseRepositorio<Comunicados> repositorio, IMapper mapper) : base(repositorio, mapper)
    {
    }
}
