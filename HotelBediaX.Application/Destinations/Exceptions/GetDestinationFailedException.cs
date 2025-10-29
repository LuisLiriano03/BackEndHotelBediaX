using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.Destinations.Exceptions
{
    public class GetDestinationFailedException : Exception
    {
        public override string Message { get; }

        public GetDestinationFailedException() : base()
        {
            Message = "No Destination found;";
        }

    }
}
