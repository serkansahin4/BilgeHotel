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
            builder.HasKey(x => x.BedId);
        }
    }
}
