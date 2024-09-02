using AutoMapper;
using Entidades;

namespace Services.DTO
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            //CreateMap<Usuario, UsuarioDto>().ReverseMap();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            // Encontrar todos os tipos que implementam IMapFrom<>
            var maps = (from t in assemblies.SelectMany(a => a.GetTypes())
                        from i in t.GetInterfaces()
                        where i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)
                        let entityType = i.GetGenericArguments()[0]
                        select new
                        {
                            Source = entityType,
                            Destination = t
                        }).ToList();

            // Criar mapeamentos para cada par de entidade/DTO
            foreach (var map in maps)
            {
                CreateMap(map.Source, map.Destination).ReverseMap();
            }

        }
    }
}
