using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Contexto
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }

        
    }
}
