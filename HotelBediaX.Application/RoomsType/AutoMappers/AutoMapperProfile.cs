using AutoMapper;
using HotelBediaX.Application.RoomsType.DTOs;
using HotelBediaX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomsType.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<RoomType, GetRoomsType>().ReverseMap();
        }
    }
}
