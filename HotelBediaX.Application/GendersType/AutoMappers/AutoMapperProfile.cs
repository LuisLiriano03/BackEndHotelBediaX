using AutoMapper;
using HotelBediaX.Application.GendersType.DTOs;
using HotelBediaX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.GendersType.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<GenderType, GetGendersType>().ReverseMap();
        }
    }
}
