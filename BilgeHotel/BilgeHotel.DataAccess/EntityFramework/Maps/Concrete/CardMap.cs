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
    public class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CardNumber).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.CardType).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Cv2).HasMaxLength(6).IsRequired(true);
            builder.Property(x => x.EndDate).HasMaxLength(6).IsRequired(true);
        }
    }
}
