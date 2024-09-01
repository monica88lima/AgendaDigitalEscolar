using Repositorios.Contexto;
using System;
using Entidades;
using Repositorios.Interfaces;

namespace Repositorios
{
    public class UsuarioRepositorio: IUsuarioRepositorio
    {
        private readonly AppDbContext _context;
        public UsuarioRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public bool Login(string email, string password)
        {
            return _context.Usuarios.Any(x => x.Email == email && x.Senha == password);
        }
        public bool CadastrarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            var sucesss = _context.SaveChanges();
            return sucesss == 1;
        }
        public bool ValidarEmailUnico(string email)
        {
            return _context.Usuarios.Any(x => x.Email == email);
        }

        public bool RedefinirSenha(string email, string password)
        {
            var usuario=  _context.Usuarios.FirstOrDefault(x => x.Email == email);
            if(usuario == null) return false;

            usuario.Senha = password;

             _context.Usuarios.Update(usuario);
            var sucess = _context.SaveChanges();
            return sucess == 1;
        }

        public Usuario BuscaUsuarioID(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.UsuarioId == id);
        }

        public Usuario BuscaUsuarioEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email == email);
        }
    }
}
