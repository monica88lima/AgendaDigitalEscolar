using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Professor:Padrao
    {
        [Column("professor_id")]
        [Key]
       
        public int ProfessorId { get; set; }

        [Column("usuario_id")]
        [Required]
        public int UsuarioId { get; set; }
        [JsonIgnore]
        public Usuario Usuario { get; set; }
        [Required]
        public string NomeCompleto { get; set; }
        [JsonIgnore]
        public ICollection<Turma> Turmas { get; set; }
        [JsonIgnore]
        public ICollection<Comunicados> Comunicados { get; set; }
        [JsonIgnore]
        public ICollection<Atividade> Atividades { get; set; }
        [JsonIgnore]
        public ICollection<Mensagem> Mensagens { get; set; }
    }
}
