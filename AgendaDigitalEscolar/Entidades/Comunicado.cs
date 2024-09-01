using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comunicado
    {
        [Key]
        public int ComunicadoId { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Titulo { get; set; }
       
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        
        public string AssinaturaCriador { get; set; }
        public string? Observacao { get; set; }
        public bool Lido { get; set; } = false;
        public ICollection<ComunicadoTurma> ComunicadoTurmas { get; set; }
    }
}
