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
    public class RoomViewMap : IEntityTypeConfiguration<RoomView>
    {
        public void Configure(EntityTypeBuilder<RoomView> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ViewName).HasMaxLength(50).IsRequired();
        }
    }
}
