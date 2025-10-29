using HotelBediaX.Application.GendersType.DTOs;
using HotelBediaX.Application.IdentificationsType.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.GendersType.Interfaces
{
    public interface IGendersTypeService
    {
        Task<List<GetGendersType>> GetAllGenderTypeAsync();
    }
}
