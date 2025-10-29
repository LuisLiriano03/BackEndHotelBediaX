using HotelBediaX.Application.Destinations.Interfaces;
using HotelBediaX.Application.Destinations.Services;
using HotelBediaX.Application.GendersType.Interfaces;
using HotelBediaX.Application.GendersType.Services;
using HotelBediaX.Application.IdentificationsType.Interfaces;
using HotelBediaX.Application.IdentificationsType.Services;
using HotelBediaX.Application.PaymentsMethod.Interfaces;
using HotelBediaX.Application.PaymentsMethod.Services;
using HotelBediaX.Application.RoomNumbers.Interfaces;
using HotelBediaX.Application.RoomNumbers.Services;
using HotelBediaX.Application.RoomsType.Interfaces;
using HotelBediaX.Application.RoomsType.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application
{
    public static class IoC
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            return service
                .AddScoped<IDestinationsService, DestinationsService>()
                .AddScoped<IdentificationTypeService, IdentificatonsTypeService>()
                .AddScoped<IGendersTypeService, GendersTypeServices>()
                .AddScoped<IRoomNumbersService, RoomNumbersService>()
                .AddScoped<IRoomsTypeService, RoomsTypeService>()
                .AddScoped<IPaymentsMethodService, PaymentsMethodService>();
                


        }

    }
}
