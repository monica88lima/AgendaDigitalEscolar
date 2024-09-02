using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Professor:Padrao
    {
        [Column("professor_id")]
        public int ProfessorId { get; set; }

        [Column("usuario_id")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string NomeCompleto { get; set; }
     
        public ICollection<Turma> Turmas { get; set; }
        public ICollection<Comunicados> Comunicados { get; set; }
        public ICollection<Atividade> Atividades { get; set; }
        public ICollection<Mensagem> Mensagens { get; set; }
    }
}
