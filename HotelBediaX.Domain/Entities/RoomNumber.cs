using System;
using System.Collections.Generic;

namespace HotelBediaX.Domain.Entities;

public partial class RoomNumber
{
    public int RoomNumberId { get; set; }

    public string? RoomNumber1 { get; set; }

    public string? DescriptionRoomNumber { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
