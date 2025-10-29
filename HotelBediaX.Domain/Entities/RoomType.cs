using System;
using System.Collections.Generic;

namespace HotelBediaX.Domain.Entities;

public partial class RoomType
{
    public int RoomTypeId { get; set; }

    public string? RoomTypeName { get; set; }

    public string? DescriptionRoomType { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
