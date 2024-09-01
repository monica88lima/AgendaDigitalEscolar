using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComunicadoTurma
    {
        public int ComunicadoTurmaId { get; set; }
        public int ComunicadoId { get; set; }
        public Comunicado Comunicado { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}
