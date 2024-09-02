using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Estudante:Padrao
    {
        [Key]
        public int EstudanteId { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "O nome de possuir mais de {1} caracteres")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Matricula { get; set; }
       
        public ICollection<EstudanteResponsavel> EstudanteResponsaveis { get; set; }
        public ICollection<AgendaDiaria> AgendasDiarias { get; set; }
        public ICollection<Mensagem> Mensagens { get; set; }
        public ICollection<Financeiro> Financeiros { get; set; }
    }
}
