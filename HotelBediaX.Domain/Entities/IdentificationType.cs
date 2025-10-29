using System;
using System.Collections.Generic;

namespace HotelBediaX.Domain.Entities;

public partial class IdentificationType
{
    public int IdentificationTypeId { get; set; }

    public string? IdentificationTypeName { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
