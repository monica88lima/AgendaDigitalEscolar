namespace Services.Interfaces;

public interface IBaseServices<TEntity, Dto>
{
    Task<bool> AlterarAsync(int id, Dto dto);

    Task<Dto> BuscarPorIdAsync(int id);

    Task<bool> DeleteAsync(int id);

    Task<bool> InserirAsync(Dto dto);

    Task<IEnumerable<TEntity>> PesquisarAsync();
}
