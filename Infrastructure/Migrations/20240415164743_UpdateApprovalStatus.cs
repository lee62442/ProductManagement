using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApprovalStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 6);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ApprovalRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 1,
                columns: new[] { "ProductId", "RequestDate", "RequestReason", "RequestType", "Status" },
                values: new object[] { 7, new DateTime(2024, 3, 21, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8500), "New product", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Gadget 1", new DateTime(2024, 4, 13, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8400), 496.39999999999998 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Widget 2", new DateTime(2023, 11, 15, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8470), 464.82999999999998 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PostedDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 8, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8470), 347.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Thingamajig 4", new DateTime(2023, 10, 28, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8470), 13.279999999999999 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Thingamajig 5", new DateTime(2023, 12, 8, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8480), 715.78999999999996 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Thingamajig 6", new DateTime(2023, 8, 26, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8490), 611.51999999999998 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PostedDate", "Price" },
                values: new object[] { new DateTime(2023, 9, 9, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8490), 94.170000000000002 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Thingamajig 8", new DateTime(2023, 8, 18, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8500), 545.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Thingamajig 9", new DateTime(2023, 12, 16, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8510), 534.91999999999996 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Widget 10", new DateTime(2023, 5, 25, 9, 47, 43, 718, DateTimeKind.Local).AddTicks(8510), 978.16999999999996 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ApprovalRequest");

            migrationBuilder.UpdateData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 1,
                columns: new[] { "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[] { 2, new DateTime(2024, 3, 31, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(490), "Price change/Update request", 2 });

            migrationBuilder.InsertData(
                table: "ApprovalRequest",
                columns: new[] { "ApprovalRequestId", "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[,]
                {
                    { 2, 4, new DateTime(2024, 4, 4, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(500), "Price change/Update request", 2 },
                    { 3, 5, new DateTime(2024, 4, 7, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(510), "Delete request", 3 },
                    { 4, 6, new DateTime(2024, 3, 31, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(510), "New product", 1 },
                    { 5, 7, new DateTime(2024, 3, 23, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(520), "New product", 1 },
                    { 6, 10, new DateTime(2024, 4, 8, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(530), "Price change/Update request", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Doohickey 1", new DateTime(2024, 2, 26, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(430), 754.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Thingamajig 2", new DateTime(2023, 7, 3, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(480), 217.18000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PostedDate", "Price" },
                values: new object[] { new DateTime(2023, 10, 18, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(500), 13.93 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Doohickey 4", new DateTime(2023, 11, 16, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(500), 723.15999999999997 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Gadget 5", new DateTime(2023, 9, 13, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(500), 496.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Gadget 6", new DateTime(2024, 2, 21, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(510), 794.32000000000005 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PostedDate", "Price" },
                values: new object[] { new DateTime(2023, 12, 5, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(520), 862.36000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Gadget 8", new DateTime(2023, 12, 28, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(520), 984.16999999999996 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Doohickey 9", new DateTime(2023, 7, 12, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(530), 646.63999999999999 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Gadget 10", new DateTime(2023, 7, 11, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(530), 591.60000000000002 });
        }
    }
}
