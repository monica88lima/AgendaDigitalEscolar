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
    public class ResponsavelServices : BaseServices<Responsavel, ResponsavelDto>, IResponsavelServices
    {
        public ResponsavelServices(IBaseRepositorio<Responsavel> repositorio, IMapper mapper) : base(repositorio, mapper)
        {
        }
    }
}
