using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Responsavel:Padrao
    {
        public int ResponsavelId { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
      
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<EstudanteResponsavel> EstudanteResponsaveis { get; set; }
    }
}
