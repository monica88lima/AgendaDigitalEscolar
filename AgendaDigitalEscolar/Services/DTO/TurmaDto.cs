using Entidades;
using Entidades.Enun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class TurmaDto : IMapFrom<Turma>
    {
        [Key]

        [Column("turma_id")]
        public int TurmaId { get; set; }
        [Required]
        public int AnoTurma { get; set; }
        [Required]
        [Column("escola_id")]
        public int EscolaId { get; set; }

     
        [Required]
        [Column("professor_id")]
        public int? ProfessorId { get; set; }
        
        [Required]
        public EGrauTurma GrauTurma { get; set; }
        
     
    }
}
