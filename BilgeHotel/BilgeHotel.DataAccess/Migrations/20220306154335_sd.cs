using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class sd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("0446338e-f98a-4a3c-a597-a4508a85b277"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("da607d1e-fa54-4b7e-ac74-3b14d84a8cc0"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationOutHotelExtras",
                keyColumns: new[] { "HotelExtraId", "ReservationId" },
                keyValues: new object[] { 1, new Guid("0446338e-f98a-4a3c-a597-a4508a85b277") });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("fd93ea8e-0f47-4ef0-bb60-7d55470643d4"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("0446338e-f98a-4a3c-a597-a4508a85b277"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("da607d1e-fa54-4b7e-ac74-3b14d84a8cc0"));

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("a8ac33af-f174-44a6-97b1-2c04664fca2f"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[,]
                {
                    { new Guid("270688d8-d738-48e1-94cf-025b73126809"), 1, null, null, null },
                    { new Guid("84a0df71-93a6-4675-837a-c894fb2208cc"), 1, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 6, 18, 43, 33, 413, DateTimeKind.Local).AddTicks(6763), new DateTime(2022, 3, 6, 18, 43, 33, 416, DateTimeKind.Local).AddTicks(3738), new DateTime(2022, 3, 6, 18, 43, 33, 416, DateTimeKind.Local).AddTicks(1814), new DateTime(2022, 3, 6, 18, 43, 33, 416, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[] { 1, new Guid("270688d8-d738-48e1-94cf-025b73126809"), 101, new Guid("a8ac33af-f174-44a6-97b1-2c04664fca2f"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 18, 43, 33, 418, DateTimeKind.Local).AddTicks(4871), 22.0, 150m });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[] { 1, new Guid("84a0df71-93a6-4675-837a-c894fb2208cc"), 101, new Guid("a8ac33af-f174-44a6-97b1-2c04664fca2f"), new DateTime(2022, 3, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 18, 43, 33, 418, DateTimeKind.Local).AddTicks(8263), 22.0, 150m });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("270688d8-d738-48e1-94cf-025b73126809"), (short)5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("270688d8-d738-48e1-94cf-025b73126809"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("84a0df71-93a6-4675-837a-c894fb2208cc"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationOutHotelExtras",
                keyColumns: new[] { "HotelExtraId", "ReservationId" },
                keyValues: new object[] { 1, new Guid("270688d8-d738-48e1-94cf-025b73126809") });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a8ac33af-f174-44a6-97b1-2c04664fca2f"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("270688d8-d738-48e1-94cf-025b73126809"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("84a0df71-93a6-4675-837a-c894fb2208cc"));

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("fd93ea8e-0f47-4ef0-bb60-7d55470643d4"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[,]
                {
                    { new Guid("0446338e-f98a-4a3c-a597-a4508a85b277"), 1, null, null, null },
                    { new Guid("da607d1e-fa54-4b7e-ac74-3b14d84a8cc0"), 1, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 6, 18, 32, 20, 848, DateTimeKind.Local).AddTicks(4057), new DateTime(2022, 3, 6, 18, 32, 20, 850, DateTimeKind.Local).AddTicks(5084), new DateTime(2022, 3, 6, 18, 32, 20, 850, DateTimeKind.Local).AddTicks(3466), new DateTime(2022, 3, 6, 18, 32, 20, 850, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[] { 1, new Guid("0446338e-f98a-4a3c-a597-a4508a85b277"), 101, new Guid("fd93ea8e-0f47-4ef0-bb60-7d55470643d4"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 18, 32, 20, 851, DateTimeKind.Local).AddTicks(9276), 22.0, 150m });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[] { 1, new Guid("da607d1e-fa54-4b7e-ac74-3b14d84a8cc0"), 101, new Guid("fd93ea8e-0f47-4ef0-bb60-7d55470643d4"), new DateTime(2022, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 18, 32, 20, 852, DateTimeKind.Local).AddTicks(1761), 22.0, 150m });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("0446338e-f98a-4a3c-a597-a4508a85b277"), (short)5 });
        }
    }
}
