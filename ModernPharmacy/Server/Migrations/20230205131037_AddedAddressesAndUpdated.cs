using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModernPharmacy.Server.Migrations
{
    public partial class AddedAddressesAndUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacies_Address_AddressId",
                table: "Pharmacies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "SubstanceCategoryId",
                table: "Substances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubstanceId",
                table: "Substances",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SubstanceCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubstanceCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Substances_SubstanceCategoryId",
                table: "Substances",
                column: "SubstanceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Substances_SubstanceId",
                table: "Substances",
                column: "SubstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacies_Addresses_AddressId",
                table: "Pharmacies",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Substances_SubstanceCategories_SubstanceCategoryId",
                table: "Substances",
                column: "SubstanceCategoryId",
                principalTable: "SubstanceCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Substances_Substances_SubstanceId",
                table: "Substances",
                column: "SubstanceId",
                principalTable: "Substances",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacies_Addresses_AddressId",
                table: "Pharmacies");

            migrationBuilder.DropForeignKey(
                name: "FK_Substances_SubstanceCategories_SubstanceCategoryId",
                table: "Substances");

            migrationBuilder.DropForeignKey(
                name: "FK_Substances_Substances_SubstanceId",
                table: "Substances");

            migrationBuilder.DropTable(
                name: "SubstanceCategories");

            migrationBuilder.DropIndex(
                name: "IX_Substances_SubstanceCategoryId",
                table: "Substances");

            migrationBuilder.DropIndex(
                name: "IX_Substances_SubstanceId",
                table: "Substances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "SubstanceCategoryId",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "SubstanceId",
                table: "Substances");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacies_Address_AddressId",
                table: "Pharmacies",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
