using Entidades.Enun;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class AgendaDiaria : Padrao
    {
        public int AgendaDiariaId { get; set; }
        [Required]
        public int EstudanteId { get; set; }
        [Required]
        public Estudante Estudante { get; set; }
        [Required]
        public DateTime? Data { get; set; }
        [Required]
        public ERefeicaoStatus RefeicaoStatus { get; set; }
        [Required]
        public ESonoStatus SonoStatus { get; set; }
        [Required]
        public EHigieneStatus HigieneStatus { get; set; }
        [Required]
        public string? Atividades { get; set; }

        public bool Lido { get; set; } = false;
    }
}
