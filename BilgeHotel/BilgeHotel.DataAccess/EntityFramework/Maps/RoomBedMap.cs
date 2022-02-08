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
    public class RoomBedMap : IEntityTypeConfiguration<RoomBed>
    {
        public void Configure(EntityTypeBuilder<RoomBed> builder)
        {
            builder.ToTable("RoomBeds");
            builder.HasKey(x => new { x.BedId, x.RoomTypeId });
            builder.HasOne(x => x.Bed).WithMany(x => x.RoomBeds).HasForeignKey(x => x.BedId).HasPrincipalKey(x => x.Id);
            builder.HasOne(x => x.RoomType).WithMany(x => x.RoomBeds).HasForeignKey(x => x.RoomTypeId).HasPrincipalKey(x => x.Id);
            
        }
    }
}
