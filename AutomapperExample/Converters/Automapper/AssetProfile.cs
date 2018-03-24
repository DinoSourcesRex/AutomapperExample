using AutoMapper;

namespace AutomapperExample.Converters.Automapper
{
    public class AssetProfile : Profile
    {
        public AssetProfile()
        {
            // Api to business
            CreateMap<Api.Models.Asset, Business.Models.Asset>()
                .ForMember(d => d.CustomBusinessProperty, o => o.MapFrom(s => s.CustomApiProperty));
            // Business to data
            CreateMap<Business.Models.Asset, Repository.Models.Asset>()
                .ForMember(d => d.CustomRepositoryProperty, o => o.MapFrom(s => s.CustomBusinessProperty));
            // Data to business
            CreateMap<Repository.Models.Asset, Business.Models.Asset>()
                .ForMember(d => d.CustomBusinessProperty, o => o.MapFrom(s => s.CustomRepositoryProperty));
            // Business to Api
            CreateMap<Business.Models.Asset, Api.Models.Asset>()
                .ForMember(d => d.CustomApiProperty, o => o.MapFrom(s => s.CustomBusinessProperty));
        }
    }
}
