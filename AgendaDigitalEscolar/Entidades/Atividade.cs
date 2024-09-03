using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Atividade:Padrao
    {
        [Key]
        [Column("atividade_id")]
        public int AtividadeId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        public string? Material { get; set; }
        [Required]
        public DateTime DataEntrega { get; set; }
        [Required]
        [Column("turma_id")]
        public int TurmaId { get; set; }
        [JsonIgnore]
        public Turma Turma { get; set; }
        [Required]
        [Column("professor_id")]
        public int ProfessorId { get; set; }
        [JsonIgnore]
        public Professor Professor { get; set; }
        public bool Lido { get; set; } = false;

    }
}
