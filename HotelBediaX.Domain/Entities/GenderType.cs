using System;
using System.Collections.Generic;

namespace HotelBediaX.Domain.Entities;

public partial class GenderType
{
    public int GenderId { get; set; }

    public string? GenderName { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
