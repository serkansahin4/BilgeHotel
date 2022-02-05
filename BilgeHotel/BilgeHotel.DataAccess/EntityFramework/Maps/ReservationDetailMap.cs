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
            builder.HasKey(x => new { x.ReservationId, x.PackageId, x.RoomId });

        }
    }
}
