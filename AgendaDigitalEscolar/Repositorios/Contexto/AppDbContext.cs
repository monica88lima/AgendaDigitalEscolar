using Entidades;
using Entidades.Enun;
using Microsoft.EntityFrameworkCore;

namespace Repositorios.Contexto
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgendaDiaria>()
                .Property(e => e.RefeicaoStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (ERefeicaoStatus)Enum.Parse(typeof(ERefeicaoStatus), v));

            modelBuilder.Entity<AgendaDiaria>()
                .Property(e => e.SonoStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (ESonoStatus)Enum.Parse(typeof(ESonoStatus), v));

            modelBuilder.Entity<AgendaDiaria>()
                .Property(e => e.HigieneStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (EHigieneStatus)Enum.Parse(typeof(EHigieneStatus), v));
        }
    }
}
