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
            builder.HasKey(x => x.HotelExtraId);
        }
    }
}
