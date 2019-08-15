using System.IO;
using System.Reflection;
using FiscalCodeLib.Models;
using Microsoft.EntityFrameworkCore;

namespace FiscalCodeLib.Data.DataAccess
{
    public class SqliteDataAccessProvider : DbContext
    {
        public SqliteDataAccessProvider()
        {
        }

        public SqliteDataAccessProvider(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ForeignCountry> ForeignCountries { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<ItalianMunicipality> ItalianMunicipalities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite(GetConnectionString("places.db"));
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
            modelBuilder.Entity<Continent>().HasKey(c => c.Id);
            modelBuilder.Entity<Continent>().Property(c => c.Name).HasColumnName("continent_name");
        }

        private static void ConfigureForeignCountrySet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForeignCountry>().ToTable("Foreign_Countries").HasKey(fc => fc.Id);
            modelBuilder.Entity<ForeignCountry>().Property(fc => fc.ContinentId).HasColumnName("fk_continent_id");
            modelBuilder.Entity<ForeignCountry>().Property(fc => fc.Name).HasColumnName("foreign_country_name");
            modelBuilder.Entity<ForeignCountry>().Property(fc => fc.Code).HasColumnName("code");
        }

        private static void ConfigureProvinceSet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().ToTable("Italian_Provinces").HasKey(p => p.Id);
            modelBuilder.Entity<Province>().Property(p => p.Name).HasColumnName("province_name");
            modelBuilder.Entity<Province>().Property(p => p.Abbreviation).HasColumnName("province_abbr");
            modelBuilder.Entity<Province>().Property(p => p.AlternativeName)
                .HasColumnName("province_name_alternative");
            modelBuilder.Entity<Province>().Property(p => p.RegionId).HasColumnName("fk_id_italian_region");
        }

        private static void ConfigureRegionSet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().ToTable("Italian_Regions").HasKey(r => r.Id);
            modelBuilder.Entity<Region>().Property(r => r.Name).HasColumnName("region_name");
            modelBuilder.Entity<Region>().Property(r => r.AlternativeName)
                .HasColumnName("region_name_alternative");
        }

        private static void ConfigureMunicipalitySet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItalianMunicipality>().ToTable("Italian_Municipalities").HasKey(m => m.Id);
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.Name).HasColumnName("municipality_name");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.AlternativeName)
                .HasColumnName("municipality_name_alternative");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.ProvinceId).HasColumnName("fk_province_id");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.Code).HasColumnName("code");
        }

        private string GetConnectionString(string dbName)
        {
            var executable = Assembly.GetAssembly(typeof(SqliteDataAccessProvider)).Location;
            var path = Path.GetDirectoryName(executable) + "/Data";
            return $"Data Source={path}/{dbName}";
        }
    }
}