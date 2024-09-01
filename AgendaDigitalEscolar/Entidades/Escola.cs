using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escola:Padrao
    {
        [Key]
        public int EscolaId { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "O nome de possuir mais de {1} caracteres")]
        public string Nome { get; set; }
        [Phone]
        [Required]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Endereco { get; set; }
      
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Turma> Turmas { get; set; }
        public ICollection<Evento> Eventos { get; set; }
    }
}
