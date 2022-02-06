using BilgeHotel.Entities.ComplexType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.DataAccess.EntityFramework.Maps
{
    public class ReservationOutHotelExtraMap : IEntityTypeConfiguration<ReservationOutHotelExtra>
    {
        public void Configure(EntityTypeBuilder<ReservationOutHotelExtra> builder)
        {
            builder.HasKey(x => new { x.HotelExtraId,x.ReservationId });
            builder.ToTable("ReservationOutHotelExtras");
            builder.HasOne(x => x.HotelExtra).WithMany(x => x.ReservationOutHotelExtras).HasForeignKey(x => x.HotelExtraId).HasPrincipalKey(x => x.Id);
            builder.HasOne(x => x.Reservation).WithMany(x => x.ReservationOutHotelExtras).HasForeignKey(x => x.ReservationId).HasPrincipalKey(x => x.Id);
        }
    }
}
