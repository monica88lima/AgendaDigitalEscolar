using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class UsuarioDto
    {
        [Key] 
        public int UsuarioId { get; set; }
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
        public int PermissaoId { get; set; }
        public Permissao Permissao { get; set; }
        public int EscolaId { get; set; }
        public Escola Escola { get; set; }
        public ICollection<Professor> Professores { get; set; }
        public ICollection<Responsavel> Responsaveis { get; set; }
    }
}
