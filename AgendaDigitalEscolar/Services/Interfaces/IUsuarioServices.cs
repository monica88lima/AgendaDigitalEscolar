using Services.DTO;

namespace Services.Interfaces
{
    public interface IUsuarioServices
    {

        Task<bool> Login(string email, string password);
        Task<UsuarioDto> CadastrarUsuario(UsuarioDto usuario);
        Task<bool> ValidarEmailUnico(string email);
        Task<bool> AlterarSenha(string email, string senha);
        Task<UsuarioDto> BuscarUsuarioEmail(string email);
        Task<IEnumerable<UsuarioDto>> ListarTodosUsuario();
        Task<UsuarioDto> BuscarUsuarioId(int id);
        Task<bool> AlteraUsuario(UsuarioDto usuario);
        Task<bool> DeletaUsuario(int id);


    }
}
