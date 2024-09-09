using AutoMapper;
using Entidades;
using Repositorios.Interfaces;
using Services.DTO;
using Services.Interfaces;

namespace Services;

public class EscolasServices : BaseServices<Escola, EscolaDto>, IEscolasServices
{
    public EscolasServices(IBaseRepositorio<Escola> repositorio, IMapper mapper) : base(repositorio, mapper)
    {
    }
}
