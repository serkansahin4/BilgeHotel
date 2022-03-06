using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class asdhe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("f555b57a-d5a0-4532-84fc-b729c777ae6c"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationOutHotelExtras",
                keyColumns: new[] { "HotelExtraId", "ReservationId" },
                keyValues: new object[] { 1, new Guid("f555b57a-d5a0-4532-84fc-b729c777ae6c") });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f7535bec-0744-4cce-ae3f-19d0a76064ae"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("f555b57a-d5a0-4532-84fc-b729c777ae6c"));

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("fd93ea8e-0f47-4ef0-bb60-7d55470643d4"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 2, "SatisDepartmani" },
                    { 3, "Resepsiyon" },
                    { 5, "InsanKaynaklari" },
                    { 6, "Mutfak" },
                    { 7, "Elektrik" }
                });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobName",
                value: "Resepsiyon Görevlisi");

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "JobName" },
                values: new object[,]
                {
                    { 6, "Bilgi İşlem Sorumlusu" },
                    { 5, "Elektrikci" },
                    { 3, "Aşçı" },
                    { 2, "Temizlik Görevlisi" },
                    { 4, "Garson" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[,]
                {
                    { new Guid("0446338e-f98a-4a3c-a597-a4508a85b277"), 1, null, null, null },
                    { new Guid("da607d1e-fa54-4b7e-ac74-3b14d84a8cc0"), 1, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleName",
                value: "SatisDepartmaniYoneticisi");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 2, "InsanKaynaklariYoneticisi" },
                    { 3, "ITSorumlusu" },
                    { 4, "ResepsiyonSefi" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

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
                values: new object[] { new Guid("f7535bec-0744-4cce-ae3f-19d0a76064ae"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobName",
                value: "Garson");

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[] { new Guid("f555b57a-d5a0-4532-84fc-b729c777ae6c"), 1, null, null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleName",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 5, 21, 13, 7, 64, DateTimeKind.Local).AddTicks(7964), new DateTime(2022, 3, 5, 21, 13, 7, 66, DateTimeKind.Local).AddTicks(7296), new DateTime(2022, 3, 5, 21, 13, 7, 66, DateTimeKind.Local).AddTicks(5997), new DateTime(2022, 3, 5, 21, 13, 7, 66, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[] { 1, new Guid("f555b57a-d5a0-4532-84fc-b729c777ae6c"), 101, new Guid("f7535bec-0744-4cce-ae3f-19d0a76064ae"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 5, 21, 13, 7, 68, DateTimeKind.Local).AddTicks(139), 22.0, 150m });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("f555b57a-d5a0-4532-84fc-b729c777ae6c"), (short)5 });
        }
    }
}
