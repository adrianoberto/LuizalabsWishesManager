using AutoMapper;
using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuizalabsWishesManager.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<NewUserViewModel, User>();
            CreateMap<ProductViewModel, Product>();
            CreateMap<NewProductViewModel, Product>();
            CreateMap<ProductWishViewModel, WishProduct>();
            CreateMap<WishViewModel, Wish>();
        } 
    }
}
