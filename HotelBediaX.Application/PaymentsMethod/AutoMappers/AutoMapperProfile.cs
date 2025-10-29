using AutoMapper;
using HotelBediaX.Application.PaymentsMethod.DTOs;
using HotelBediaX.Application.RoomsType.DTOs;
using HotelBediaX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.PaymentsMethod.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PaymentMethod, GetPaymentsMethod>().ReverseMap();
        }
    }
}
