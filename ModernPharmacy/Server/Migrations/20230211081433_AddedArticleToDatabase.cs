using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModernPharmacy.Server.Migrations
{
    public partial class AddedArticleToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
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
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PharmacyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Pharmacies_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Pharmacies",
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
                    DrugId = table.Column<int>(type: "int", nullable: false),
                    SubstanceId = table.Column<int>(type: "int", nullable: false),
                    DrugSubstanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugSubstances", x => new { x.SubstanceId, x.DrugId });
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
                    SubstanceId = table.Column<int>(type: "int", nullable: false),
                    SubstanceCategoryId = table.Column<int>(type: "int", nullable: false),
                    SubstanceSubstanceCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubstanceSubstanceCategories", x => new { x.SubstanceId, x.SubstanceCategoryId });
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

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Description", "LumpSumDrug", "MilligramsPerTablets", "Name", "NumberOfTablets", "PrescriptionRequired", "ShippingOption" },
                values: new object[,]
                {
                    { 1, "Description Apap", false, 500, "Apap", 10, false, true },
                    { 2, "Description Apap", false, 500, "Apap", 5, false, true },
                    { 3, "Description Apap", false, 500, "Apap", 20, false, true },
                    { 4, "Description Tylenol", false, 500, "Tylenol", 100, false, true },
                    { 5, "Description Nurofen", false, 200, "Nurofen", 20, false, true },
                    { 6, "Description Ibuprom", false, 200, "Ibuprom", 10, false, true },
                    { 7, "Description Tramal Retard", true, 100, "Tramal retard", 50, true, false },
                    { 8, "Description Valeriana", false, 2500, "Valeriana", 60, false, false },
                    { 9, "Description Morfeo", false, 10, "Morfeo", 10, false, false },
                    { 10, "Description Sonata", false, 10, "Sonata", 10, false, false },
                    { 11, "Description Aviomarin", false, 500, "Aviomarin", 5, false, false },
                    { 12, "Description Zirtec", true, 10, "Zirtec", 20, true, false }
                });

            migrationBuilder.InsertData(
                table: "Pharmacies",
                columns: new[] { "Id", "AddressId", "ContactEmail", "ContactNumber", "HasPrescriptionDrugs", "Name" },
                values: new object[,]
                {
                    { 1, 0, "slowik@apteka.pl", "723171222", true, "Slownik" },
                    { 2, 0, "drugaapteka@apteka.pl", "594034033", true, "DrugaApteka" },
                    { 3, 0, "szczecinska@apteka.pl", "660650444", false, "Szczecinska" },
                    { 4, 0, "gryficka@wp.pl", "594033222", false, "Gryficka" },
                    { 5, 0, "kamil-losiak@wp.pl", "730660434", true, "ModernPharmacy" }
                });

            migrationBuilder.InsertData(
                table: "SubstanceCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description Painkiller", "Painkiller" },
                    { 2, "Description Sleeping pills", "Sleeping pills" },
                    { 3, "Description Antihistamines", "Antihistamines" },
                    { 4, "Description Antipsychotic", "Antypsychotic" }
                });

            migrationBuilder.InsertData(
                table: "Substances",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description Paracetamol", "Paracetamol" },
                    { 2, "Description Ibuprofen", "Ibuprofen" },
                    { 3, "Description Tramadol", "Tramadol" },
                    { 4, "Description Valeriana", "Valeriana" },
                    { 5, "Description Zaleplon", "Zaleplon" },
                    { 6, "Description Eszopiclone", "Eszopiclone" },
                    { 7, "Description Cetirizine", "Cetirizine" },
                    { 8, "Description Clemastine", "Clemastine" },
                    { 9, "Description Dimenhydrinate", "Dimenhydrinate" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PharmacyId", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Międzylesie", 1, "57530", "Graniczna 7" },
                    { 2, "Wrocław", 2, "21599", "Wolności 22c" },
                    { 3, "Szczecin", 3, "35300", "Słowiańska 3" },
                    { 4, "Gryfice", 4, "64554", "Poniatowska 4" },
                    { 5, "Gryfice", 5, "72-300", "Grunwaldzka 3" }
                });

            migrationBuilder.InsertData(
                table: "DrugSubstances",
                columns: new[] { "DrugId", "SubstanceId", "DrugSubstanceId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 4 },
                    { 5, 2, 5 },
                    { 6, 2, 6 },
                    { 7, 3, 7 },
                    { 8, 4, 8 },
                    { 9, 5, 9 },
                    { 10, 5, 10 },
                    { 11, 7, 12 },
                    { 12, 9, 11 }
                });

            migrationBuilder.InsertData(
                table: "SubstanceSubstanceCategories",
                columns: new[] { "SubstanceCategoryId", "SubstanceId", "SubstanceSubstanceCategoryId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 2 },
                    { 1, 3, 3 },
                    { 2, 4, 4 },
                    { 4, 4, 12 },
                    { 2, 5, 5 },
                    { 2, 6, 6 },
                    { 4, 6, 11 },
                    { 3, 7, 7 },
                    { 4, 7, 10 },
                    { 3, 8, 8 },
                    { 3, 9, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PharmacyId",
                table: "Addresses",
                column: "PharmacyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DrugSubstance_SubstancesId",
                table: "DrugSubstance",
                column: "SubstancesId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugSubstances_DrugId",
                table: "DrugSubstances",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstanceSubstanceCategories_SubstanceCategoryId",
                table: "SubstanceSubstanceCategories",
                column: "SubstanceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstanceSubstanceCategory_SubstancesId",
                table: "SubstanceSubstanceCategory",
                column: "SubstancesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "DrugSubstance");

            migrationBuilder.DropTable(
                name: "DrugSubstances");

            migrationBuilder.DropTable(
                name: "SubstanceSubstanceCategories");

            migrationBuilder.DropTable(
                name: "SubstanceSubstanceCategory");

            migrationBuilder.DropTable(
                name: "Pharmacies");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "SubstanceCategories");

            migrationBuilder.DropTable(
                name: "Substances");
        }
    }
}
