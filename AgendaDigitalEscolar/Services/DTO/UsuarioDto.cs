using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Entidades;

namespace Services.DTO
{
    public class UsuarioDto : IMapFrom<Usuario>
    {

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "O nome de possuir mais de {1} caracteres")]
        public string NomeCompleto { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [PasswordPropertyText]
        [MinLength(6, ErrorMessage = "Sua Senha deve possuir mais de  {1} caracteres")]
        [MaxLength(10, ErrorMessage = "Sua Senha deve possuir ate  {1} caracteres")]
        public string Senha { get; set; }
        [Required]
        public int PermissaoId { get; set; }
        [Required]
        public int EscolaId { get; set; }


    }
}
