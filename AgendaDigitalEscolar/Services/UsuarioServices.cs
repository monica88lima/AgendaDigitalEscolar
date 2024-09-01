using AutoMapper;
using Entidades;

using Repositorios.Interfaces;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool Login(string email, string password)
        {

            return _usuarioRepositorio.Login(email, password);
        }

        public UsuarioDto CadastrarUsuario(UsuarioDto usuario)
        {
            var novoUsuario = _mapper.Map<Usuario>(usuario);
            if (ValidarEmailUnico(usuario.Email))
                throw new Exception("E-mail ja cadastrado!");

            if (_usuarioRepositorio.CadastrarUsuario(novoUsuario))
            {
                usuario.Senha = "**********";
                return usuario;
            }
            else
            {
                throw new Exception("Erro ao tentar Cadastrar!");
            }


        }

        public bool ValidarEmailUnico(string email)
        {

            return _usuarioRepositorio.ValidarEmailUnico(email);
        }

        public bool RedefinirSenha(string email, string password)
        {

            return _usuarioRepositorio.RedefinirSenha(email, password);


        }
    }
}
