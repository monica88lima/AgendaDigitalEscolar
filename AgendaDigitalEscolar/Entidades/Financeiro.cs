using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Financeiro
    {
        public int IdFinanceiro { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int Mes { get; set; }
        public bool Pago { get; set; } = false;
    }
}
