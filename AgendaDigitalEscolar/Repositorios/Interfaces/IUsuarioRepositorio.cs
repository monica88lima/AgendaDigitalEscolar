using Entidades;

namespace Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<bool> Login(string email, string password);

        Task<bool> CadastrarUsuario(Usuario usuario);

        Task<bool> ValidarEmailUnico(string email);

        Task<bool> RedefinirSenha(string email, string password);

        Task<Usuario> BuscaUsuarioEmail(string email);

        Task<Usuario> BuscaUsuarioID(int id);

        Task<bool> AlteraUsuario(Usuario usuario);
        Task<IEnumerable<Usuario>> ListarUsuarios();


        Task<bool> DeletaUsuario(Usuario usuario);
    }
}
