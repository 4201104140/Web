using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tai.DataModels;
using Tai.Models.ProductModels;

namespace Tai.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductView>().ReverseMap();
            CreateMap<Product, ProductDetail>().ReverseMap();
        }
    }
}
