using System;
using System.Collections.Generic;

namespace HotelBediaX.Domain.Entities;

public partial class ReservationStatus
{
    public int ReservationStatusId { get; set; }

    public string? StatusName { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
