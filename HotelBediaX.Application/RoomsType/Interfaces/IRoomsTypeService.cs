using HotelBediaX.Application.RoomsType.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomsType.Interfaces
{
    public interface IRoomsTypeService
    {
        Task<List<GetRoomsType>> GetAllRoomsTypeAsync();
    }
}
