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
    public class HotelExtraMap : IEntityTypeConfiguration<HotelExtra>
    {
        public void Configure(EntityTypeBuilder<HotelExtra> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ExtraName).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Price).HasColumnType("money");
        }
    }
}
