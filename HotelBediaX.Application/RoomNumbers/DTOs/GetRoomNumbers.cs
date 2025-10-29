using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomNumbers.DTOs
{
    public class GetRoomNumbers
    {
        public int RoomNumberId { get; set; }

        public string? RoomNumber1 { get; set; }

        public string? DescriptionRoomNumber { get; set; }
    }
}
