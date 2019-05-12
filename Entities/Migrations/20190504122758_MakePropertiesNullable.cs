using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class MakePropertiesNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Country_CountryID",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Adress_PostCity_PostCityID",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Adress_AdressId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Quality_QualityID",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brand_BrandID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Location_LocationID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Quality_QualityID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Status_StatusID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Product_ProductID",
                table: "ProductVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Supplier_SupplierID",
                table: "ProductVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_Adress_AdressId",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Supplier_AdressId",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Brand_AdressId",
                table: "Brand");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Supplier",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Status",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Quality",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "ProductVersion",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductVersion",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ProductVersion",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVersion_SupplierID",
                table: "ProductVersion",
                newName: "IX_ProductVersion_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVersion_ProductID",
                table: "ProductVersion",
                newName: "IX_ProductVersion_ProductId");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "Product",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "QualityID",
                table: "Product",
                newName: "QualityId");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Product",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Product",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "BrandID",
                table: "Product",
                newName: "BrandId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Product",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Product_StatusID",
                table: "Product",
                newName: "IX_Product_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_QualityID",
                table: "Product",
                newName: "IX_Product_QualityId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_LocationID",
                table: "Product",
                newName: "IX_Product_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_BrandID",
                table: "Product",
                newName: "IX_Product_BrandId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PriceHistory",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PostCity",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Location",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Country",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Category",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "QualityID",
                table: "Brand",
                newName: "QualityId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Brand",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Brand_QualityID",
                table: "Brand",
                newName: "IX_Brand_QualityId");

            migrationBuilder.RenameColumn(
                name: "PostCityID",
                table: "Adress",
                newName: "PostCityId");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "Adress",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Adress",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Adress_PostCityID",
                table: "Adress",
                newName: "IX_Adress_PostCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Adress_CountryID",
                table: "Adress",
                newName: "IX_Adress_CountryId");

            migrationBuilder.AlterColumn<int>(
                name: "AdressId",
                table: "Supplier",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "ProductVersion",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "SubMunicipality",
                table: "PostCity",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "AdressId",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StreetNumber",
                table: "Adress",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_AdressId",
                table: "Supplier",
                column: "AdressId",
                unique: true,
                filter: "[AdressId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_AdressId",
                table: "Brand",
                column: "AdressId",
                unique: true,
                filter: "[AdressId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Country_CountryId",
                table: "Adress",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_PostCity_PostCityId",
                table: "Adress",
                column: "PostCityId",
                principalTable: "PostCity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Adress_AdressId",
                table: "Brand",
                column: "AdressId",
                principalTable: "Adress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Quality_QualityId",
                table: "Brand",
                column: "QualityId",
                principalTable: "Quality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brand_BrandId",
                table: "Product",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Location_LocationId",
                table: "Product",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Quality_QualityId",
                table: "Product",
                column: "QualityId",
                principalTable: "Quality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Status_StatusId",
                table: "Product",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Product_ProductId",
                table: "ProductVersion",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Supplier_SupplierId",
                table: "ProductVersion",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_Adress_AdressId",
                table: "Supplier",
                column: "AdressId",
                principalTable: "Adress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Country_CountryId",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Adress_PostCity_PostCityId",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Adress_AdressId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Quality_QualityId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brand_BrandId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Location_LocationId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Quality_QualityId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Status_StatusId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Product_ProductId",
                table: "ProductVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Supplier_SupplierId",
                table: "ProductVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_Adress_AdressId",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Supplier_AdressId",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Brand_AdressId",
                table: "Brand");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Supplier",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Status",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Quality",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "ProductVersion",
                newName: "SupplierID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductVersion",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductVersion",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVersion_SupplierId",
                table: "ProductVersion",
                newName: "IX_ProductVersion_SupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVersion_ProductId",
                table: "ProductVersion",
                newName: "IX_ProductVersion_ProductID");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Product",
                newName: "StatusID");

            migrationBuilder.RenameColumn(
                name: "QualityId",
                table: "Product",
                newName: "QualityID");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Product",
                newName: "LocationID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Product",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Product",
                newName: "BrandID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_StatusId",
                table: "Product",
                newName: "IX_Product_StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_QualityId",
                table: "Product",
                newName: "IX_Product_QualityID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_LocationId",
                table: "Product",
                newName: "IX_Product_LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                newName: "IX_Product_BrandID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PriceHistory",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PostCity",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Location",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Country",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "QualityId",
                table: "Brand",
                newName: "QualityID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brand",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Brand_QualityId",
                table: "Brand",
                newName: "IX_Brand_QualityID");

            migrationBuilder.RenameColumn(
                name: "PostCityId",
                table: "Adress",
                newName: "PostCityID");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Adress",
                newName: "CountryID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Adress",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Adress_PostCityId",
                table: "Adress",
                newName: "IX_Adress_PostCityID");

            migrationBuilder.RenameIndex(
                name: "IX_Adress_CountryId",
                table: "Adress",
                newName: "IX_Adress_CountryID");

            migrationBuilder.AlterColumn<int>(
                name: "AdressId",
                table: "Supplier",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "ProductVersion",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SubMunicipality",
                table: "PostCity",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdressId",
                table: "Brand",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StreetNumber",
                table: "Adress",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_AdressId",
                table: "Supplier",
                column: "AdressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brand_AdressId",
                table: "Brand",
                column: "AdressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Country_CountryID",
                table: "Adress",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_PostCity_PostCityID",
                table: "Adress",
                column: "PostCityID",
                principalTable: "PostCity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Adress_AdressId",
                table: "Brand",
                column: "AdressId",
                principalTable: "Adress",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Quality_QualityID",
                table: "Brand",
                column: "QualityID",
                principalTable: "Quality",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brand_BrandID",
                table: "Product",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Location_LocationID",
                table: "Product",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Quality_QualityID",
                table: "Product",
                column: "QualityID",
                principalTable: "Quality",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Status_StatusID",
                table: "Product",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Product_ProductID",
                table: "ProductVersion",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Supplier_SupplierID",
                table: "ProductVersion",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_Adress_AdressId",
                table: "Supplier",
                column: "AdressId",
                principalTable: "Adress",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
