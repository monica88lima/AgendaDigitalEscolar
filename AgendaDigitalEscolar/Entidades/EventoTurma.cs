using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EventoTurma
    {
        public int EventosEscolaId { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}
