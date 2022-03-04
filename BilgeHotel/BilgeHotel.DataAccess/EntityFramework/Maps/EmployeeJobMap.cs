using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.DataAccess.EntityFramework.Maps
{
    public class EmployeeJobMap : IEntityTypeConfiguration<EmployeeJob>
    {
        public void Configure(EntityTypeBuilder<EmployeeJob> builder)
        {
            builder.HasKey(x => x.EmployeeId);
            builder.HasOne<Employee>(x => x.Employee).WithOne(x => x.EmployeeJob).HasForeignKey<Employee>(x => x.Id);
        }
    }
}
