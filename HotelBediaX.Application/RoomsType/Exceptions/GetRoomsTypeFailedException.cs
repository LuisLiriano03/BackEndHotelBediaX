using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomsType.Exceptions
{
    public class GetRoomsTypeFailedException : Exception
    {
        public override string Message { get; }

        public GetRoomsTypeFailedException() : base()
        {
            Message = "No room number found;";
        }
    }
}
