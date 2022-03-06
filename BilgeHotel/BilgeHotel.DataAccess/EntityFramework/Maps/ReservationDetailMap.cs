using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.DataAccess.EntityFramework.Maps
{
    public class ReservationDetailMap : IEntityTypeConfiguration<ReservationDetail>
    {
        public void Configure(EntityTypeBuilder<ReservationDetail> builder)
        {
            builder.ToTable("ReservationDetails");
            builder.HasKey(x => x.ReservationId);
            builder.HasOne(x => x.Package).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.PackageId).HasPrincipalKey(x => x.Id);
            builder.HasOne<Reservation>(x => x.Reservation).WithOne(x => x.ReservationDetail).HasForeignKey<Reservation>(x => x.Id);
            builder.HasOne(x => x.Room).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.RoomId).HasPrincipalKey(x => x.RoomName);
            builder.HasOne(x => x.Card).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.CardId).HasPrincipalKey(x => x.Id);

            builder.Property(x => x.DiscountedPrice).HasColumnType("money");
        }
    }
}
