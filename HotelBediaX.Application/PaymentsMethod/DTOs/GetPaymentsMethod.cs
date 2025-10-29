using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.PaymentsMethod.DTOs
{
    public class GetPaymentsMethod
    {

        public int PaymentMethodId { get; set; }

        public string? PaymentMethodName { get; set; }


    }
}
