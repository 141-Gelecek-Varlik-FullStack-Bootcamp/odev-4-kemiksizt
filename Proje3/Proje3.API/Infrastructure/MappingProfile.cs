using AutoMapper;
using Proje3.Model.Product;

namespace Proje3.API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model.User.User, DB.Entities.User>();
            CreateMap<DB.Entities.User, Model.User.User>();


            CreateMap<InsertProduct, DB.Entities.Product>();
            CreateMap<DB.Entities.Product, ProductDetail>();
        }
    }
}
