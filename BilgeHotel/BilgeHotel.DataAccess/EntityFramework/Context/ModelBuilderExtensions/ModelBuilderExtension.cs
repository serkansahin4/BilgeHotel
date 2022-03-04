using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.DataAccess.EntityFramework.Context.ModelBuilderExtensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {

            builder.Entity<Bed>().HasData(
                new Bed { Id = 1, BedType = "Tek Kişilik" },
                new Bed { Id = 2, BedType = "Double" }
                );

            builder.Entity<Extra>().HasData(
                new Extra { Id = 1, ExtraName = "Klima" },
                new Extra { Id = 2, ExtraName = "Televizyon" },
                new Extra { Id = 3, ExtraName = "Saç Kurutma Makinesi" },
                new Extra { Id = 4, ExtraName = "Kablosuz İnternet" },
                new Extra { Id = 5, ExtraName = "Minibar" }
                );

            builder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Bekar Odası TekYat", RoomTypeName = "Tek Kişilik", Price = 100 },
                new RoomType { Id = 2, Name = "Bekar Odası DoubleYat", RoomTypeName = "Tek Kişilik", Price = 100 },

                 new RoomType { Id = 3, Name = "Çift Odası AyrıYat", RoomTypeName = "İki Kişilik", Price = 200 },
                  new RoomType { Id = 4, Name = "Çift Odası ÇiftYat", RoomTypeName = "İki Kişilik", Price = 150 },

                   new RoomType { Id = 5, Name = "Aile Odası AyrıYat", RoomTypeName = "Üç Kişilik", Price = 200 },
                    new RoomType { Id = 6, Name = "Aile Odası Çift Yanyana Cocuk AyrıYat", RoomTypeName = "Üç Kişilik", Price = 350 },

                    new RoomType { Id = 7, Name = "Sülale Odası Sülalecek Yat", RoomTypeName = "Dört Kişilik", Price = 750 },


                    new RoomType { Id = 8, Name = "Kral Dairesi DoubleYat", RoomTypeName = "Kral Dairesi", Price = 1000, }
                );

            #region RoomBed ComplexType
            builder.Entity<RoomBed>().HasData(
                  new RoomBed { BedId = 1, RoomTypeId = 1, Quantity = 1 },
                  new RoomBed { BedId = 2, RoomTypeId = 2, Quantity = 1 },

                  new RoomBed { RoomTypeId = 3, BedId = 1, Quantity = 2 },
                   new RoomBed { RoomTypeId = 4, BedId = 2, Quantity = 1 },

                  new RoomBed { BedId = 1, RoomTypeId = 5, Quantity = 3 },
                  new RoomBed { RoomTypeId = 6, BedId = 2, Quantity = 1 },
                  new RoomBed { RoomTypeId = 6, BedId = 1, Quantity = 1 },

                    new RoomBed { RoomTypeId = 7, BedId = 2, Quantity = 1 },
                     new RoomBed { RoomTypeId = 7, BedId = 1, Quantity = 2 },

                      new RoomBed { RoomTypeId = 8, BedId = 2, Quantity = 1 }
                );
            #endregion

            #region RoomTypeExtra ComplexType
            builder.Entity<RoomTypeExtra>().HasData(
                new RoomTypeExtra { RoomTypeId = 1, ExtraId = 1 },
                new RoomTypeExtra { RoomTypeId = 1, ExtraId = 2 },
                new RoomTypeExtra { RoomTypeId = 1, ExtraId = 3 },
                new RoomTypeExtra { RoomTypeId = 1, ExtraId = 4 },
                 new RoomTypeExtra { RoomTypeId = 2, ExtraId = 1 },
                new RoomTypeExtra { RoomTypeId = 2, ExtraId = 2 },
                new RoomTypeExtra { RoomTypeId = 2, ExtraId = 3 },
                new RoomTypeExtra { RoomTypeId = 2, ExtraId = 4 },

                new RoomTypeExtra { RoomTypeId = 3, ExtraId = 1 },
                 new RoomTypeExtra { RoomTypeId = 3, ExtraId = 2 },
                  new RoomTypeExtra { RoomTypeId = 3, ExtraId = 3 },
                   new RoomTypeExtra { RoomTypeId = 3, ExtraId = 4 },
                    new RoomTypeExtra { RoomTypeId = 3, ExtraId = 5 },
                    new RoomTypeExtra { RoomTypeId = 4, ExtraId = 1 },
                 new RoomTypeExtra { RoomTypeId = 4, ExtraId = 2 },
                  new RoomTypeExtra { RoomTypeId = 4, ExtraId = 3 },
                   new RoomTypeExtra { RoomTypeId = 4, ExtraId = 4 },
                    new RoomTypeExtra { RoomTypeId = 4, ExtraId = 5 },

                     new RoomTypeExtra { RoomTypeId = 5, ExtraId = 1 },
                 new RoomTypeExtra { RoomTypeId = 5, ExtraId = 2 },
                  new RoomTypeExtra { RoomTypeId = 5, ExtraId = 3 },
                   new RoomTypeExtra { RoomTypeId = 5, ExtraId = 4 },
                    new RoomTypeExtra { RoomTypeId = 5, ExtraId = 5 },

                new RoomTypeExtra { RoomTypeId = 6, ExtraId = 1 },
                 new RoomTypeExtra { RoomTypeId = 6, ExtraId = 2 },
                  new RoomTypeExtra { RoomTypeId = 6, ExtraId = 3 },
                   new RoomTypeExtra { RoomTypeId = 6, ExtraId = 4 },
                    new RoomTypeExtra { RoomTypeId = 6, ExtraId = 5 },

                     new RoomTypeExtra { RoomTypeId = 7, ExtraId = 1 },
                 new RoomTypeExtra { RoomTypeId = 7, ExtraId = 2 },
                  new RoomTypeExtra { RoomTypeId = 7, ExtraId = 3 },
                   new RoomTypeExtra { RoomTypeId = 7, ExtraId = 4 },
                    new RoomTypeExtra { RoomTypeId = 7, ExtraId = 5 },

                      new RoomTypeExtra { RoomTypeId = 8, ExtraId = 1 },
                 new RoomTypeExtra { RoomTypeId = 8, ExtraId = 2 },
                  new RoomTypeExtra { RoomTypeId = 8, ExtraId = 3 },
                   new RoomTypeExtra { RoomTypeId = 8, ExtraId = 4 },
                    new RoomTypeExtra { RoomTypeId = 8, ExtraId = 5 }

                );
            #endregion

            #region Image
            builder.Entity<Image>().HasData(
                new Image { Id = 1, RoomTypeId = 1, Path = "ABC.jpg" },
                new Image { Id = 2, RoomTypeId = 1, Path = "resepsiyon.jpg" },

                new Image { Id = 3, RoomTypeId = 2, Path = "ABC.jpg" },
                new Image { Id = 4, RoomTypeId = 2, Path = "resepsiyon.jpg" },

                new Image { Id = 5, RoomTypeId = 3, Path = "ABC.jpg" },
                new Image { Id = 6, RoomTypeId = 3, Path = "resepsiyon.jpg" },

                new Image { Id = 7, RoomTypeId = 4, Path = "ABC.jpg" },
                new Image { Id = 8, RoomTypeId = 4, Path = "resepsiyon.jpg" },

                new Image { Id = 9, RoomTypeId = 5, Path = "ABC.jpg" },
                new Image { Id = 10, RoomTypeId = 5, Path = "resepsiyon.jpg" },

                new Image { Id = 11, RoomTypeId = 6, Path = "ABC.jpg" },
                new Image { Id = 12, RoomTypeId = 6, Path = "resepsiyon.jpg" },

                new Image { Id = 13, RoomTypeId = 7, Path = "ABC.jpg" },
                new Image { Id = 14, RoomTypeId = 7, Path = "resepsiyon.jpg" },

                new Image { Id = 15, RoomTypeId = 8, Path = "ABC.jpg" },
                new Image { Id = 16, RoomTypeId = 8, Path = "resepsiyon.jpg" }
                );
            #endregion

            #region Manzara
            builder.Entity<RoomView>().HasData(
                new RoomView { Id = 1, ViewName = "Deniz" },
                new RoomView { Id = 2, ViewName = "Duvar" }
                );
            #endregion
            #region RoomSituations
            builder.Entity<RoomSituation>().HasData(
                new RoomSituation { Id = 1, StatusName = "Hazır" },
                new RoomSituation { Id = 2, StatusName = "Meşgul" },
                new RoomSituation { Id = 3, StatusName = "Bakımda" },
                new RoomSituation { Id = 4, StatusName = "Hazırlanıyor" }
                );
            #endregion
            #region Rooms
            builder.Entity<Room>().HasData(
                 //Tek Kişilik Odalar (Birinci Kat)
                 new Room { RoomName = 100, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 101, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 102, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 103, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 104, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 105, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 106, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 107, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 108, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 109, RoomSize = 50, RoomTypeId = 1, RoomViewId = 1, RoomSituationId = 1 },

                 //Tek Kişilik Odalar (İkinci Kat)                                     
                 new Room { RoomName = 200, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 201, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 202, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 203, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 204, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 205, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 206, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 207, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 208, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 209, RoomSize = 50, RoomTypeId = 2, RoomViewId = 1, RoomSituationId = 1 },

                 //Çift Kişilik Odalar (İkinci Kat)                                   
                 new Room { RoomName = 210, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 211, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 212, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 213, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 214, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 215, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 216, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 217, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 218, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 219, RoomSize = 50, RoomTypeId = 3, RoomViewId = 1, RoomSituationId = 1 },

                 //Çift Kişilik Odalar (Üçüncü Kat)                                    

                 new Room { RoomName = 300, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 301, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 302, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 303, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 304, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 305, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 306, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 307, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 308, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 309, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },

                 //Çift Kişilik Odalar (Dördüncü Kat)                                  
                 new Room { RoomName = 400, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 401, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 402, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 403, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 404, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 405, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 406, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 407, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 408, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 409, RoomSize = 50, RoomTypeId = 4, RoomViewId = 1, RoomSituationId = 1 },

                 //Üç Kişilik Odalar (Birinci Kat)                                     
                 new Room { RoomName = 110, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 111, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 112, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 113, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 114, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 115, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 116, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 117, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 118, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 119, RoomSize = 50, RoomTypeId = 5, RoomViewId = 1, RoomSituationId = 1 },

                 // Üç Kişilik Odalar (Üçüncü Kat)                                    
                 new Room { RoomName = 310, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 311, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 312, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 313, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 314, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 315, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 316, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 317, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 318, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 319, RoomSize = 50, RoomTypeId = 6, RoomViewId = 1, RoomSituationId = 1 },

                 //Dört Kişilik Odalar (Dördüncü Kat)                                  
                 new Room { RoomName = 410, RoomSize = 50, RoomTypeId = 7, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 411, RoomSize = 50, RoomTypeId = 7, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 412, RoomSize = 50, RoomTypeId = 7, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 413, RoomSize = 50, RoomTypeId = 7, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 414, RoomSize = 50, RoomTypeId = 7, RoomViewId = 1, RoomSituationId = 1 },
                 new Room { RoomName = 415, RoomSize = 50, RoomTypeId = 7, RoomViewId = 1, RoomSituationId = 1 },

                 new Room { RoomName = 420, RoomSize = 750, RoomTypeId = 8, RoomViewId = 1, RoomSituationId = 1 }

                );
            #endregion

            #region Package
            builder.Entity<Package>().HasData(
                new Package { Id = 1, PackageName = "Tam Pansiyon" },
                new Package { Id = 2, PackageName = "Herşey Dahil" }
                );
            #endregion

            #region Customer
            builder.Entity<Customer>().HasData(
                new Customer { Id = 1, BirthDate = new DateTime(1999, 10, 10), Email = "serkana607@gmail.com", FirstName = "Serkan", LastName = "Şahin", Phone = "25365485652", TcIdentityNo = "64657172255" }
                );
            #endregion

            #region Roles
            builder.Entity<Role>().HasData(
                new Role { Id=1, RoleName="Admin"}
                );
            #endregion
            #region Department
            builder.Entity<Department>().HasData(
                new Department { Id=1, DepartmentName="Bilişim" }
                );
            #endregion

            

            #region Job
            builder.Entity<Job>().HasData(
                new Job { Id=1, JobName="Garson" }
                );
            #endregion
            #region Employee
            builder.Entity<Employee>().HasData(
                new Employee { Id=1,  Adress="Sırasöğütler", FirstName="Osman", LastName="Şahin", Phone="12345678955", RoleId=1, Salary=500, DepartmentId=1 }
                );
            #endregion

            #region Day
            builder.Entity<Day>().HasData(
                new Day { Id = 1, DayName = "Pazartesi" },
                new Day { Id = 2, DayName = "Salı" },
                new Day { Id = 3, DayName = "Çarşamba" },
                new Day { Id = 4, DayName = "Perşembe" },
                new Day { Id = 5, DayName = "Cuma" },
                new Day { Id = 6, DayName = "Cumartesi" },
                new Day { Id = 7, DayName = "Pazar" }
                );
            #endregion

            #region ShiftTime
            builder.Entity<ShiftTime>().HasData(
                new ShiftTime { Id = 1, StartTime = TimeSpan.Zero, StopTime = TimeSpan.Zero }
                );
            #endregion
            #region EmployeeJob
            builder.Entity<EmployeeJob>().HasData(
                new EmployeeJob { DayId=1, EmployeeId=1, JobId=1, ShiftTimeId=1 }
                );
            #endregion
            #region Shifts
            builder.Entity<Shift>().HasData(
                new Shift { EmployeeJobId=1, StartShift=DateTime.Now, StopShift=DateTime.Now, Id=1, ExtraTimeStop=DateTime.Now }
                );
            #endregion

            #region Reservation
            Guid key = Guid.NewGuid();
            builder.Entity<Reservation>().HasData(
                new Reservation { Id = key, CustomerId = 1 }
                );
            #endregion

            #region HotelExtra
            builder.Entity<HotelExtra>().HasData(
                new HotelExtra { Id=1, ExtraName="Şarap", Price=150 }
                );

            #endregion
            #region ReservationOutHotelExtra
            builder.Entity<ReservationOutHotelExtra>().HasData(
                new ReservationOutHotelExtra { HotelExtraId=1, ReservationId= key, Quantity=5 }
                );
            #endregion
            #region Card
            Guid cardıD = Guid.NewGuid();
            builder.Entity<Card>().HasData(new Card { Id= cardıD, CardNumber="selam", CardType="Ziraat", EndDate="02/05", Cv2="ABC" });
                #endregion
            #region ReservationDetail
            builder.Entity<ReservationDetail>().HasData(
                new ReservationDetail { ReservationId = key, PackageId = 1,RoomId = 101, CheckInDate = new DateTime(2022, 4, 5, 14, 0, 0), CheckOutDate = new DateTime(2022, 4, 6, 10, 0, 0), CreatedDate = DateTime.Now, Discount = 22, DiscountedPrice = 150, CardId= cardıD }
                );
            #endregion

        }
    }
}
