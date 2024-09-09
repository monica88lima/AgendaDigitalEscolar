using Entidades;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class AtividadeDto: IMapFrom<Atividade>
    {
        public int AtividadeId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        public string Material { get; set; }
        [Required]
        public DateTime DataEntrega { get; set; }
        [Required]
        public int TurmaId { get; set; }
        [Required]
        public int ProfessorId { get; set; }
       
        public bool Lido { get; set; } = false;
    }
}
