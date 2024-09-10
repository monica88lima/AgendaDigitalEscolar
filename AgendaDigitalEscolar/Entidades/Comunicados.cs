using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Comunicados: Padrao
    {
        [Key]
        [Column("comunicado_id")]
        public int ComunicadoId { get; set; }
        
        public string Descricao { get; set; }
        
        public string Titulo { get; set; }

        [Column("professor_id")]
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        
        public string AssinaturaCriador { get; set; }
        public string? Observacao { get; set; }
        public bool Lido { get; set; } = false;


        public ICollection<Comunicado_Turmas>? ComunicadoTurmas { get; set; }
    }
}
