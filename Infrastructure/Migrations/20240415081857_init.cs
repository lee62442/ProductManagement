using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalQueue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalQueue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovalQueue_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "IsActive", "Name", "PostedDate", "Price" },
                values: new object[,]
                {
                    { 1, false, "Thingamajig 1", new DateTime(2023, 8, 20, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1330), 405.02999999999997 },
                    { 2, true, "Doohickey 2", new DateTime(2023, 8, 27, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1390), 408.08999999999997 },
                    { 3, false, "Doohickey 3", new DateTime(2023, 5, 27, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1400), 598.55999999999995 },
                    { 4, false, "Doohickey 4", new DateTime(2023, 7, 9, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1400), 562.71000000000004 },
                    { 5, true, "Widget 5", new DateTime(2023, 9, 28, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1410), 84.450000000000003 },
                    { 6, true, "Gadget 6", new DateTime(2024, 1, 7, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1410), 990.32000000000005 },
                    { 7, false, "Gadget 7", new DateTime(2024, 2, 25, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1420), 346.5 },
                    { 8, true, "Widget 8", new DateTime(2023, 8, 20, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1420), 809.28999999999996 },
                    { 9, true, "Thingamajig 9", new DateTime(2023, 9, 13, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1420), 968.04999999999995 },
                    { 10, true, "Gadget 10", new DateTime(2023, 11, 13, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1430), 867.75 }
                });

            migrationBuilder.InsertData(
                table: "ApprovalQueue",
                columns: new[] { "Id", "ProductId", "RequestDate", "RequestReason", "RequestType" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 20, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1380), "Delete request", 3 },
                    { 2, 3, new DateTime(2024, 4, 12, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1400), "Price change/Update request", 2 },
                    { 3, 4, new DateTime(2024, 3, 20, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1400), "New product", 1 },
                    { 4, 7, new DateTime(2024, 3, 25, 1, 18, 57, 622, DateTimeKind.Local).AddTicks(1420), "Delete request", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalQueue_ProductId",
                table: "ApprovalQueue",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovalQueue");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
