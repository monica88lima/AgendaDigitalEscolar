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
 
    public class EstudantesServices : BaseServices<Estudante, EstudanteDto>, IEstudantesServices
    {
        public EstudantesServices(IBaseRepositorio<Estudante> repositorio, IMapper mapper) : base(repositorio, mapper)
        {
        }
    }

}
