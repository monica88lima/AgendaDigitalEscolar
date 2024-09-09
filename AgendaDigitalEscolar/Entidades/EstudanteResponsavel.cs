namespace Entidades
{
    public class EstudanteResponsavel
    {
        public int EstudanteResponsavelId { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }
    }
}
