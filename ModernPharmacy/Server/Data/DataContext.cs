using Microsoft.EntityFrameworkCore;

namespace ModernPharmacy.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SubstanceCategory> SubstanceCategories { get; set; }
        public DbSet<Substance> Substances { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Drug> Drugs { get; set; }
    }
}
