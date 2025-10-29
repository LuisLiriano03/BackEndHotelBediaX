using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Application.IdentificationsType.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.IdentificationsType.Interfaces
{
    public interface IdentificationTypeService
    {
        Task<List<GetIdentificationsType>> GetAllIdentificationTypeAsync();
    }
}
