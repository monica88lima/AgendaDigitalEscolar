using Entidades;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class EscolaDto : IMapFrom<Escola>
    {
       
        public int EscolaId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "O nome de possuir mais de {1} caracteres")]
        public string Nome { get; set; }
        [Phone]
        [Required]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Endereco { get; set; }

      
    }
}
