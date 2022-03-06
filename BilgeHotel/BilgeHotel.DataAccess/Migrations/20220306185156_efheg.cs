using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class efheg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationDetails_Reservations_ReservationId",
                table: "ReservationDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationDetails",
                table: "ReservationDetails");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationDetails",
                table: "ReservationDetails",
                column: "ReservationId");

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("70dbb382-831f-42d3-add2-d4213b166eff"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 6, 21, 51, 53, 604, DateTimeKind.Local).AddTicks(6868), new DateTime(2022, 3, 6, 21, 51, 53, 608, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 3, 6, 21, 51, 53, 608, DateTimeKind.Local).AddTicks(1140), new DateTime(2022, 3, 6, 21, 51, 53, 608, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "ReservationId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice", "PackageId", "RoomId" },
                values: new object[,]
                {
                    { new Guid("81497a3d-50b2-4967-941f-7db761ecee7d"), new Guid("70dbb382-831f-42d3-add2-d4213b166eff"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 21, 51, 53, 610, DateTimeKind.Local).AddTicks(2246), 22.0, 150m, 1, 101 },
                    { new Guid("af0d02b6-b378-4cd5-9350-051e246dc7e4"), new Guid("70dbb382-831f-42d3-add2-d4213b166eff"), new DateTime(2022, 3, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 21, 51, 53, 610, DateTimeKind.Local).AddTicks(5566), 22.0, 150m, 1, 101 },
                    { new Guid("45b599af-3e2a-4f4c-bf42-cc7909453d88"), new Guid("70dbb382-831f-42d3-add2-d4213b166eff"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 21, 51, 53, 610, DateTimeKind.Local).AddTicks(5575), 22.0, 150m, 1, 101 },
                    { new Guid("9d7a522e-e382-4b7b-af81-fc798ab737b4"), new Guid("70dbb382-831f-42d3-add2-d4213b166eff"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 21, 51, 53, 610, DateTimeKind.Local).AddTicks(5583), 22.0, 150m, 1, 102 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[,]
                {
                    { new Guid("81497a3d-50b2-4967-941f-7db761ecee7d"), 1, null, null, null },
                    { new Guid("af0d02b6-b378-4cd5-9350-051e246dc7e4"), 1, null, null, null },
                    { new Guid("45b599af-3e2a-4f4c-bf42-cc7909453d88"), 1, null, null, null },
                    { new Guid("9d7a522e-e382-4b7b-af81-fc798ab737b4"), 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("81497a3d-50b2-4967-941f-7db761ecee7d"), (short)5 });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationDetails_Id",
                table: "Reservations",
                column: "Id",
                principalTable: "ReservationDetails",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationDetails_Id",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationDetails",
                table: "ReservationDetails");

            migrationBuilder.DeleteData(
                table: "ReservationOutHotelExtras",
                keyColumns: new[] { "HotelExtraId", "ReservationId" },
                keyValues: new object[] { 1, new Guid("81497a3d-50b2-4967-941f-7db761ecee7d") });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("45b599af-3e2a-4f4c-bf42-cc7909453d88"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("9d7a522e-e382-4b7b-af81-fc798ab737b4"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("af0d02b6-b378-4cd5-9350-051e246dc7e4"));

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumn: "ReservationId",
                keyValue: new Guid("45b599af-3e2a-4f4c-bf42-cc7909453d88"));

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumn: "ReservationId",
                keyValue: new Guid("9d7a522e-e382-4b7b-af81-fc798ab737b4"));

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumn: "ReservationId",
                keyValue: new Guid("af0d02b6-b378-4cd5-9350-051e246dc7e4"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("81497a3d-50b2-4967-941f-7db761ecee7d"));

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumn: "ReservationId",
                keyValue: new Guid("81497a3d-50b2-4967-941f-7db761ecee7d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("70dbb382-831f-42d3-add2-d4213b166eff"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationDetails",
                table: "ReservationDetails",
                columns: new[] { "ReservationId", "PackageId", "RoomId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationDetails_Reservations_ReservationId",
                table: "ReservationDetails",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
