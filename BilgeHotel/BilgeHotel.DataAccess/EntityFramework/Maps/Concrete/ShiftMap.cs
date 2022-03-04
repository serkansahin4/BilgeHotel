using BilgeHotel.Entities.ComplexType;
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
    public class ShiftMap : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StartShift).IsRequired();
            builder.Property(x => x.StopShift).IsRequired();
            builder.Property(x => x.ExtraTimeStop).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.EmployeeJobId).IsRequired();
        }
    }
}
