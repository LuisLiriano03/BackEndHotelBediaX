using AutoMapper;
using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.Destinations.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Destination, GetDestination>()
                .ForMember(destination =>
                    destination.IsActive,
                    options => options.MapFrom(origin => origin.IsActive == true ? 1 : 0)
                );
        }
    }
}
