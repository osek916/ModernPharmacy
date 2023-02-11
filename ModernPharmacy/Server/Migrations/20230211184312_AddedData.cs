using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModernPharmacy.Server.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "ImagePath", "ModifiedById", "ModifiedDate", "ParentId", "Text", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "articleImages/antibiotics.jpg", null, null, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Antibiotics" },
                    { 2, 1, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "articleImages/nootropics.jpg", null, null, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Nootropics" },
                    { 3, 1, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "articleImages/painkillers.jpg", null, null, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Painkillers" },
                    { 4, 1, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "articleImages/antiepileptic.jpg", null, null, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Antiepileptic" },
                    { 5, 1, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "articleImages/sleep.jpg", null, null, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "SleepHigiene" },
                    { 6, 1, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), "articleImages/vitamins.jpg", null, null, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Vitamins" }
                });

            migrationBuilder.InsertData(
                table: "DifferentProducts",
                columns: new[] { "Id", "Description", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, "Needle Description", "needle", 0 },
                    { 2, "Bandages Description", "bandages", 0 },
                    { 3, "Atomizer Description", "atomizer", 0 },
                    { 4, "Hydrogen Dioxide Description", "hydrogen dioxide", 0 },
                    { 5, "Bacteriostatic Water Description", "bacteriostatic water", 0 },
                    { 6, "Urine Cup Description", "urine cup", 0 }
                });

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "Description", "LumpSumDrug", "MilligramsForTheWholeDrug", "MilligramsPerTablets", "Name", "NumberOfTablets", "PrescriptionRequired", "ProductId" },
                values: new object[,]
                {
                    { 1, "Description Apap", false, null, 500, "Apap", 10, false, 0 },
                    { 2, "Description Apap", false, null, 500, "Apap", 5, false, 0 },
                    { 3, "Description Apap", false, null, 500, "Apap", 20, false, 0 },
                    { 4, "Description Tylenol", false, null, 500, "Tylenol", 100, false, 0 },
                    { 5, "Description Nurofen", false, null, 200, "Nurofen", 20, false, 0 },
                    { 6, "Description Ibuprom", false, null, 200, "Ibuprom", 10, false, 0 },
                    { 7, "Description Tramal Retard", true, null, 100, "Tramal retard", 50, true, 0 },
                    { 8, "Description Valeriana", false, null, 2500, "Valeriana", 60, false, 0 },
                    { 9, "Description Morfeo", false, null, 10, "Morfeo", 10, false, 0 },
                    { 10, "Description Sonata", false, null, 10, "Sonata", 10, false, 0 },
                    { 11, "Description Aviomarin", false, null, 500, "Aviomarin", 5, false, 0 },
                    { 12, "Description Zirtec", true, null, 10, "Zirtec", 20, true, 0 }
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
                table: "Tags",
                columns: new[] { "Id", "ArticleId", "Name" },
                values: new object[,]
                {
                    { 1, null, "drug" },
                    { 2, null, "sleep" },
                    { 3, null, "bacteria" },
                    { 4, null, "suplements" },
                    { 5, null, "hygiene" },
                    { 6, null, "children" },
                    { 7, null, "pain" },
                    { 8, null, "insonomia" },
                    { 9, null, "brain" },
                    { 10, null, "heart" },
                    { 11, null, "diabetes" },
                    { 12, null, "bow" },
                    { 13, null, "anxiety" },
                    { 14, null, "fatigue" },
                    { 15, null, "depression" },
                    { 16, null, "health" },
                    { 17, null, "cold" },
                    { 18, null, "flu" }
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
                table: "ArticleTags",
                columns: new[] { "ArticleId", "TagId", "ArticleTagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 3, 2 },
                    { 1, 16, 3 },
                    { 1, 18, 4 },
                    { 2, 1, 5 },
                    { 2, 4, 6 },
                    { 2, 9, 7 },
                    { 3, 1, 8 },
                    { 3, 7, 9 },
                    { 3, 18, 10 },
                    { 5, 1, 11 },
                    { 5, 2, 12 },
                    { 5, 8, 13 },
                    { 6, 4, 14 },
                    { 6, 16, 15 }
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
                table: "Products",
                columns: new[] { "Id", "DifferentProductId", "DrugId", "ProposedPrice", "ShippingOption" },
                values: new object[,]
                {
                    { 1, null, 1, 17.99m, false },
                    { 2, null, 2, 15.20m, false },
                    { 3, null, 3, 12.59m, false },
                    { 4, null, 4, 10.99m, false },
                    { 5, null, 5, 2.39m, false },
                    { 6, null, 6, 10.99m, false },
                    { 7, null, 7, 20.29m, false },
                    { 8, null, 8, 34.99m, false },
                    { 9, null, 9, 23.99m, false },
                    { 10, null, 10, 7.99m, false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DifferentProductId", "DrugId", "ProposedPrice", "ShippingOption" },
                values: new object[,]
                {
                    { 11, null, 11, 41.99m, false },
                    { 12, null, 12, 37.99m, false },
                    { 13, 1, null, 23.99m, false },
                    { 14, 2, null, 54.99m, false },
                    { 15, 3, null, 23.99m, false },
                    { 16, 4, null, 13.99m, false },
                    { 17, 5, null, 11.99m, false },
                    { 18, 6, null, 4.99m, false }
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

            migrationBuilder.InsertData(
                table: "ProductStates",
                columns: new[] { "Id", "AmountOfProducts", "HowMuchHasBeenSold", "PharmacyId", "PriceForOne", "ProductId" },
                values: new object[,]
                {
                    { 1, 12, 0, 1, 20.99m, 1 },
                    { 2, 32, 0, 1, 17.99m, 2 },
                    { 3, 23, 0, 1, 15.99m, 3 },
                    { 4, 66, 0, 1, 12.99m, 4 },
                    { 5, 11, 0, 1, 3.99m, 5 },
                    { 6, 3, 0, 1, 12.99m, 6 },
                    { 7, 3, 0, 1, 22.99m, 7 },
                    { 8, 55, 0, 1, 35.99m, 8 },
                    { 9, 33, 0, 1, 27.99m, 9 },
                    { 10, 21, 0, 1, 9.99m, 10 },
                    { 11, 11, 0, 1, 44.99m, 11 },
                    { 12, 32, 0, 1, 40.99m, 12 },
                    { 13, 12, 0, 1, 25.99m, 13 },
                    { 14, 34, 0, 1, 55.99m, 14 },
                    { 15, 11, 0, 1, 26.99m, 15 },
                    { 16, 3, 0, 1, 16.99m, 16 },
                    { 17, 4, 0, 1, 13.99m, 17 },
                    { 18, 5, 0, 1, 6.99m, 18 },
                    { 19, 24, 0, 2, 21.99m, 1 },
                    { 20, 22, 0, 2, 18.99m, 2 },
                    { 21, 23, 0, 2, 16.99m, 3 },
                    { 22, 53, 0, 2, 4.99m, 5 },
                    { 23, 22, 0, 2, 13.99m, 6 },
                    { 24, 4, 0, 2, 23.99m, 7 },
                    { 25, 4, 0, 2, 36.99m, 8 },
                    { 26, 33, 0, 2, 10.99m, 10 },
                    { 27, 0, 0, 2, 45.99m, 11 },
                    { 28, 12, 0, 2, 41.99m, 12 },
                    { 29, 22, 0, 2, 56.99m, 14 },
                    { 30, 53, 0, 2, 27.99m, 15 },
                    { 31, 2, 0, 2, 17.99m, 16 },
                    { 32, 2, 0, 2, 14.99m, 17 },
                    { 33, 7, 0, 2, 7.99m, 18 },
                    { 34, 8, 0, 3, 22.99m, 1 },
                    { 35, 5, 0, 3, 18.99m, 2 },
                    { 36, 4, 0, 3, 14.99m, 4 },
                    { 37, 4, 0, 3, 5.99m, 5 },
                    { 38, 7, 0, 3, 13.99m, 6 },
                    { 39, 34, 0, 3, 23.99m, 7 },
                    { 40, 64, 0, 3, 37.99m, 8 },
                    { 41, 33, 0, 3, 28.99m, 9 },
                    { 42, 5, 0, 3, 12.99m, 10 }
                });

            migrationBuilder.InsertData(
                table: "ProductStates",
                columns: new[] { "Id", "AmountOfProducts", "HowMuchHasBeenSold", "PharmacyId", "PriceForOne", "ProductId" },
                values: new object[,]
                {
                    { 43, 1, 0, 3, 48.99m, 11 },
                    { 44, 34, 0, 3, 44.99m, 12 },
                    { 45, 54, 0, 3, 27.99m, 13 },
                    { 46, 0, 0, 3, 59.99m, 14 },
                    { 47, 0, 0, 3, 28.99m, 15 },
                    { 48, 0, 0, 3, 19.99m, 16 },
                    { 49, 7, 0, 3, 15.99m, 17 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ArticleTags",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "DrugSubstances",
                keyColumns: new[] { "DrugId", "SubstanceId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductStates",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "SubstanceSubstanceCategories",
                keyColumns: new[] { "SubstanceCategoryId", "SubstanceId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pharmacies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pharmacies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pharmacies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pharmacies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pharmacies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubstanceCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubstanceCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubstanceCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubstanceCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DifferentProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DifferentProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DifferentProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DifferentProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DifferentProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DifferentProducts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
