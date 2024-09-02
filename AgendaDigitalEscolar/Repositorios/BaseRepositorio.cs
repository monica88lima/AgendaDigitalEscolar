using Microsoft.EntityFrameworkCore;
using Repositorios.Contexto;
using Repositorios.Interfaces;

namespace Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        public BaseRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var resp = await _context.Set<TEntity>().FindAsync(id);

            if (resp is null)
                return false;

            _context.Set<TEntity>().Remove(resp);
            return await _context.SaveChangesAsync() == 1;

        }

        public async Task<IEnumerable<TEntity>> PesquisarAsync()
        {
           return  await _context
            .Set<TEntity>()
            .AsNoTracking()
            .ToListAsync();

          
        }

        public async Task<TEntity> BuscarPorIdAsync(int id)
        {
                     
            return await _context.Set<TEntity>().FindAsync(id);

        }

        public async Task<bool> InserirAsync(TEntity entidade)
        {
            await _context.Set<TEntity>().AddAsync(entidade);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> AlterarAsync(int id, TEntity entidade)
        {
            var entity = await BuscarPorIdAsync(id);

            if (entity is null)
                return false;

            _context.Set<TEntity>().Update(entity);
            return await _context.SaveChangesAsync() == 1;
        }
    }

}

