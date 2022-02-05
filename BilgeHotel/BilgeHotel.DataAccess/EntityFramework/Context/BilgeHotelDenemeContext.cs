using BilgeHotel.DataAccess.EntityFramework.Maps;
using BilgeHotel.DataAccess.EntityFramework.Maps.Concrete;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.DataAccess.EntityFramework.Context
{
    public class BilgeHotelDenemeContext : DbContext
    {
        public BilgeHotelDenemeContext(DbContextOptions<BilgeHotelDenemeContext> db) : base(db)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ComplexType
            modelBuilder.ApplyConfiguration(new ReservationDetailMap());
            modelBuilder.ApplyConfiguration(new ReservationOutHotelExtraMap());
            modelBuilder.ApplyConfiguration(new RoomBedMap());
            modelBuilder.ApplyConfiguration(new RoomTypeExtraMap());

            //Concrete
            modelBuilder.ApplyConfiguration(new RoomMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Bed> Beds { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<HotelExtra> HotelExtras { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomSituation> RoomSituations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomView> RoomViews { get; set; }
        public DbSet<Shift> Shifts { get; set; }


        public DbSet<ReservationDetail> ReservationDetails { get; set; }
        public DbSet<ReservationOutHotelExtra> ReservationOutHotelExtras { get; set; }
        public DbSet<RoomBed> RoomBeds { get; set; }
        public DbSet<RoomTypeExtra> RoomTypeExtras { get; set; }

    }
}
