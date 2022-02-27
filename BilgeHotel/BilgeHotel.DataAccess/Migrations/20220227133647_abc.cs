using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cv2 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TcIdentityNo = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelExtras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelExtras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomSituations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomSituations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomViews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomBeds",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    BedId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBeds", x => new { x.BedId, x.RoomTypeId });
                    table.ForeignKey(
                        name: "FK_RoomBeds_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomBeds_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypeExtra",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    ExtraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypeExtra", x => new { x.RoomTypeId, x.ExtraId });
                    table.ForeignKey(
                        name: "FK_RoomTypeExtra_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomTypeExtra_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomName = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomSize = table.Column<short>(type: "smallint", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomViewId = table.Column<int>(type: "int", nullable: false),
                    RoomSituationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomName);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomSituations_RoomSituationId",
                        column: x => x.RoomSituationId,
                        principalTable: "RoomSituations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomViews_RoomViewId",
                        column: x => x.RoomViewId,
                        principalTable: "RoomViews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    ExtraTotalPrice = table.Column<decimal>(type: "money", nullable: true),
                    Out = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartShift = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StopShift = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExtraShift = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationDetails",
                columns: table => new
                {
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    DiscountedPrice = table.Column<decimal>(type: "money", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDetails", x => new { x.ReservationId, x.PackageId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationOutHotelExtras",
                columns: table => new
                {
                    HotelExtraId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationOutHotelExtras", x => new { x.HotelExtraId, x.ReservationId });
                    table.ForeignKey(
                        name: "FK_ReservationOutHotelExtras_HotelExtras_HotelExtraId",
                        column: x => x.HotelExtraId,
                        principalTable: "HotelExtras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationOutHotelExtras_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "Id", "BedType" },
                values: new object[,]
                {
                    { 1, "Tek Kişilik" },
                    { 2, "Double" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("524165eb-6bca-406a-9fed-d5a2a8416942"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "Phone", "TcIdentityNo" },
                values: new object[] { 1, new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "serkana607@gmail.com", "Serkan", "Şahin", "25365485652", "64657172255" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[] { 1, "Bilişim" });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "ExtraName" },
                values: new object[,]
                {
                    { 1, "Klima" },
                    { 2, "Televizyon" },
                    { 3, "Saç Kurutma Makinesi" },
                    { 4, "Kablosuz İnternet" },
                    { 5, "Minibar" }
                });

            migrationBuilder.InsertData(
                table: "HotelExtras",
                columns: new[] { "Id", "ExtraName", "Price" },
                values: new object[] { 1, "Şarap", 150m });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "PackageName", "Price" },
                values: new object[,]
                {
                    { 1, "Tam Pansiyon", 0m },
                    { 2, "Herşey Dahil", 0m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "RoomSituations",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 1, "Hazır" },
                    { 2, "Meşgul" },
                    { 3, "Bakımda" },
                    { 4, "Hazırlanıyor" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Name", "Price", "RoomTypeName" },
                values: new object[,]
                {
                    { 1, "Bekar Odası TekYat", 100m, "Tek Kişilik" },
                    { 2, "Bekar Odası DoubleYat", 100m, "Tek Kişilik" },
                    { 3, "Çift Odası AyrıYat", 200m, "İki Kişilik" },
                    { 4, "Çift Odası ÇiftYat", 150m, "İki Kişilik" },
                    { 5, "Aile Odası AyrıYat", 200m, "Üç Kişilik" },
                    { 6, "Aile Odası Çift Yanyana Cocuk AyrıYat", 350m, "Üç Kişilik" },
                    { 7, "Sülale Odası Sülalecek Yat", 750m, "Dört Kişilik" },
                    { 8, "Kral Dairesi DoubleYat", 1000m, "Kral Dairesi" }
                });

            migrationBuilder.InsertData(
                table: "RoomViews",
                columns: new[] { "Id", "ViewName" },
                values: new object[,]
                {
                    { 1, "Deniz" },
                    { 2, "Duvar" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Adress", "DepartmentId", "FirstName", "LastName", "Phone", "RoleId", "Salary" },
                values: new object[] { 1, "Sırasöğütler", 1, "Osman", "Şahin", "12345678955", 1, 500m });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Path", "RoomTypeId" },
                values: new object[,]
                {
                    { 7, "ABC.jpg", 4 },
                    { 13, "ABC.jpg", 7 },
                    { 14, "resepsiyon.jpg", 7 },
                    { 4, "resepsiyon.jpg", 2 },
                    { 3, "ABC.jpg", 2 },
                    { 12, "resepsiyon.jpg", 6 },
                    { 11, "ABC.jpg", 6 },
                    { 6, "resepsiyon.jpg", 3 },
                    { 5, "ABC.jpg", 3 },
                    { 2, "resepsiyon.jpg", 1 },
                    { 1, "ABC.jpg", 1 },
                    { 9, "ABC.jpg", 5 },
                    { 15, "ABC.jpg", 8 },
                    { 16, "resepsiyon.jpg", 8 },
                    { 10, "resepsiyon.jpg", 5 },
                    { 8, "resepsiyon.jpg", 4 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[] { new Guid("fe47b5b6-b5b0-4b96-80cd-94ab8d34bca3"), 1, null, null, null });

            migrationBuilder.InsertData(
                table: "RoomBeds",
                columns: new[] { "BedId", "RoomTypeId", "Quantity" },
                values: new object[,]
                {
                    { 1, 5, 3 },
                    { 2, 7, 1 },
                    { 1, 7, 2 },
                    { 2, 4, 1 },
                    { 1, 6, 1 },
                    { 2, 6, 1 },
                    { 1, 1, 1 },
                    { 1, 3, 2 },
                    { 2, 8, 1 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "RoomTypeExtra",
                columns: new[] { "ExtraId", "RoomTypeId" },
                values: new object[,]
                {
                    { 5, 8 },
                    { 1, 6 },
                    { 2, 6 },
                    { 3, 6 },
                    { 4, 6 },
                    { 4, 8 },
                    { 3, 7 },
                    { 3, 8 },
                    { 2, 8 },
                    { 1, 8 },
                    { 2, 7 },
                    { 5, 7 },
                    { 5, 6 },
                    { 4, 7 }
                });

            migrationBuilder.InsertData(
                table: "RoomTypeExtra",
                columns: new[] { "ExtraId", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 4, 5 },
                    { 5, 5 },
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 1 },
                    { 5, 3 },
                    { 4, 3 },
                    { 2, 5 },
                    { 5, 4 },
                    { 4, 4 },
                    { 1, 5 },
                    { 2, 4 },
                    { 1, 4 },
                    { 3, 4 },
                    { 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomName", "RoomSituationId", "RoomSize", "RoomTypeId", "RoomViewId" },
                values: new object[,]
                {
                    { 113, 1, (short)50, 5, 1 },
                    { 408, 1, (short)50, 4, 1 },
                    { 114, 1, (short)50, 5, 1 },
                    { 112, 1, (short)50, 5, 1 },
                    { 111, 1, (short)50, 5, 1 },
                    { 110, 1, (short)50, 5, 1 },
                    { 409, 1, (short)50, 4, 1 },
                    { 404, 1, (short)50, 4, 1 },
                    { 406, 1, (short)50, 4, 1 },
                    { 405, 1, (short)50, 4, 1 },
                    { 403, 1, (short)50, 4, 1 },
                    { 402, 1, (short)50, 4, 1 },
                    { 401, 1, (short)50, 4, 1 },
                    { 115, 1, (short)50, 5, 1 },
                    { 400, 1, (short)50, 4, 1 },
                    { 407, 1, (short)50, 4, 1 },
                    { 116, 1, (short)50, 5, 1 },
                    { 318, 1, (short)50, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomName", "RoomSituationId", "RoomSize", "RoomTypeId", "RoomViewId" },
                values: new object[,]
                {
                    { 118, 1, (short)50, 5, 1 },
                    { 309, 1, (short)50, 4, 1 },
                    { 414, 1, (short)50, 7, 1 },
                    { 413, 1, (short)50, 7, 1 },
                    { 412, 1, (short)50, 7, 1 },
                    { 411, 1, (short)50, 7, 1 },
                    { 410, 1, (short)50, 7, 1 },
                    { 319, 1, (short)50, 6, 1 },
                    { 117, 1, (short)50, 5, 1 },
                    { 317, 1, (short)50, 6, 1 },
                    { 315, 1, (short)50, 6, 1 },
                    { 314, 1, (short)50, 6, 1 },
                    { 313, 1, (short)50, 6, 1 },
                    { 312, 1, (short)50, 6, 1 },
                    { 311, 1, (short)50, 6, 1 },
                    { 310, 1, (short)50, 6, 1 },
                    { 119, 1, (short)50, 5, 1 },
                    { 316, 1, (short)50, 6, 1 },
                    { 308, 1, (short)50, 4, 1 },
                    { 105, 1, (short)50, 1, 1 },
                    { 306, 1, (short)50, 4, 1 },
                    { 205, 1, (short)50, 2, 1 },
                    { 204, 1, (short)50, 2, 1 },
                    { 203, 1, (short)50, 2, 1 },
                    { 202, 1, (short)50, 2, 1 },
                    { 201, 1, (short)50, 2, 1 },
                    { 200, 1, (short)50, 2, 1 },
                    { 109, 1, (short)50, 1, 1 },
                    { 206, 1, (short)50, 2, 1 },
                    { 108, 1, (short)50, 1, 1 },
                    { 106, 1, (short)50, 1, 1 },
                    { 415, 1, (short)50, 7, 1 },
                    { 104, 1, (short)50, 1, 1 },
                    { 103, 1, (short)50, 1, 1 },
                    { 102, 1, (short)50, 1, 1 },
                    { 101, 1, (short)50, 1, 1 },
                    { 100, 1, (short)50, 1, 1 },
                    { 107, 1, (short)50, 1, 1 },
                    { 307, 1, (short)50, 4, 1 },
                    { 207, 1, (short)50, 2, 1 },
                    { 209, 1, (short)50, 2, 1 },
                    { 305, 1, (short)50, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomName", "RoomSituationId", "RoomSize", "RoomTypeId", "RoomViewId" },
                values: new object[,]
                {
                    { 304, 1, (short)50, 4, 1 },
                    { 303, 1, (short)50, 4, 1 },
                    { 302, 1, (short)50, 4, 1 },
                    { 301, 1, (short)50, 4, 1 },
                    { 300, 1, (short)50, 4, 1 },
                    { 219, 1, (short)50, 3, 1 },
                    { 208, 1, (short)50, 2, 1 },
                    { 218, 1, (short)50, 3, 1 },
                    { 216, 1, (short)50, 3, 1 },
                    { 215, 1, (short)50, 3, 1 },
                    { 214, 1, (short)50, 3, 1 },
                    { 213, 1, (short)50, 3, 1 },
                    { 212, 1, (short)50, 3, 1 },
                    { 211, 1, (short)50, 3, 1 },
                    { 210, 1, (short)50, 3, 1 },
                    { 217, 1, (short)50, 3, 1 },
                    { 420, 1, (short)750, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[] { 1, new Guid("fe47b5b6-b5b0-4b96-80cd-94ab8d34bca3"), 101, new Guid("524165eb-6bca-406a-9fed-d5a2a8416942"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 27, 16, 36, 46, 65, DateTimeKind.Local).AddTicks(886), 22.0, 150m });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("fe47b5b6-b5b0-4b96-80cd-94ab8d34bca3"), (short)5 });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleId",
                table: "Employees",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RoomTypeId",
                table: "Images",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_CardId",
                table: "ReservationDetails",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_PackageId",
                table: "ReservationDetails",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_RoomId",
                table: "ReservationDetails",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationOutHotelExtras_ReservationId",
                table: "ReservationOutHotelExtras",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EmployeeId",
                table: "Reservations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBeds_RoomTypeId",
                table: "RoomBeds",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomSituationId",
                table: "Rooms",
                column: "RoomSituationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomViewId",
                table: "Rooms",
                column: "RoomViewId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypeExtra_ExtraId",
                table: "RoomTypeExtra",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ReservationDetails");

            migrationBuilder.DropTable(
                name: "ReservationOutHotelExtras");

            migrationBuilder.DropTable(
                name: "RoomBeds");

            migrationBuilder.DropTable(
                name: "RoomTypeExtra");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "HotelExtras");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Beds");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "RoomSituations");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "RoomViews");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
