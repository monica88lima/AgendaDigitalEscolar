using Entidades;
using Microsoft.EntityFrameworkCore;
using Repositorios.Contexto;
using Repositorios.Interfaces;

namespace Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly AppDbContext _context;
        public UsuarioRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Login(string email, string password)
        {
            return await _context.Usuario.AnyAsync(x => x.Email == email && x.Senha == password);
        }
        public async Task<bool> CadastrarUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            var sucesss = await _context.SaveChangesAsync();
            return sucesss == 1;
        }
        public async Task<bool> ValidarEmailUnico(string email)
        {
            return await _context.Usuario.AnyAsync(x => x.Email == email);
        }

        public async Task<bool> RedefinirSenha(string email, string password)
        {
            var usuario = await _context.Usuario.FirstOrDefaultAsync(x => x.Email == email);
            if (usuario == null) return false;

            usuario.Senha = password;

            _context.Usuario.Update(usuario);
            var sucess = _context.SaveChanges();
            return sucess == 1;
        }

        public async Task<Usuario> BuscaUsuarioID(int id)
        {
            return await _context.Usuario.FirstAsync(x => x.UsuarioId == id);
        }

        public async Task<Usuario> BuscaUsuarioEmail(string email)
        {
            return await _context.Usuario.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<IEnumerable<Usuario>> ListarUsuarios()
        {
            return await _context.Usuario.ToListAsync();
        }

        public async Task<bool> AlteraUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            var foiAlterado = await _context.SaveChangesAsync();

            return foiAlterado == 1;
        }

        public async Task<bool> DeletaUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Deleted;
            var foiDeletado = await _context.SaveChangesAsync();

            return foiDeletado == 1;
        }
    }
}
