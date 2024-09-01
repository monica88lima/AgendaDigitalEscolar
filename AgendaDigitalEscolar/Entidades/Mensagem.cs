using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensagem:Padrao
    {
        public int MensagemId { get; set; }
        public string Conteudo { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int PerfilDisparo { get; set; }
        public DateTime DataEnvio { get; set; }
        public bool Lida { get; set; }
    }
}
