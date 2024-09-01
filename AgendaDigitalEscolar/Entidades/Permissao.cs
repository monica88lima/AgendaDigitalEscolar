using Entidades.Enun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permissao
    {
        public int PermissaoId { get; set; }
        public EPermissao Nome { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
