
using Advertisement.Application.Entities;
using Advertisement.Application.ViewModel;
using AutoMapper;

namespace Advertisement.Application
{
    public class AutomapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile<MapperProfile>();
                config.CreateMissingTypeMaps = true;
            }
         );
        }
    }

    internal sealed class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RegisterViewModel, User>();
        }
    }
}
