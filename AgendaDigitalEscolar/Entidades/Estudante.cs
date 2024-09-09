using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Estudante:Padrao
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
        [JsonIgnore]
        public Turma Turma { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Matricula { get; set; }
        [JsonIgnore]
        public ICollection<EstudanteResponsavel> EstudanteResponsaveis { get; set; }
        [JsonIgnore]
        public ICollection<AgendaDiaria> AgendasDiarias { get; set; }
        [JsonIgnore]
        public ICollection<Mensagem> Mensagens { get; set; }
        [JsonIgnore]
        public ICollection<Financeiro> Financeiros { get; set; }
    }
}
