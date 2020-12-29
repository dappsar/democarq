using demo.Infrastructure.Identity.Models;
using demo.Web.Areas.Admin.Models;
using AutoMapper;

namespace demo.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}