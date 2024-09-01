using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AgendaDiaria
    {
        public int AgendaDiariaId { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public DateTime? Data { get; set; }
        public int? RefeicaoStatus { get; set; }
        public int? SonoStatus { get; set; }
        public int? HigieneStatus { get; set; }
        public string? Atividades { get; set; }
       
        public bool Lido { get; set; }
    }
}
