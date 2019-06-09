using AutoMapper;
using DAL.Models;
using userServices.Resources;

namespace userServices.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<UsersCustomerResource, UsersCustomer>();
            //.ForMember(u => u.User.LastIp, opt => opt.Ignore()); 
            CreateMap<UsersProfiResource, UsersProfi>();
            //.ForMember(u => u.User.LastIp, opt => opt.Ignore()); 
            CreateMap<UserCredentialsResource, Users>();

        }
    }
}
