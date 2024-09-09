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
    public class TurmaServices : BaseServices<Turma, TurmaDto>, ITurmaService
    {
        public TurmaServices(IBaseRepositorio<Turma> repositorio, IMapper mapper) : base(repositorio, mapper)
        {
        }
    }
}
