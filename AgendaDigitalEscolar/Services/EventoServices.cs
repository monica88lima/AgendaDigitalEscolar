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
    public class EventoServices : BaseServices<Eventos, EventoDto>, IEventosServices
    {
        IBaseRepositorio<Eventos> _repositorio;


        public EventoServices(IBaseRepositorio<Eventos> repositorio, IMapper mapper) : base(repositorio, mapper)
        {
            _repositorio = repositorio;
        }

        public async Task<bool> MarcarEventoLidoAsync(int id)
        {

            var evento = await _repositorio.BuscarPorIdAsync(id);
            evento.Lido = true;

            return await _repositorio.AlterarAsync(id, evento);

        }

    }
}
