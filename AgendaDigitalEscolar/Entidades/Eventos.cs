using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Eventos:Padrao
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
        public DateTime CriadoEm { get; set; }
        [Column("escola_id")]
        public int EscolaId { get; set; }
        [JsonIgnore]
        public Escola Escola { get; set; }
        public bool Lido { get; set; } = false;
        [JsonIgnore]
        public ICollection<EventoTurma> EventosTurmas { get; set; }
    }
}
