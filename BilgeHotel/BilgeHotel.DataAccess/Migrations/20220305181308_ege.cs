using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.DataAccess.Migrations
{
    public partial class ege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "ReservationDetails",
                keyColumns: new[] { "PackageId", "ReservationId", "RoomId" },
                keyValues: new object[] { 1, new Guid("af6a0c85-f4d7-4614-b8eb-593340f488de"), 101 });

            migrationBuilder.DeleteData(
                table: "ReservationOutHotelExtras",
                keyColumns: new[] { "HotelExtraId", "ReservationId" },
                keyValues: new object[] { 1, new Guid("af6a0c85-f4d7-4614-b8eb-593340f488de") });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c1710df5-c248-45c5-ac7e-ca7a1a8dfa6f"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("af6a0c85-f4d7-4614-b8eb-593340f488de"));

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "EmployeeJobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("f7535bec-0744-4cce-ae3f-19d0a76064ae"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.UpdateData(
                table: "EmployeeJobs",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[] { new Guid("f555b57a-d5a0-4532-84fc-b729c777ae6c"), 1, null, null, null });

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobs_DepartmentId",
                table: "EmployeeJobs",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeJobs_Departments_DepartmentId",
                table: "EmployeeJobs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeJobs_Departments_DepartmentId",
                table: "EmployeeJobs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeJobs_DepartmentId",
                table: "EmployeeJobs");

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

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EmployeeJobs");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CardType", "Cv2", "EndDate" },
                values: new object[] { new Guid("c1710df5-c248-45c5-ac7e-ca7a1a8dfa6f"), "selam", "Ziraat", "ABC", "02/05" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "ExtraTotalPrice", "Out" },
                values: new object[] { new Guid("af6a0c85-f4d7-4614-b8eb-593340f488de"), 1, null, null, null });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExtraTimeStop", "StartShift", "StopShift" },
                values: new object[] { new DateTime(2022, 3, 4, 23, 28, 6, 124, DateTimeKind.Local).AddTicks(8261), new DateTime(2022, 3, 4, 23, 28, 6, 126, DateTimeKind.Local).AddTicks(6558), new DateTime(2022, 3, 4, 23, 28, 6, 126, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 3, 4, 23, 28, 6, 126, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.InsertData(
                table: "ReservationDetails",
                columns: new[] { "PackageId", "ReservationId", "RoomId", "CardId", "CheckInDate", "CheckOutDate", "CreatedDate", "Discount", "DiscountedPrice" },
                values: new object[] { 1, new Guid("af6a0c85-f4d7-4614-b8eb-593340f488de"), 101, new Guid("c1710df5-c248-45c5-ac7e-ca7a1a8dfa6f"), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 4, 23, 28, 6, 127, DateTimeKind.Local).AddTicks(9825), 22.0, 150m });

            migrationBuilder.InsertData(
                table: "ReservationOutHotelExtras",
                columns: new[] { "HotelExtraId", "ReservationId", "Quantity" },
                values: new object[] { 1, new Guid("af6a0c85-f4d7-4614-b8eb-593340f488de"), (short)5 });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
