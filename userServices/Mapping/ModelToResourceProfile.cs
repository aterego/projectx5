using AutoMapper;
using BLL.Security.Tokens;
using DAL.Models;
using userServices.Resources;

namespace userServices.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Categories, CategoriesResource>();
            /*
            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
            */
            CreateMap<Users, UsersResource>();
            CreateMap<AccessToken, AccessTokenResource>()
                .ForMember(a => a.AccessToken, opt => opt.MapFrom(a => a.Token))
                .ForMember(a => a.RefreshToken, opt => opt.MapFrom(a => a.RefreshToken.Token))
                .ForMember(a => a.Expiration, opt => opt.MapFrom(a => a.Expiration))
                .ForMember(a => a.Role, opt => opt.MapFrom(a => a.Role));

        }
    }
}
