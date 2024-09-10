using AutoMapper;
using Humanizer;
using Repositorios.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class BaseServices<TEntity, Dto> : IBaseServices<TEntity, Dto> where TEntity : class
    {
        private readonly IBaseRepositorio<TEntity> _baseRepositorio;
        private readonly IMapper _mapper;

        public BaseServices(IBaseRepositorio<TEntity> repositorio, IMapper mapper)
        {
            _baseRepositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<bool> AlterarAsync(int id, Dto dto)
        {
            var buscaEntidade = _baseRepositorio.BuscarPorIdAsync(id);

            var entidade = _mapper.Map<TEntity>(buscaEntidade);
            
            return await _baseRepositorio.AlterarAsync(id, entidade);
        }

     

        public async Task<Dto> BuscarPorIdAsync(int id)
        {
            var entidade = await _baseRepositorio.BuscarPorIdAsync(id);
            var dto =  _mapper.Map<Dto>(entidade);

            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _baseRepositorio.DeleteAsync(id);
        }

        public async Task<bool> InserirAsync(Dto dto)
        {
            var entidade = _mapper.Map<TEntity>(dto);
            return await _baseRepositorio.InserirAsync(entidade);
        }

        public async Task<IEnumerable<TEntity>> PesquisarAsync()
        {
            return await _baseRepositorio.PesquisarAsync();
        }

       
    }
}
