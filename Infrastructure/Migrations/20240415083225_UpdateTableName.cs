using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalQueue_Product_ProductId",
                table: "ApprovalQueue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApprovalQueue",
                table: "ApprovalQueue");

            migrationBuilder.RenameTable(
                name: "ApprovalQueue",
                newName: "ApprovalRequest");

            migrationBuilder.RenameIndex(
                name: "IX_ApprovalQueue_ProductId",
                table: "ApprovalRequest",
                newName: "IX_ApprovalRequest_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApprovalRequest",
                table: "ApprovalRequest",
                column: "ApprovalRequestId");

            migrationBuilder.UpdateData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 1,
                columns: new[] { "ProductId", "RequestDate" },
                values: new object[] { 2, new DateTime(2024, 3, 31, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 2,
                columns: new[] { "ProductId", "RequestDate" },
                values: new object[] { 4, new DateTime(2024, 4, 4, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 3,
                columns: new[] { "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[] { 5, new DateTime(2024, 4, 7, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(510), "Delete request", 3 });

            migrationBuilder.UpdateData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 4,
                columns: new[] { "ProductId", "RequestDate" },
                values: new object[] { 6, new DateTime(2024, 3, 31, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.InsertData(
                table: "ApprovalRequest",
                columns: new[] { "ApprovalRequestId", "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[,]
                {
                    { 5, 7, new DateTime(2024, 3, 23, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(520), "New product", 1 },
                    { 6, 10, new DateTime(2024, 4, 8, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(530), "Price change/Update request", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Doohickey 1", new DateTime(2024, 2, 26, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(430), 754.0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PostedDate", "Price" },
                values: new object[] { new DateTime(2023, 7, 3, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(480), 217.18000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Doohickey 3", new DateTime(2023, 10, 18, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(500), 13.93 });

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
                columns: new[] { "IsActive", "PostedDate", "Price" },
                values: new object[] { false, new DateTime(2023, 9, 13, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(500), 496.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Gadget 6", new DateTime(2024, 2, 21, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(510), 794.32000000000005 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Thingamajig 7", new DateTime(2023, 12, 5, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(520), 862.36000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Gadget 8", new DateTime(2023, 12, 28, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(520), 984.16999999999996 });

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
                columns: new[] { "IsActive", "PostedDate", "Price" },
                values: new object[] { false, new DateTime(2023, 7, 11, 1, 32, 25, 293, DateTimeKind.Local).AddTicks(530), 591.60000000000002 });

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalRequest_Product_ProductId",
                table: "ApprovalRequest",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalRequest_Product_ProductId",
                table: "ApprovalRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApprovalRequest",
                table: "ApprovalRequest");

            migrationBuilder.DeleteData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ApprovalRequest",
                keyColumn: "ApprovalRequestId",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "ApprovalRequest",
                newName: "ApprovalQueue");

            migrationBuilder.RenameIndex(
                name: "IX_ApprovalRequest_ProductId",
                table: "ApprovalQueue",
                newName: "IX_ApprovalQueue_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApprovalQueue",
                table: "ApprovalQueue",
                column: "ApprovalRequestId");

            migrationBuilder.UpdateData(
                table: "ApprovalQueue",
                keyColumn: "ApprovalRequestId",
                keyValue: 1,
                columns: new[] { "ProductId", "RequestDate" },
                values: new object[] { 1, new DateTime(2024, 3, 18, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(760) });

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
                columns: new[] { "ProductId", "RequestDate" },
                values: new object[] { 8, new DateTime(2024, 4, 12, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { false, "Widget 1", new DateTime(2023, 12, 23, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(690), 553.40999999999997 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PostedDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 21, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(770), 319.43000000000001 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Thingamajig 3", new DateTime(2023, 10, 19, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(780), 19.699999999999999 });

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
                columns: new[] { "IsActive", "PostedDate", "Price" },
                values: new object[] { true, new DateTime(2023, 6, 24, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(780), 155.34999999999999 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "PostedDate", "Price" },
                values: new object[] { "Thingamajig 6", new DateTime(2024, 3, 16, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(790), 828.87 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsActive", "Name", "PostedDate", "Price" },
                values: new object[] { true, "Gadget 7", new DateTime(2024, 2, 3, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(800), 136.75 });

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
                columns: new[] { "IsActive", "PostedDate", "Price" },
                values: new object[] { true, new DateTime(2023, 11, 4, 1, 23, 52, 492, DateTimeKind.Local).AddTicks(810), 331.51999999999998 });

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalQueue_Product_ProductId",
                table: "ApprovalQueue",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
