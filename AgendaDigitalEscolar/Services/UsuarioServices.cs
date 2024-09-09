using AutoMapper;
using Entidades;

using Repositorios.Interfaces;
using Services.DTO;
using Services.Interfaces;

namespace Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IMapper _mapper;

        public UsuarioServices(IUsuarioRepositorio usuarioRepositorio, IMapper mapper)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
        }

        public async Task<bool> Login(string email, string password)
        {

            return await _usuarioRepositorio.Login(email, password);
        }

        public async Task<UsuarioDto> CadastrarUsuario(UsuarioDto usuario)
        {
            var novoUsuario = _mapper.Map<Usuario>(usuario);
            if (await ValidarEmailUnico(usuario.Email))
                throw new Exception("E-mail ja cadastrado!");

            if (await _usuarioRepositorio.CadastrarUsuario(novoUsuario))
            {
                usuario.Senha = "**********";
                return usuario;
            }
            else
            {
                throw new Exception("Erro ao tentar Cadastrar!");
            }


        }

        public async Task<bool> DeletaUsuario(int id)
        {
            var usuarioDto = await BuscarUsuarioId(id);

            var usuario = _mapper.Map<Usuario>(usuarioDto);

            return await _usuarioRepositorio.DeletaUsuario(usuario);

        }

        public async Task<bool> ValidarEmailUnico(string email)
        {

            return await _usuarioRepositorio.ValidarEmailUnico(email);
        }

        public async Task<UsuarioDto> BuscarUsuarioEmail(string email)
        {

            var usuario = _usuarioRepositorio.BuscaUsuarioEmail(email);
            var usuarioDto = _mapper.Map<UsuarioDto>(usuario);
            return usuarioDto;
        }

        public async Task<UsuarioDto> BuscarUsuarioId(int id)
        {

            var usuario = await _usuarioRepositorio.BuscaUsuarioID(id);
            var usuarioDto = _mapper.Map<UsuarioDto>(usuario);
            return usuarioDto;
        }

        public async Task<bool> AlterarSenha(string email, string senha)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                throw new Exception("Campos de senha e email são obrigatórios!");
            }
            return await _usuarioRepositorio.RedefinirSenha(email, senha);

        }

        public async Task<IEnumerable<UsuarioDto>> ListarTodosUsuario()
        {
            var listUsuarios = await _usuarioRepositorio.ListarUsuarios();
            if (listUsuarios.Count() == 0)
            {
                throw new Exception("Não há usuarios cadastrados!");
            }
            var listUsuarioDtos = _mapper.Map<List<UsuarioDto>>(listUsuarios);
            return listUsuarioDtos;
        }

        public async Task<bool> AlteraUsuario(UsuarioDto usuario)
        {
            var user = _mapper.Map<Usuario>(usuario);

            return await _usuarioRepositorio.AlteraUsuario(user);
        }

    }
}
