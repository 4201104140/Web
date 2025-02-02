﻿using AutoMapper;
using Shop.DataModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class MyMap : Profile
    {
        public MyMap()
        {
            CreateMap<HangHoa, HangHoaView>().ReverseMap();
            //CreateMap<HangHoa, Hang>
            CreateMap<HangHoa, HangHoaChiTiet>();
            //CreateMap<Category, CategoryView>();
        }
    }
}
