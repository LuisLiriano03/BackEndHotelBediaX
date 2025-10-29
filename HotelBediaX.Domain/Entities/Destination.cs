using System;
using System.Collections.Generic;

namespace HotelBediaX.Domain.Entities;

public partial class Destination
{
    public int DestinationId { get; set; }

    public string? DestinationName { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? DescriptionDestinations { get; set; }

    public decimal? EstimatedPrice { get; set; }

    public string? ImageUrl { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
