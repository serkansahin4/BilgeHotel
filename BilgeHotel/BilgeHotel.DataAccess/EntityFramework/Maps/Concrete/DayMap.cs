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
    public class DayMap : IEntityTypeConfiguration<Day>
    {
        public void Configure(EntityTypeBuilder<Day> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DayName).HasMaxLength(15).IsRequired();
        }
    }
}
