using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class adefe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("87b239f2-b18d-42d8-8251-908a077019a4"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[,]
                {
                    { new Guid("4631a5ee-89f6-4825-bcb4-5d7e7c27763c"), 1, null, null, null },
                    { new Guid("7ba187a4-6251-43db-9acc-b668b2c19f2f"), 1, null, null, null },
                    { new Guid("d9f7e52a-54e5-4f22-b43f-37759165fd8f"), 1, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 6, 19, 51, 50, 818, DateTimeKind.Local).AddTicks(5058), new DateTime(2022, 3, 6, 19, 51, 50, 821, DateTimeKind.Local).AddTicks(822), new DateTime(2022, 3, 6, 19, 51, 50, 820, DateTimeKind.Local).AddTicks(9211), new DateTime(2022, 3, 6, 19, 51, 50, 820, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[,]
                {
                    { 1, new Guid("4631a5ee-89f6-4825-bcb4-5d7e7c27763c"), 101, new Guid("87b239f2-b18d-42d8-8251-908a077019a4"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 19, 51, 50, 822, DateTimeKind.Local).AddTicks(6882), 22.0, 150m },
                    { 1, new Guid("7ba187a4-6251-43db-9acc-b668b2c19f2f"), 101, new Guid("87b239f2-b18d-42d8-8251-908a077019a4"), new DateTime(2022, 3, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 19, 51, 50, 824, DateTimeKind.Local).AddTicks(3966), 22.0, 150m },
                    { 1, new Guid("d9f7e52a-54e5-4f22-b43f-37759165fd8f"), 101, new Guid("87b239f2-b18d-42d8-8251-908a077019a4"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 19, 51, 50, 824, DateTimeKind.Local).AddTicks(3977), 22.0, 150m }
                });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("4631a5ee-89f6-4825-bcb4-5d7e7c27763c"), (short)5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("4631a5ee-89f6-4825-bcb4-5d7e7c27763c"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("7ba187a4-6251-43db-9acc-b668b2c19f2f"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("d9f7e52a-54e5-4f22-b43f-37759165fd8f"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationOutHotelExtras",
                keyColumns: new[] { "HotelExtraId", "ReservationId" },
                keyValues: new object[] { 1, new Guid("4631a5ee-89f6-4825-bcb4-5d7e7c27763c") });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("87b239f2-b18d-42d8-8251-908a077019a4"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("4631a5ee-89f6-4825-bcb4-5d7e7c27763c"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7ba187a4-6251-43db-9acc-b668b2c19f2f"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d9f7e52a-54e5-4f22-b43f-37759165fd8f"));

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
    }
}
