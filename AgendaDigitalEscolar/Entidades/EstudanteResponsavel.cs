using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudanteResponsavel
    {
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }
    }
}
