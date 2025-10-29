using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.IdentificationsType.Exceptions
{
    public class GetIdentificationsTypeFailedException : Exception
    {
        public override string Message { get; }

        public GetIdentificationsTypeFailedException() : base()
        {
            Message = "No Identification type found;";
        }
    }
}
