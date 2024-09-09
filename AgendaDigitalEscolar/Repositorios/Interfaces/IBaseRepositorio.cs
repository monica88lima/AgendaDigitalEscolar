namespace Repositorios.Interfaces
{
    public interface IBaseRepositorio<TEntity>
    {
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<TEntity>> PesquisarAsync();
        Task<TEntity> BuscarPorIdAsync(int id);
        Task<bool> InserirAsync(TEntity entidade);
       
        Task<bool> AlterarAsync(int id, TEntity entidade);
    }
}
