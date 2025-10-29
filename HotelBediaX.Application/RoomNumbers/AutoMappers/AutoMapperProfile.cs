using AutoMapper;
using HotelBediaX.Application.RoomNumbers.DTOs;
using HotelBediaX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomNumbers.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {

            CreateMap<RoomNumber, GetRoomNumbers>().ReverseMap();
        
        }
    }
}
