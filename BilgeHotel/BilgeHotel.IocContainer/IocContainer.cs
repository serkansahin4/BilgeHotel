using BilgeHotel.Business.Abstract;
using BilgeHotel.Business.Concrete;
using BilgeHotel.Core.MyTools.Abstract;
using BilgeHotel.Core.MyTools.Concrete;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.DataAccess.EntityFramework;
using BilgeHotel.DataAccess.EntityFramework.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.IocContainer
{
    public static class IocContainer
    {
        public static void IocConfiguration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(EfEntityRepository<>)); //Scope Olmasının Sebebi
                                                                                     //İçerisindeki operasyonları her kullanan kişi
                                                                                     //İçin yeniden bir newleme yapmaması.
                                                                                     //Same(Aynı) Instance    New ınstance

            services.AddTransient<IBedService, BedManager>();                        //Servisler İstekler doğrultusunda
                                                                                     //Ayağa Kaldırıldığı için Transient
                                                                                     //New Instance
                                                                                     //New Instance

            services.AddTransient<IDateManagementExtension, DateManagementExtension>();




            services.AddTransient<ICustomerService, CustomerManager>();
            services.AddTransient<IPackageService, PackageManager>();
            services.AddTransient<ICardService, CardManager>();

            services.AddTransient<IDepartmentService, DepartmentManager>();


            services.AddTransient<IExtraService, ExtraManager>();
            services.AddTransient<IEmployeeService, EmployeeManager>();


            services.AddTransient<IHotelExtraService, HotelExtraManager>();

            services.AddTransient<IReservationOutHotelExtraService, ReservationOutHotelExtraManager>();
            services.AddTransient<IRoleService, RoleManager>();
            services.AddTransient<IRoomBedService, RoomBedManager>();
            services.AddTransient<IRoomTypeService, RoomTypeManager>();
            services.AddTransient<IRoomService, RoomManager>();
            services.AddTransient<IRoomTypeExtraService, RoomTypeExtraManager>();
            services.AddTransient<IRoomViewService, RoomViewManager>();
            services.AddTransient<IRoomSituationService, RoomSituationManager>();
            services.AddTransient<IReservationService, ReservationManager>();
            services.AddTransient<IReservationDetailService, ReservationDetailManager>();

            services.AddTransient<IImageService, ImageManager>();
            services.AddTransient<IImageExtension, ImageExtension>();



            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Images Gelicek.
            //SHIFT gelicek
        }

        public static void DbConfigurationAdd(this IServiceCollection services, IConfiguration configuration)
        {
            //, x => x.MigrationsAssembly("BilgeHotel.WebUI")
            services.AddDbContext<BilgeHotelDenemeContext>(x => x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")).UseLazyLoadingProxies());

        }
    }
}
