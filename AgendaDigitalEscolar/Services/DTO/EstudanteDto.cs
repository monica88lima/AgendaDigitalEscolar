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
    public class EstudanteDto:IMapFrom<Estudante> 
   {
        [Key]
        [Column("estudante_id")]
        public int EstudanteId { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "O nome de possuir mais de {1} caracteres")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Column("turma_id")]
        public int TurmaId { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Matricula { get; set; }
      
    }
}
