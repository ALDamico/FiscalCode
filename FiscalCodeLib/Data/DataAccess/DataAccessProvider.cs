using FiscalCodeLib.Models;
using Microsoft.EntityFrameworkCore;

namespace FiscalCodeLib.Data.DataAccess
{
    public class DataAccessProvider : DbContext
    {
        public DataAccessProvider()
        {
        }

        public DataAccessProvider(DbContextOptions<DataAccessProvider> options)
            : base(options)
        {
        }

        public DbSet<ForeignCountryModel> ForeignCountries { get; set; }
        public DbSet<ContinentModel> Continents { get; set; }
        public DbSet<RegionModel> Regions { get; set; }
        public DbSet<ProvinceModel> Provinces { get; set; }
        public DbSet<ItalianMunicipalityModel> ItalianMunicipalities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("DataSource=E:/Rider Projects/FiscalCode/FiscalCodeLib/Data/places.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureForeignCountrySet(modelBuilder);
            ConfigureContinentSet(modelBuilder);
            ConfigureRegionSet(modelBuilder);
            ConfigureProvinceSet(modelBuilder);
            ConfigureMunicipalitySet(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
        }

        private static void ConfigureContinentSet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContinentModel>().HasKey(c => c.Id);
            modelBuilder.Entity<ContinentModel>().Property(c => c.Name).HasColumnName("continent_name");
        }

        private static void ConfigureForeignCountrySet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForeignCountryModel>().ToTable("Foreign_Countries").HasKey(fc => fc.Id);
            modelBuilder.Entity<ForeignCountryModel>().Property(fc => fc.ContinentId).HasColumnName("fk_continent_id");
            modelBuilder.Entity<ForeignCountryModel>().Property(fc => fc.Name).HasColumnName("foreign_country_name");
            modelBuilder.Entity<ForeignCountryModel>().Property(fc => fc.Code).HasColumnName("code");
        }

        private static void ConfigureProvinceSet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProvinceModel>().ToTable("Italian_Provinces").HasKey(p => p.Id);
            modelBuilder.Entity<ProvinceModel>().Property(p => p.Name).HasColumnName("province_name");
            modelBuilder.Entity<ProvinceModel>().Property(p => p.Abbreviation).HasColumnName("province_abbr");
            modelBuilder.Entity<ProvinceModel>().Property(p => p.AlternativeName)
                .HasColumnName("province_name_alternative");
            modelBuilder.Entity<ProvinceModel>().Property(p => p.RegionId).HasColumnName("fk_id_italian_region");
        }

        private static void ConfigureRegionSet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegionModel>().ToTable("Italian_Regions").HasKey(r => r.Id);
            modelBuilder.Entity<RegionModel>().Property(r => r.Name).HasColumnName("region_name");
            modelBuilder.Entity<RegionModel>().Property(r => r.AlternativeName)
                .HasColumnName("region_name_alternative");
        }

        private static void ConfigureMunicipalitySet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItalianMunicipalityModel>().ToTable("Italian_Municipalities").HasKey(m => m.Id);
            modelBuilder.Entity<ItalianMunicipalityModel>().Property(m => m.Name).HasColumnName("municipality_name");
            modelBuilder.Entity<ItalianMunicipalityModel>().Property(m => m.AlternativeName)
                .HasColumnName("municipality_name_alternative");
            modelBuilder.Entity<ItalianMunicipalityModel>().Property(m => m.ProvinceId).HasColumnName("fk_province_id");
            modelBuilder.Entity<ItalianMunicipalityModel>().Property(m => m.Code).HasColumnName("code");
        }
    }
}