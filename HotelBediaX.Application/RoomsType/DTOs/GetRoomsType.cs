using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomsType.DTOs
{
    public class GetRoomsType
    {
        public int RoomTypeId { get; set; }

        public string? RoomTypeName { get; set; }

        public string? DescriptionRoomType { get; set; }
    }
}
