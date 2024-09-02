using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Evento:Padrao
    {
        [Key]
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
        public int EscolaId { get; set; }
        public Escola Escola { get; set; }
        public bool Lido { get; set; }
        public ICollection<EventoTurma> EventosTurmas { get; set; }
    }
}
