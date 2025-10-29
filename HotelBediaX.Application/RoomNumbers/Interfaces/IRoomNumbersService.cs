using HotelBediaX.Application.GendersType.DTOs;
using HotelBediaX.Application.RoomNumbers.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomNumbers.Interfaces
{
    public interface IRoomNumbersService
    {
        Task<List<GetRoomNumbers>> GetAllRoomNumbersAsync();
    }
}
