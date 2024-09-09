using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class AtividadeDto: IMapFrom<Atividade>
    {
        [Key]
        [Column("atividade_id")]
        public int AtividadeId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        public string Material { get; set; }
        [Required]
        public DateTime DataEntrega { get; set; }
        [Required]
        [Column("turma_id")]
        public int TurmaId { get; set; }
        [Required]
        [Column("professor_id")]
        public int ProfessorId { get; set; }
       
        public bool Lido { get; set; } = false;
    }
}
