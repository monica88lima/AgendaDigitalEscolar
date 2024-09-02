namespace Entidades
{
    public class EventoTurma
    {
        public int EventoTurmaId { get; set; }
        public int EventosEscolaId { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}
