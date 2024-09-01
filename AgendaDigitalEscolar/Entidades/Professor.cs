using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Professor:Padrao
    {
        public int ProfessorId { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string NomeCompleto { get; set; }
     
        public ICollection<Turma> Turmas { get; set; }
        public ICollection<Comunicado> Comunicados { get; set; }
        public ICollection<Atividade> Atividades { get; set; }
        public ICollection<Mensagem> Mensagens { get; set; }
    }
}
