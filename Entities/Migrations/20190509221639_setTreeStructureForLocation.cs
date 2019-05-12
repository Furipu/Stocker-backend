using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class setTreeStructureForLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NodeId",
                table: "Location",
                newName: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ParentId",
                table: "Location",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Location_ParentId",
                table: "Location",
                column: "ParentId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Location_ParentId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_ParentId",
                table: "Location");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Location",
                newName: "NodeId");
        }
    }
}
