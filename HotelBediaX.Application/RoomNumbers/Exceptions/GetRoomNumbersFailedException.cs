using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomNumbers.Exceptions
{
    public class GetRoomNumbersFailedException : Exception
    {
        public override string Message { get; }

        public GetRoomNumbersFailedException() : base()
        {
            Message = "No room number found;";
        }
    }
}
