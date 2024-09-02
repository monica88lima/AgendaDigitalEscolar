using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Atividade:Padrao
    {
        [Key]
        public int AtividadeId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        public string Material { get; set; }
        [Required]
        public DateTime DataEntrega { get; set; }
      
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public bool Lido { get; set; } = false;
    }
}
