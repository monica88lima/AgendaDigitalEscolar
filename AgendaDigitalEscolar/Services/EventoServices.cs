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
        public EventoServices(IBaseRepositorio<Eventos> repositorio, IMapper mapper) : base(repositorio, mapper)
        {
        }
    
    }
}
