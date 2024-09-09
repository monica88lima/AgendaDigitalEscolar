using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class ProfessorDto: IMapFrom<Professor>
    {
        [Column("professor_id")]
        [Key]

        public int ProfessorId { get; set; }

        [Column("usuario_id")]
        [Required]
        public int UsuarioId { get; set; }
        
        [Required]
        public string NomeCompleto { get; set; }
        
       
    }
}
