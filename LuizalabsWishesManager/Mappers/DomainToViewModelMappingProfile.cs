using AutoMapper;
using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuizalabsWishesManager.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {   
            CreateMap<User, UserViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Wish, WishViewModel>();
        }
    }
}
