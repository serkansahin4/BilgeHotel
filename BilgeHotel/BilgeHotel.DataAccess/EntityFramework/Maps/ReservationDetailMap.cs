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
    public class ReservationDetailMap : IEntityTypeConfiguration<ReservationDetail>
    {
        public void Configure(EntityTypeBuilder<ReservationDetail> builder)
        {
            builder.ToTable("ReservationDetails");
            builder.HasKey(x => new { x.ReservationId, x.PackageId, x.RoomId });
            builder.HasOne(x => x.Package).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.PackageId).HasPrincipalKey(x => x.Id);
            builder.HasOne(x => x.Reservation).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.ReservationId).HasPrincipalKey(x => x.Id);
            builder.HasOne(x => x.Room).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.RoomId).HasPrincipalKey(x => x.RoomName);
            
        }
    }
}
