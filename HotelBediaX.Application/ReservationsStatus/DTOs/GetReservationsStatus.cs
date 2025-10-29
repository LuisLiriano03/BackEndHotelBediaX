using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.ReservationsStatus.DTOs
{
    public class GetReservationsStatus
    {

        public int ReservationStatusId { get; set; }

        public string? StatusName { get; set; }
    }
}
