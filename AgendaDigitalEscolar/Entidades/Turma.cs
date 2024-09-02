using Entidades.Enun;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Turma:Padrao
    {
        [Key]
        public int TurmaId { get; set; }
        [Required]
        public int AnoTurma { get; set; }
      
        public int EscolaId { get; set; }
        public Escola Escola { get; set; }
        public int? ProfessorId { get; set; }
        public Professor Professor { get; set; }
        [Required]
        public EGrauTurma GrauTurma { get; set; }
        [Required]
        public EPeriodoTurma PeriodoTurma { get; set; }
        public ICollection<Estudante> Estudantes { get; set; }
        public ICollection<EventoTurma> EventosTurmas { get; set; }
        public ICollection<ComunicadoTurma> ComunicadoTurmas { get; set; }
        public ICollection<Atividade> Atividades { get; set; }
    }
}
