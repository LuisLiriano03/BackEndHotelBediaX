using HotelBediaX.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBediaX.Infrastructure.Context;

public partial class DbhotelBediaXContext : DbContext
{
    public DbhotelBediaXContext()
    {
    }

    public DbhotelBediaXContext(DbContextOptions<DbhotelBediaXContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Destination> Destinations { get; set; }

    public virtual DbSet<GenderType> GenderTypes { get; set; }

    public virtual DbSet<IdentificationType> IdentificationTypes { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<ReservationStatus> ReservationStatuses { get; set; }

    public virtual DbSet<RoomNumber> RoomNumbers { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomersId).HasName("PK__Customer__EB5B58FE320CB3F0");

            entity.Property(e => e.AddressCustomers)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CountryOfResidence)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.IdentificationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InternalNotes)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsVip).HasDefaultValue(true);
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Preferences)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalPayment).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Destination).WithMany(p => p.Customers)
                .HasForeignKey(d => d.DestinationId)
                .HasConstraintName("FK__Customers__Desti__5DCAEF64");

            entity.HasOne(d => d.Gender).WithMany(p => p.Customers)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK__Customers__Gende__5812160E");

            entity.HasOne(d => d.IdentificationType).WithMany(p => p.Customers)
                .HasForeignKey(d => d.IdentificationTypeId)
                .HasConstraintName("FK__Customers__Ident__571DF1D5");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Customers)
                .HasForeignKey(d => d.PaymentMethodId)
                .HasConstraintName("FK__Customers__Payme__5AEE82B9");

            entity.HasOne(d => d.ReservationStatus).WithMany(p => p.Customers)
                .HasForeignKey(d => d.ReservationStatusId)
                .HasConstraintName("FK__Customers__Reser__5BE2A6F2");

            entity.HasOne(d => d.RoomNumber).WithMany(p => p.Customers)
                .HasForeignKey(d => d.RoomNumberId)
                .HasConstraintName("FK__Customers__RoomN__59063A47");

            entity.HasOne(d => d.RoomType).WithMany(p => p.Customers)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK__Customers__RoomT__59FA5E80");
        });

        modelBuilder.Entity<Destination>(entity =>
        {
            entity.HasKey(e => e.DestinationId).HasName("PK__Destinat__DB5FE4CCA5BAFAD0");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescriptionDestinations)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DestinationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstimatedPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
        });

        modelBuilder.Entity<GenderType>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PK__GenderTy__4E24E9F7F81926BC");

            entity.ToTable("GenderType");

            entity.Property(e => e.GenderName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<IdentificationType>(entity =>
        {
            entity.HasKey(e => e.IdentificationTypeId).HasName("PK__Identifi__B8F30DC81486D312");

            entity.ToTable("IdentificationType");

            entity.Property(e => e.IdentificationTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId).HasName("PK__PaymentM__DC31C1D3E3A86E5E");

            entity.ToTable("PaymentMethod");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.PaymentMethodName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ReservationStatus>(entity =>
        {
            entity.HasKey(e => e.ReservationStatusId).HasName("PK__Reservat__DFC0EEAA3901497C");

            entity.ToTable("ReservationStatus");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomNumber>(entity =>
        {
            entity.HasKey(e => e.RoomNumberId).HasName("PK__RoomNumb__EFBFD627A554F974");

            entity.ToTable("RoomNumber");

            entity.Property(e => e.DescriptionRoomNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RoomNumber1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RoomNumber");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK__RoomType__BCC89631A57986C0");

            entity.ToTable("RoomType");

            entity.Property(e => e.DescriptionRoomType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RoomTypeName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
