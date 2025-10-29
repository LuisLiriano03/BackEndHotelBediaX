using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.GendersType.Exceptions
{
    public class GetGendersTypeFailedException : Exception
    {
        public override string Message { get; }

        public GetGendersTypeFailedException() : base()
        {
            Message = "No gender type found;";
        }
    }
}
