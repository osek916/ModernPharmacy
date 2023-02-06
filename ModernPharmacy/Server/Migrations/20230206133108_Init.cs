using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModernPharmacy.Server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTablets = table.Column<int>(type: "int", nullable: true),
                    MilligramsPerTablets = table.Column<int>(type: "int", nullable: true),
                    LumpSumDrug = table.Column<bool>(type: "bit", nullable: false),
                    PrescriptionRequired = table.Column<bool>(type: "bit", nullable: false),
                    ShippingOption = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Substances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasPrescriptionDrugs = table.Column<bool>(type: "bit", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pharmacies_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrugSubstance",
                columns: table => new
                {
                    DrugsId = table.Column<int>(type: "int", nullable: false),
                    SubstancesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugSubstance", x => new { x.DrugsId, x.SubstancesId });
                    table.ForeignKey(
                        name: "FK_DrugSubstance_Drugs_DrugsId",
                        column: x => x.DrugsId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugSubstance_Substances_SubstancesId",
                        column: x => x.SubstancesId,
                        principalTable: "Substances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrugSubstances",
                columns: table => new
                {
                    DrugSubstanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugId = table.Column<int>(type: "int", nullable: false),
                    SubstanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugSubstances", x => x.DrugSubstanceId);
                    table.ForeignKey(
                        name: "FK_DrugSubstances_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugSubstances_Substances_SubstanceId",
                        column: x => x.SubstanceId,
                        principalTable: "Substances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubstanceSubstanceCategories",
                columns: table => new
                {
                    SubstanceSubstanceCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubstanceId = table.Column<int>(type: "int", nullable: false),
                    SubstanceCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubstanceSubstanceCategories", x => x.SubstanceSubstanceCategoryId);
                    table.ForeignKey(
                        name: "FK_SubstanceSubstanceCategories_SubstanceCategories_SubstanceCategoryId",
                        column: x => x.SubstanceCategoryId,
                        principalTable: "SubstanceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubstanceSubstanceCategories_Substances_SubstanceId",
                        column: x => x.SubstanceId,
                        principalTable: "Substances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubstanceSubstanceCategory",
                columns: table => new
                {
                    SubstanceCategoriesId = table.Column<int>(type: "int", nullable: false),
                    SubstancesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubstanceSubstanceCategory", x => new { x.SubstanceCategoriesId, x.SubstancesId });
                    table.ForeignKey(
                        name: "FK_SubstanceSubstanceCategory_SubstanceCategories_SubstanceCategoriesId",
                        column: x => x.SubstanceCategoriesId,
                        principalTable: "SubstanceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubstanceSubstanceCategory_Substances_SubstancesId",
                        column: x => x.SubstancesId,
                        principalTable: "Substances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrugSubstance_SubstancesId",
                table: "DrugSubstance",
                column: "SubstancesId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugSubstances_DrugId",
                table: "DrugSubstances",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugSubstances_SubstanceId",
                table: "DrugSubstances",
                column: "SubstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacies_AddressId",
                table: "Pharmacies",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubstanceSubstanceCategories_SubstanceCategoryId",
                table: "SubstanceSubstanceCategories",
                column: "SubstanceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstanceSubstanceCategories_SubstanceId",
                table: "SubstanceSubstanceCategories",
                column: "SubstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstanceSubstanceCategory_SubstancesId",
                table: "SubstanceSubstanceCategory",
                column: "SubstancesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrugSubstance");

            migrationBuilder.DropTable(
                name: "DrugSubstances");

            migrationBuilder.DropTable(
                name: "Pharmacies");

            migrationBuilder.DropTable(
                name: "SubstanceSubstanceCategories");

            migrationBuilder.DropTable(
                name: "SubstanceSubstanceCategory");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "SubstanceCategories");

            migrationBuilder.DropTable(
                name: "Substances");
        }
    }
}
