using Entidades.Enun;

namespace Entidades
{
    public class Permissao
    {
        public int PermissaoId { get; set; }
        public EPermissao Nome { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
