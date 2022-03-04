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
    public class JobMap : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.JobName).HasMaxLength(50).IsRequired();
        }
    }
}
