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
    public class RoomTypeExtraMap : IEntityTypeConfiguration<RoomTypeExtra>
    {
        public void Configure(EntityTypeBuilder<RoomTypeExtra> builder)
        {
            builder.ToTable("RoomTypeExtra");
            builder.HasKey(x => new { x.RoomTypeId, x.ExtraId });
            builder.HasOne(x => x.Extra).WithMany(x => x.RoomTypeExtras).HasForeignKey(x=>x.ExtraId).HasPrincipalKey(x=>x.Id);
            builder.HasOne(x => x.RoomType).WithMany(x => x.RoomTypeExtras).HasForeignKey(x => x.RoomTypeId).HasPrincipalKey(x=>x.Id);

            
        }
    }
}
