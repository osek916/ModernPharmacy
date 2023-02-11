using Microsoft.EntityFrameworkCore;
using ModernPharmacy.Shared.Entities;

namespace ModernPharmacy.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Pharmacy>()
                .HasOne<Address>(p => p.Address)
                .WithOne(a => a.Pharmacy)
                .HasForeignKey<Address>(a => a.PharmacyId);
            
            modelBuilder.Entity<SubstanceSubstanceCategory>()
                .HasKey(ssc => new { ssc.SubstanceId, ssc.SubstanceCategoryId });

            modelBuilder.Entity<DrugSubstance>()
                .HasKey(ssc => new { ssc.SubstanceId, ssc.DrugId });

            modelBuilder.Entity<Drug>()
                .HasOne<Product>(d => d.Product)
                .WithOne(p => p.Drug)
                .HasForeignKey<Product>(d => d.DrugId);
            
            modelBuilder.Entity<DifferentProduct>()
                .HasOne<Product>(p => p.Product)
                .WithOne(p => p.DifferentProduct)
                .HasForeignKey<Product>(d => d.DifferentProductId);

            
            /*

            modelBuilder.Entity<SubstanceCategory>().HasData(
                    new SubstanceCategory { Id = 1, Name = "Painkiller", Description = "Description Painkiller" },
                    new SubstanceCategory { Id = 2, Name = "Sleeping pills", Description = "Description Sleeping pills"},
                    new SubstanceCategory { Id = 3, Name = "Antihistamines", Description = "Description Antihistamines" },
                    new SubstanceCategory { Id = 4, Name = "Antypsychotic", Description = "Description Antipsychotic" }
                );

            modelBuilder.Entity<Substance>().HasData(
                    new Substance { Id = 1, Name = "Paracetamol", Description = "Description Paracetamol"  },
                    new Substance { Id = 2, Name = "Ibuprofen", Description = "Description Ibuprofen" },
                    new Substance { Id = 3, Name = "Tramadol", Description = "Description Tramadol" },
                    new Substance { Id = 4, Name = "Valeriana", Description = "Description Valeriana" },
                    new Substance { Id = 5, Name = "Zaleplon", Description = "Description Zaleplon" },
                    new Substance { Id = 6, Name = "Eszopiclone", Description = "Description Eszopiclone" },
                    new Substance { Id = 7, Name = "Cetirizine", Description = "Description Cetirizine" },
                    new Substance { Id = 8, Name = "Clemastine", Description = "Description Clemastine" },
                    new Substance { Id = 9, Name = "Dimenhydrinate", Description = "Description Dimenhydrinate" }
                );            
            
            modelBuilder.Entity<Pharmacy>().HasData(
                    new Pharmacy { Id = 1, ContactEmail = "slowik@apteka.pl", ContactNumber = "723171222", Name = "Slownik", HasPrescriptionDrugs = true  },
                    new Pharmacy { Id = 2, ContactEmail = "drugaapteka@apteka.pl", ContactNumber = "594034033", Name = "DrugaApteka", HasPrescriptionDrugs = true },
                    new Pharmacy { Id = 3, ContactEmail = "szczecinska@apteka.pl", ContactNumber = "660650444", Name = "Szczecinska", HasPrescriptionDrugs = false},
                    new Pharmacy { Id = 4, ContactEmail = "gryficka@wp.pl", ContactNumber = "594033222", Name = "Gryficka", HasPrescriptionDrugs = false },
                    new Pharmacy { Id = 5, ContactEmail = "kamil-losiak@wp.pl", ContactNumber = "730660434", Name = "ModernPharmacy", HasPrescriptionDrugs = true }
                );

            modelBuilder.Entity<Address>().HasData(
                    new Address { Id = 1, PharmacyId = 1, City = "Międzylesie", PostalCode = "57530", Street = "Graniczna 7" },
                    new Address { Id = 2, PharmacyId = 2, City = "Wrocław", PostalCode = "21599", Street = "Wolności 22c" },
                    new Address { Id = 3, PharmacyId = 3, City = "Szczecin", PostalCode = "35300", Street = "Słowiańska 3" },
                    new Address { Id = 4, PharmacyId = 4, City = "Gryfice", PostalCode = "64554", Street = "Poniatowska 4" },
                    new Address { Id = 5, PharmacyId = 5, City = "Gryfice", PostalCode = "72-300", Street = "Grunwaldzka 3" }
                );

            modelBuilder.Entity<Drug>().HasData(
                    new Drug { Id = 1, Name = "Apap", Description = "Description Apap", PrescriptionRequired = false, LumpSumDrug = false, MilligramsPerTablets = 500, NumberOfTablets = 10 },
                    new Drug { Id = 2, Name = "Apap", Description = "Description Apap", PrescriptionRequired = false, LumpSumDrug = false, MilligramsPerTablets = 500, NumberOfTablets = 5 },
                    new Drug { Id = 3, Name = "Apap", Description = "Description Apap", PrescriptionRequired = false, LumpSumDrug = false, MilligramsPerTablets = 500, NumberOfTablets = 20 },
                    new Drug { Id = 4, Name = "Tylenol", Description = "Description Tylenol", PrescriptionRequired = false, LumpSumDrug = false, MilligramsPerTablets = 500, NumberOfTablets = 100 },
                    new Drug { Id = 5, Name = "Nurofen", Description = "Description Nurofen", PrescriptionRequired = false, LumpSumDrug = false, MilligramsPerTablets = 200, NumberOfTablets = 20 },
                    new Drug { Id = 6, Name = "Ibuprom", Description = "Description Ibuprom", PrescriptionRequired = false, LumpSumDrug = false, MilligramsPerTablets = 200, NumberOfTablets = 10 },
                    new Drug { Id = 7, Name = "Tramal retard", Description = "Description Tramal Retard", PrescriptionRequired = true, ShippingOption = false, LumpSumDrug = true, MilligramsPerTablets = 100, NumberOfTablets = 50 },
                    new Drug { Id = 8, Name = "Valeriana", Description = "Description Valeriana", PrescriptionRequired = false, LumpSumDrug = false, ShippingOption = false, MilligramsPerTablets = 2500, NumberOfTablets = 60 },
                    new Drug { Id = 9, Name = "Morfeo", Description = "Description Morfeo", PrescriptionRequired = false, LumpSumDrug = false, ShippingOption = false, MilligramsPerTablets = 10, NumberOfTablets = 10 },
                    new Drug { Id = 10, Name = "Sonata", Description = "Description Sonata", PrescriptionRequired = false, LumpSumDrug = false, ShippingOption = false, MilligramsPerTablets = 10, NumberOfTablets = 10 },
                    new Drug { Id = 11, Name = "Aviomarin", Description = "Description Aviomarin", PrescriptionRequired = false, LumpSumDrug = false, ShippingOption = false, MilligramsPerTablets = 500, NumberOfTablets = 5 },
                    new Drug { Id = 12, Name = "Zirtec", Description = "Description Zirtec", PrescriptionRequired = true, LumpSumDrug = true, ShippingOption = false, MilligramsPerTablets = 10, NumberOfTablets = 20 }
                );

            modelBuilder.Entity<SubstanceSubstanceCategory>().HasData(
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 1, SubstanceCategoryId = 1, SubstanceId = 1 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 2, SubstanceCategoryId = 1, SubstanceId = 2 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 3, SubstanceCategoryId = 1, SubstanceId = 3 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 4, SubstanceCategoryId = 2, SubstanceId = 4 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 5, SubstanceCategoryId = 2, SubstanceId = 5 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 6, SubstanceCategoryId = 2, SubstanceId = 6 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 7, SubstanceCategoryId = 3, SubstanceId = 7 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 8, SubstanceCategoryId = 3, SubstanceId = 8 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 9, SubstanceCategoryId = 3, SubstanceId = 9 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 10, SubstanceCategoryId = 4, SubstanceId = 7 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 11, SubstanceCategoryId = 4, SubstanceId = 6 },
                    new SubstanceSubstanceCategory { SubstanceSubstanceCategoryId = 12, SubstanceCategoryId = 4, SubstanceId = 4 }
                );

            modelBuilder.Entity<DrugSubstance>().HasData(
                    new DrugSubstance { DrugSubstanceId = 1, DrugId = 1, SubstanceId = 1 },
                    new DrugSubstance { DrugSubstanceId = 2, DrugId = 2, SubstanceId = 1 },
                    new DrugSubstance { DrugSubstanceId = 3, DrugId = 3, SubstanceId = 1 },
                    new DrugSubstance { DrugSubstanceId = 4, DrugId = 4, SubstanceId = 2 },
                    new DrugSubstance { DrugSubstanceId = 5, DrugId = 5, SubstanceId = 2 },
                    new DrugSubstance { DrugSubstanceId = 6, DrugId = 6, SubstanceId = 2 },
                    new DrugSubstance { DrugSubstanceId = 7, DrugId = 7, SubstanceId = 3 },
                    new DrugSubstance { DrugSubstanceId = 8, DrugId = 8, SubstanceId = 4 },
                    new DrugSubstance { DrugSubstanceId = 9, DrugId = 9, SubstanceId = 5 },
                    new DrugSubstance { DrugSubstanceId = 10, DrugId = 10, SubstanceId = 5 },
                    new DrugSubstance { DrugSubstanceId = 11, DrugId = 12, SubstanceId = 9 },
                    new DrugSubstance { DrugSubstanceId = 12, DrugId = 11, SubstanceId = 7}
                );

            modelBuilder.Entity<Tag>().HasData(
                    new Tag { Id = 1, Name = "drug"},
                    new Tag { Id = 2, Name = "sleep" },
                    new Tag { Id = 3, Name = "bacteria" },
                    new Tag { Id = 4, Name = "suplements" },
                    new Tag { Id = 5, Name = "hygiene" },
                    new Tag { Id = 5, Name = "children" },
                    new Tag { Id = 5, Name = "pain" },
                    new Tag { Id = 5, Name = "insonomia" },
                    new Tag { Id = 5, Name = "brain" },
                    new Tag { Id = 5, Name = "heart" },
                    new Tag { Id = 5, Name = "diabetes" },
                    new Tag { Id = 5, Name = "bow" },
                    new Tag { Id = 5, Name = "anxiety" },
                    new Tag { Id = 5, Name = "fatigue" },
                    new Tag { Id = 5, Name = "depression" },
                );
            
               modelBuilder.Entity<Article>().HasData(
                    new Article { Id = 1, Title = "Antibiotics", CreatedById = 1, CreatedDate = DateTime.Today, ImagePath = "articleImages/drugs1.jpg", Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new Article { Id = 2, Title = "Nootropics", CreatedById = 1, CreatedDate = DateTime.Today, ImagePath = "articleImages/drugs1.jpg", Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new Article { Id = 3, Title = "Painkillers", CreatedById = 1, CreatedDate = DateTime.Today, ImagePath = "articleImages/drugs1.jpg", Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new Article { Id = 4, Title = "Antiepileptic", CreatedById = 1, CreatedDate = DateTime.Today, ImagePath = "articleImages/drugs1.jpg", Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new Article { Id = 5, Title = "SleepHigiene", CreatedById = 1, CreatedDate = DateTime.Today, ImagePath = "articleImages/drugs1.jpg", Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new Article { Id = 6, Title = "Antibiotics", CreatedById = 1, CreatedDate = DateTime.Today, ImagePath = "articleImages/drugs1.jpg", Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new Article { Id = 7, Title = "Antibiotics", CreatedById = 1, CreatedDate = DateTime.Today, ImagePath = "articleImages/drugs1.jpg", Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },


                    );
             
            */

        }
        public DbSet<SubstanceCategory> SubstanceCategories { get; set; }
        public DbSet<Substance> Substances { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<SubstanceSubstanceCategory> SubstanceSubstanceCategories { get; set; }
        public DbSet<DrugSubstance> DrugSubstances { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<DifferentProduct> DifferentProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductState> ProductStates { get; set; }
    }
}
