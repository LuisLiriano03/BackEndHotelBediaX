using HotelBediaX.Application.PaymentsMethod.DTOs;
using HotelBediaX.Application.RoomsType.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.PaymentsMethod.Interfaces
{
    public interface IPaymentsMethodService
    {
        Task<List<GetPaymentsMethod>> GetAllPaymentsMethodAsync();
    }
}
