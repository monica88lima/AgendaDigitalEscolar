namespace Entidades
{
    public class ComunicadoTurma
    {
        public int ComunicadoTurmaId { get; set; }
        public int ComunicadoId { get; set; }
        public Comunicados Comunicado { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}
