using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class TablesRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Store",
                table: "Sales",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Customer",
                table: "Sales",
                newName: "storeId");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoresStoreId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "productsProductId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId1",
                table: "Sales",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_productsProductId",
                table: "Sales",
                column: "productsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_StoresStoreId",
                table: "Sales",
                column: "StoresStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_CustomerId1",
                table: "Sales",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Products_productsProductId",
                table: "Sales",
                column: "productsProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Stores_StoresStoreId",
                table: "Sales",
                column: "StoresStoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_CustomerId1",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_productsProductId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Stores_StoresStoreId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CustomerId1",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_productsProductId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_StoresStoreId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "StoresStoreId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "productsProductId",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "storeId",
                table: "Sales",
                newName: "Customer");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Sales",
                newName: "Store");
        }
    }
}
