using System;
using System.Collections.Generic;

namespace HotelBediaX.Domain.Entities;

public partial class Customer
{
    public int CustomersId { get; set; }

    public string FullName { get; set; } = null!;

    public int? IdentificationTypeId { get; set; }

    public string? IdentificationNumber { get; set; }

    public DateOnly? BirthDate { get; set; }

    public int? GenderId { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? AddressCustomers { get; set; }

    public string? CountryOfResidence { get; set; }

    public DateOnly? CheckInDate { get; set; }

    public DateOnly? CheckOutDate { get; set; }

    public int? RoomNumberId { get; set; }

    public int? RoomTypeId { get; set; }

    public int? NumberOfGuests { get; set; }

    public int? PaymentMethodId { get; set; }

    public decimal? TotalPayment { get; set; }

    public int? ReservationStatusId { get; set; }

    public string? Preferences { get; set; }

    public bool? IsVip { get; set; }

    public string? InternalNotes { get; set; }

    public int? DestinationId { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual Destination? Destination { get; set; }

    public virtual GenderType? Gender { get; set; }

    public virtual IdentificationType? IdentificationType { get; set; }

    public virtual PaymentMethod? PaymentMethod { get; set; }

    public virtual ReservationStatus? ReservationStatus { get; set; }

    public virtual RoomNumber? RoomNumber { get; set; }

    public virtual RoomType? RoomType { get; set; }
}
