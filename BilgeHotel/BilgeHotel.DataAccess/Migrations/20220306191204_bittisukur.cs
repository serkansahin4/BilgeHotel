using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class bittisukur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("b740f799-7eb7-4275-bd50-e459b98601c4"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.InsertData(
                table: "EmployeeJobs",
                columns: new[] { "EmployeeId", "DayId", "DepartmentId", "JobId", "ShiftTimeId" },
                values: new object[] { 4, 7, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ShiftTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "StopTime",
                value: new TimeSpan(0, 8, 0, 0, 0));

            migrationBuilder.InsertData(
                table: "ShiftTimes",
                columns: new[] { "Id", "StartTime", "StopTime" },
                values: new object[,]
                {
                    { 2, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0) },
                    { 3, new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 0, 0, 0, 0) },
                    { 4, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeJobs",
                columns: new[] { "EmployeeId", "DayId", "DepartmentId", "JobId", "ShiftTimeId" },
                values: new object[,]
                {
                    { 2, 7, 7, 5, 4 },
                    { 3, 7, 1, 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Adress", "FirstName", "LastName", "Phone", "RoleId", "Salary" },
                values: new object[] { 4, "Sırasöğütler", "Gaye", "Şahin", "12345678955", 4, 200m });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "ReservationId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice", "PackageId", "RoomId" },
                values: new object[,]
                {
                    { new Guid("682aa588-63a9-4255-a2d5-6af0eaa66591"), new Guid("b740f799-7eb7-4275-bd50-e459b98601c4"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 22, 12, 2, 929, DateTimeKind.Local).AddTicks(1534), 22.0, 150m, 1, 101 },
                    { new Guid("90b65286-8768-45dc-8468-7228817c5bea"), new Guid("b740f799-7eb7-4275-bd50-e459b98601c4"), new DateTime(2022, 3, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 22, 12, 2, 929, DateTimeKind.Local).AddTicks(3843), 22.0, 150m, 1, 101 },
                    { new Guid("4ae0da74-76b0-4998-ba38-951c5a5b891e"), new Guid("b740f799-7eb7-4275-bd50-e459b98601c4"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 22, 12, 2, 929, DateTimeKind.Local).AddTicks(3850), 22.0, 150m, 1, 101 },
                    { new Guid("77027110-748f-4b0d-aabc-58f022e9f8c9"), new Guid("b740f799-7eb7-4275-bd50-e459b98601c4"), new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 22, 12, 2, 929, DateTimeKind.Local).AddTicks(3855), 22.0, 150m, 1, 102 }
                });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmployeeJobId", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 6, 22, 12, 2, 926, DateTimeKind.Local).AddTicks(85), 4, new DateTime(2022, 3, 6, 22, 12, 2, 927, DateTimeKind.Local).AddTicks(8472), new DateTime(2022, 3, 6, 22, 12, 2, 927, DateTimeKind.Local).AddTicks(7133), new DateTime(2022, 3, 6, 22, 12, 2, 927, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Adress", "FirstName", "LastName", "Phone", "RoleId", "Salary" },
                values: new object[,]
                {
                    { 2, "Sırasöğütler", "Murat", "Şahin", "12345678955", 2, 100m },
                    { 3, "Sırasöğütler", "Mehmet", "Şahin", "12345678955", 3, 200m }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[,]
                {
                    { new Guid("682aa588-63a9-4255-a2d5-6af0eaa66591"), 1, null, null, null },
                    { new Guid("90b65286-8768-45dc-8468-7228817c5bea"), 1, null, null, null },
                    { new Guid("4ae0da74-76b0-4998-ba38-951c5a5b891e"), 1, null, null, null },
                    { new Guid("77027110-748f-4b0d-aabc-58f022e9f8c9"), 1, 4, null, null }
                });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("682aa588-63a9-4255-a2d5-6af0eaa66591"), (short)5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationOutHotelExtras",
                keyColumns: new[] { "HotelExtraId", "ReservationId" },
                keyValues: new object[] { 1, new Guid("682aa588-63a9-4255-a2d5-6af0eaa66591") });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("4ae0da74-76b0-4998-ba38-951c5a5b891e"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("77027110-748f-4b0d-aabc-58f022e9f8c9"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("90b65286-8768-45dc-8468-7228817c5bea"));

            migrationBuilder.DeleteData(
                table: "ShiftTimes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShiftTimes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeJobs",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeJobs",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumn: "ReservationId",
                keyValue: new Guid("4ae0da74-76b0-4998-ba38-951c5a5b891e"));

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumn: "ReservationId",
                keyValue: new Guid("77027110-748f-4b0d-aabc-58f022e9f8c9"));

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumn: "ReservationId",
                keyValue: new Guid("90b65286-8768-45dc-8468-7228817c5bea"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("682aa588-63a9-4255-a2d5-6af0eaa66591"));

            migrationBuilder.DeleteData(
                table: "EmployeeJobs",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumn: "ReservationId",
                keyValue: new Guid("682aa588-63a9-4255-a2d5-6af0eaa66591"));

            migrationBuilder.DeleteData(
                table: "ShiftTimes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b740f799-7eb7-4275-bd50-e459b98601c4"));

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("70dbb382-831f-42d3-add2-d4213b166eff"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.UpdateData(
                table: "ShiftTimes",
                keyColumn: "Id",
                keyValue: 1,
                column: "StopTime",
                value: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmployeeJobId", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 6, 21, 51, 53, 604, DateTimeKind.Local).AddTicks(6868), 1, new DateTime(2022, 3, 6, 21, 51, 53, 608, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 3, 6, 21, 51, 53, 608, DateTimeKind.Local).AddTicks(1140), new DateTime(2022, 3, 6, 21, 51, 53, 608, DateTimeKind.Local).AddTicks(1982) });

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
        }
    }
}
