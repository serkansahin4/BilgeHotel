﻿// <auto-generated />
using System;
using BilgeHotel.DataAccess.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BilgeHotel.WebUI.Migrations
{
    [DbContext(typeof(BilgeHotelDenemeContext))]
    [Migration("20220210183441_yenige")]
    partial class yenige
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BilgeHotel.Entities.ComplexType.ReservationDetail", b =>
                {
                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<decimal?>("DiscountedPrice")
                        .HasColumnType("money");

                    b.HasKey("ReservationId", "PackageId", "RoomId");

                    b.HasIndex("PackageId");

                    b.HasIndex("RoomId");

                    b.ToTable("ReservationDetails");
                });

            modelBuilder.Entity("BilgeHotel.Entities.ComplexType.ReservationOutHotelExtra", b =>
                {
                    b.Property<int>("HotelExtraId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("money");

                    b.HasKey("HotelExtraId", "ReservationId");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationOutHotelExtras");
                });

            modelBuilder.Entity("BilgeHotel.Entities.ComplexType.RoomBed", b =>
                {
                    b.Property<int>("BedId")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BedId", "RoomTypeId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("RoomBeds");
                });

            modelBuilder.Entity("BilgeHotel.Entities.ComplexType.RoomTypeExtra", b =>
                {
                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ExtraId")
                        .HasColumnType("int");

                    b.HasKey("RoomTypeId", "ExtraId");

                    b.HasIndex("ExtraId");

                    b.ToTable("RoomTypeExtra");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Bed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BedType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Beds");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength(true);

                    b.Property<string>("TcIdentityNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength(true);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Extra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExtraName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.HotelExtra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExtraName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("HotelExtras");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("ExtraTotalPrice")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Room", b =>
                {
                    b.Property<int>("RoomName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoomSituationId")
                        .HasColumnType("int");

                    b.Property<short>("RoomSize")
                        .HasColumnType("smallint");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RoomViewId")
                        .HasColumnType("int");

                    b.HasKey("RoomName");

                    b.HasIndex("RoomSituationId");

                    b.HasIndex("RoomTypeId");

                    b.HasIndex("RoomViewId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.RoomSituation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomSituations");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("RoomTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.RoomView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ViewName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RoomViews");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<short?>("ExtraShift")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("ShiftDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartShift")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StopShift")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("BilgeHotel.Entities.ComplexType.ReservationDetail", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.Package", "Package")
                        .WithMany("ReservationDetails")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.Reservation", "Reservation")
                        .WithMany("ReservationDetails")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.Room", "Room")
                        .WithMany("ReservationDetails")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Reservation");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("BilgeHotel.Entities.ComplexType.ReservationOutHotelExtra", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.HotelExtra", "HotelExtra")
                        .WithMany("ReservationOutHotelExtras")
                        .HasForeignKey("HotelExtraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.Reservation", "Reservation")
                        .WithMany("ReservationOutHotelExtras")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelExtra");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("BilgeHotel.Entities.ComplexType.RoomBed", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.Bed", "Bed")
                        .WithMany("RoomBeds")
                        .HasForeignKey("BedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.RoomType", "RoomType")
                        .WithMany("RoomBeds")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bed");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("BilgeHotel.Entities.ComplexType.RoomTypeExtra", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.Extra", "Extra")
                        .WithMany("RoomTypeExtras")
                        .HasForeignKey("ExtraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.RoomType", "RoomType")
                        .WithMany("RoomTypeExtras")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Extra");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Employee", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Image", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.RoomType", "RoomType")
                        .WithMany("Images")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Reservation", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.Employee", "Employee")
                        .WithMany("Reservations")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Room", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.RoomSituation", "RoomSituation")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomSituationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilgeHotel.Entities.Concrete.RoomView", "RoomView")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomViewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomSituation");

                    b.Navigation("RoomType");

                    b.Navigation("RoomView");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Shift", b =>
                {
                    b.HasOne("BilgeHotel.Entities.Concrete.Employee", "Employee")
                        .WithMany("Shifts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Bed", b =>
                {
                    b.Navigation("RoomBeds");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Employee", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Extra", b =>
                {
                    b.Navigation("RoomTypeExtras");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.HotelExtra", b =>
                {
                    b.Navigation("ReservationOutHotelExtras");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Package", b =>
                {
                    b.Navigation("ReservationDetails");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Reservation", b =>
                {
                    b.Navigation("ReservationDetails");

                    b.Navigation("ReservationOutHotelExtras");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.Room", b =>
                {
                    b.Navigation("ReservationDetails");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.RoomSituation", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.RoomType", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("RoomBeds");

                    b.Navigation("Rooms");

                    b.Navigation("RoomTypeExtras");
                });

            modelBuilder.Entity("BilgeHotel.Entities.Concrete.RoomView", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
