using Entidades.Enun;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class AgendaDiaria : Padrao
    {
        [Key]
        [Column("agendaDiaria_id")]
        public int AgendaDiariaId { get; set; }
        [Required]
        [Column("estudante_id")]
        public int EstudanteId { get; set; }
        [JsonIgnore]
        public Estudante Estudante { get; set; }
        [Required]
        public DateTime? Data { get; set; }
        [Required]
        [Column("refeicao_status")]
        public ERefeicaoStatus RefeicaoStatus { get; set; }
        [Required]
        [Column("sono_status")]
        public ESonoStatus SonoStatus { get; set; }
        [Required]
        [Column("higiene_status")]
        public EHigieneStatus HigieneStatus { get; set; }
        [Required]
        public string? Atividades { get; set; }

        public bool Lido { get; set; } = false;
    }
}
