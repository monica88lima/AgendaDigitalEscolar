using Entidades.Enun;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Turma:Padrao
    {
        [Key]
        
        [Column("turma_id")]
        public int TurmaId { get; set; }
        [Required]
        public int AnoTurma { get; set; }
        [Required]
        [Column("escola_id")]
        public int EscolaId { get; set; }
        
        [JsonIgnore]
        public Escola Escola { get; set; }
        [Required]
        [Column("professor_id")]
        public int? ProfessorId { get; set; }
        [JsonIgnore]
        public Professor Professor { get; set; }
        [Required]
        public EGrauTurma GrauTurma { get; set; }
        [Required]
        public EPeriodoTurma PeriodoTurma { get; set; }
        [JsonIgnore]
        public ICollection<Estudante> Estudantes { get; set; }
        [JsonIgnore]
        public ICollection<EventoTurma> EventosTurmas { get; set; }
        [JsonIgnore]
        public ICollection<ComunicadoTurma> ComunicadoTurmas { get; set; }
        [JsonIgnore]
        public ICollection<Atividade> Atividades { get; set; }
    }
}
