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
    
    public class AtividadeServices : BaseServices<Atividade, AtividadeDto>, IAtividadeService
    {
        IBaseRepositorio<Atividade> _repositorio;
        public AtividadeServices(IBaseRepositorio<Atividade> repositorio, IMapper mapper) : base(repositorio, mapper)
        {
            _repositorio = repositorio;
        }
        public async Task<bool> MarcarAtividadeLidoAsync(int id)
        {

            var atividade = await _repositorio.BuscarPorIdAsync(id);
            atividade.Lido = true;

            return await _repositorio.AlterarAsync(id, atividade);

        }
    }
}
