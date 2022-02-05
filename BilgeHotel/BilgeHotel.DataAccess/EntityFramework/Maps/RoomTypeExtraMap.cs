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
            builder.HasKey(x => x.RoomTypeId);
        }
    }
}
