using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApprovalQueueColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ApprovalQueue",
                newName: "ApprovalRequestId");

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "ApprovalRequestId",
                keyValue: 1,
                columns: new[] { "RequestDate", "RequestReason", "RequestType" },
                values: new object[] { new DateTime(2024, 3, 18, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(760), "Price change/Update request", 2 });

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "ApprovalRequestId",
                keyValue: 2,
                columns: new[] { "ProductId", "RequestDate" },
                values: new object[] { 2, new DateTime(2024, 3, 26, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "ApprovalRequestId",
                keyValue: 3,
                columns: new[] { "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[] { 6, new DateTime(2024, 3, 22, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(790), "Price change/Update request", 2 });

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "ApprovalRequestId",
                keyValue: 4,
                columns: new[] { "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[] { 8, new DateTime(2024, 4, 12, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(800), "New product", 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Widget 1", new DateTime(2023, 12, 23, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(690), 553.40999999999997 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Thingamajig 2", new DateTime(2024, 1, 21, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(770), 319.43000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Thingamajig 3", new DateTime(2023, 10, 19, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(780), 19.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Gadget 4", new DateTime(2024, 2, 24, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(780), 352.61000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Gadget 5", new DateTime(2023, 6, 24, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(780), 155.34999999999999 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Thingamajig 6", new DateTime(2024, 3, 16, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(790), 828.87 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsActive", "PostedDate", "Price" },
                values: new object[] { true, new DateTime(2024, 2, 3, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(800), 136.75 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Doohickey 8", new DateTime(2023, 4, 25, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(800), 591.77999999999997 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Gadget 9", new DateTime(2024, 3, 11, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(810), 878.25 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PostedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 4, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(810), 331.51999999999998 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApprovalRequestId",
                table: "ApprovalQueue",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RequestDate", "RequestReason", "RequestType" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1380), "Delete request", 3 });

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "RequestDate" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[] { 4, new DateTime(2024, 3, 20, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1400), "New product", 1 });

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[] { 7, new DateTime(2024, 3, 25, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1420), "Delete request", 3 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Thingamajig 1", new DateTime(2023, 8, 20, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1330), 405.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Doohickey 2", new DateTime(2023, 8, 27, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1390), 408.08999999999997 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Doohickey 3", new DateTime(2023, 5, 27, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1400), 598.55999999999995 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Doohickey 4", new DateTime(2023, 7, 9, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1400), 562.71000000000004 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Widget 5", new DateTime(2023, 9, 28, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1410), 84.450000000000003 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Gadget 6", new DateTime(2024, 1, 7, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1410), 990.32000000000005 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsActive", "PostedDate", "Price" },
                values: new object[] { false, new DateTime(2024, 2, 25, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1420), 346.5 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Widget 8", new DateTime(2023, 8, 20, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1420), 809.28999999999996 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Thingamajig 9", new DateTime(2023, 9, 13, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1420), 968.04999999999995 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PostedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 13, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1430), 867.75 });
        }
    }
}
