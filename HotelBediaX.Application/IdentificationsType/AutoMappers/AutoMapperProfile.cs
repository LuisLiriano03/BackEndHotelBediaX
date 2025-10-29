using AutoMapper;
using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Application.IdentificationsType.DTOs;
using HotelBediaX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.IdentificationsType.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<IdentificationType, GetIdentificationsType>().ReverseMap();
        }

    }

}
