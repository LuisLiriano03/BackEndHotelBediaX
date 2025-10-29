using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.PaymentsMethod.Exceptions
{
    public class GetPaymentsMethodFailedException : Exception
    {

        public override string Message { get; }

        public GetPaymentsMethodFailedException() : base()
        {
            Message = "No room number found;";
        }

    }
}
