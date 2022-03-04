using BilgeHotel.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.DataAccess.EntityFramework.Maps.Concrete
{
    public class ShiftTimeMap : IEntityTypeConfiguration<ShiftTime>
    {
        public void Configure(EntityTypeBuilder<ShiftTime> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.StopTime).IsRequired();
        }
    }
}
