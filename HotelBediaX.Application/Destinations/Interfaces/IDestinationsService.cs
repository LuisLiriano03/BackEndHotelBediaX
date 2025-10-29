using HotelBediaX.Application.Destinations.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.Destinations.Interfaces
{
    public interface IDestinationsService
    {
        Task<List<GetDestination>> GetAllDestinationAsync();
    }

}
