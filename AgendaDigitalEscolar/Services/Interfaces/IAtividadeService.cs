using Entidades;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   
    public interface IAtividadeService : IBaseServices<Atividade, AtividadeDto>
    {
        Task<bool> MarcarAtividadeLidoAsync(int id);
    }
}
