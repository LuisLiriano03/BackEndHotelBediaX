using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.Destinations.DTOs
{
    public class GetDestination
    {
        public int DestinationId { get; set; }

        public string? DestinationName { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public string? DescriptionDestinations { get; set; }

        public decimal? EstimatedPrice { get; set; }

        public string? ImageUrl { get; set; }

        public bool? IsActive { get; set; }

    }
}
