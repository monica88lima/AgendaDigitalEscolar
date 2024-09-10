using AutoMapper;
using Entidades;
using Repositorios.Interfaces;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AgendaDiariaServices : BaseServices<AgendaDiaria, AgendaDiariaDto>, IAgendaDiariaServices
    {
        IBaseRepositorio<AgendaDiaria> _repositorio;
        public AgendaDiariaServices(IBaseRepositorio<AgendaDiaria> repositorio, IMapper mapper) : base(repositorio, mapper)
        {
            _repositorio = repositorio;
        }
        public async Task<bool> MarcarAgendaLidoAsync(int id)
        {

            var agenda = await _repositorio.BuscarPorIdAsync(id);
            agenda.Lido = true;

            return await _repositorio.AlterarAsync(id, agenda);

        }
    }
    
}
