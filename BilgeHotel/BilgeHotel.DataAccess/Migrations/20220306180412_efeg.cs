using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class efeg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("e817e22c-ea7c-4e8d-b7a6-f726311e840a"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[,]
                {
                    { new Guid("06f3f8a3-5a48-4e3b-81c0-5c2ef8db86e0"), 1, null, null, null },
                    { new Guid("02e342f1-e2b4-42db-ab7a-8aba67e84338"), 1, null, null, null },
                    { new Guid("d92862d4-cea1-4775-8689-6f00033a43c3"), 1, null, null, null },
                    { new Guid("0ae3674c-815a-4d2f-aafb-3a991dea6148"), 1, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 6, 21, 4, 10, 484, DateTimeKind.Local).AddTicks(7003), new DateTime(2022, 3, 6, 21, 4, 10, 486, DateTimeKind.Local).AddTicks(9535), new DateTime(2022, 3, 6, 21, 4, 10, 486, DateTimeKind.Local).AddTicks(8036), new DateTime(2022, 3, 6, 21, 4, 10, 486, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[,]
                {
                    { 1, new Guid("06f3f8a3-5a48-4e3b-81c0-5c2ef8db86e0"), 101, new Guid("e817e22c-ea7c-4e8d-b7a6-f726311e840a"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 21, 4, 10, 488, DateTimeKind.Local).AddTicks(4542), 22.0, 150m },
                    { 1, new Guid("02e342f1-e2b4-42db-ab7a-8aba67e84338"), 101, new Guid("e817e22c-ea7c-4e8d-b7a6-f726311e840a"), new DateTime(2022, 3, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 21, 4, 10, 488, DateTimeKind.Local).AddTicks(7128), 22.0, 150m },
                    { 1, new Guid("d92862d4-cea1-4775-8689-6f00033a43c3"), 101, new Guid("e817e22c-ea7c-4e8d-b7a6-f726311e840a"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 21, 4, 10, 488, DateTimeKind.Local).AddTicks(7136), 22.0, 150m },
                    { 1, new Guid("0ae3674c-815a-4d2f-aafb-3a991dea6148"), 102, new Guid("e817e22c-ea7c-4e8d-b7a6-f726311e840a"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 21, 4, 10, 488, DateTimeKind.Local).AddTicks(7141), 22.0, 150m }
                });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("06f3f8a3-5a48-4e3b-81c0-5c2ef8db86e0"), (short)5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("02e342f1-e2b4-42db-ab7a-8aba67e84338"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("06f3f8a3-5a48-4e3b-81c0-5c2ef8db86e0"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("0ae3674c-815a-4d2f-aafb-3a991dea6148"), 102 });

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("d92862d4-cea1-4775-8689-6f00033a43c3"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationOutHotelExtras",
                keyColumns: new[] { "HotelExtraId", "ReservationId" },
                keyValues: new object[] { 1, new Guid("06f3f8a3-5a48-4e3b-81c0-5c2ef8db86e0") });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("e817e22c-ea7c-4e8d-b7a6-f726311e840a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("02e342f1-e2b4-42db-ab7a-8aba67e84338"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("06f3f8a3-5a48-4e3b-81c0-5c2ef8db86e0"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("0ae3674c-815a-4d2f-aafb-3a991dea6148"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d92862d4-cea1-4775-8689-6f00033a43c3"));

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
    }
}
