using Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Services.DTO
{
    public class EventoDto : IMapFrom<Eventos>
    {
        [Key]
        [Column("evento_id")]
        public int EventoId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime DataEvento { get; set; }
        [Required]
        public string Hora { get; set; }
        public string Local { get; set; }
       
        [Column("escola_id")]
        public int EscolaId { get; set; }
        
        public bool Lido { get; set; } = false;
        

    }
}
