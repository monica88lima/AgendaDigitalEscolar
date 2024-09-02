using Entidades;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class EventoDto : IMapFrom<Evento>
    {
        public int EventoId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime DataEvento { get; set; }
        [Required]
        public string Hora { get; set; }
        [Required]
        public string Local { get; set; }
        [Required]
        public int EscolaId { get; set; }
        
        public bool Lido { get; set; } = false;
       
    }
}
