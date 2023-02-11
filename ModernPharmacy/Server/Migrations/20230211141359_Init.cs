using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModernPharmacy.Server.Migrations
{
    public partial class Init : Migration
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
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DifferentProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifferentProducts", x => x.Id);
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
                    MilligramsForTheWholeDrug = table.Column<int>(type: "int", nullable: true),
                    LumpSumDrug = table.Column<bool>(type: "bit", nullable: false),
                    PrescriptionRequired = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
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
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DifferentProductId = table.Column<int>(type: "int", nullable: true),
                    DrugId = table.Column<int>(type: "int", nullable: true),
                    ProposedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_DifferentProducts_DifferentProductId",
                        column: x => x.DifferentProductId,
                        principalTable: "DifferentProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "ProductStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PharmacyId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AmountOfProducts = table.Column<int>(type: "int", nullable: false),
                    PriceForOne = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStates_Pharmacies_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Pharmacies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStates_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Products_DifferentProductId",
                table: "Products",
                column: "DifferentProductId",
                unique: true,
                filter: "[DifferentProductId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DrugId",
                table: "Products",
                column: "DrugId",
                unique: true,
                filter: "[DrugId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStates_PharmacyId",
                table: "ProductStates",
                column: "PharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStates_ProductId",
                table: "ProductStates",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstanceSubstanceCategories_SubstanceCategoryId",
                table: "SubstanceSubstanceCategories",
                column: "SubstanceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstanceSubstanceCategory_SubstancesId",
                table: "SubstanceSubstanceCategory",
                column: "SubstancesId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ArticleId",
                table: "Tags",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "DrugSubstance");

            migrationBuilder.DropTable(
                name: "DrugSubstances");

            migrationBuilder.DropTable(
                name: "ProductStates");

            migrationBuilder.DropTable(
                name: "SubstanceSubstanceCategories");

            migrationBuilder.DropTable(
                name: "SubstanceSubstanceCategory");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Pharmacies");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubstanceCategories");

            migrationBuilder.DropTable(
                name: "Substances");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "DifferentProducts");

            migrationBuilder.DropTable(
                name: "Drugs");
        }
    }
}
