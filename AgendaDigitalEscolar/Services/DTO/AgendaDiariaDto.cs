using Entidades;
using Entidades.Enun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class AgendaDiariaDto:IMapFrom<AgendaDiaria>
    {
        public int AgendaDiariaId { get; set; }
        [Required]
        public int EstudanteId { get; set; }
     
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
