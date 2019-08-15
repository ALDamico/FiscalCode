using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FiscalCodeLib.Interfaces;
using FiscalCodeLib.Models;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;

namespace FiscalCodeLib.Data.DataAccess
{
    public class SqliteDataAccessProvider : DbContext, IDataAccessProvider
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
            modelBuilder.Entity<Continent>().ToTable("Continents").HasKey(c => c.Id);
            modelBuilder.Entity<Continent>().Property(c => c.Name).HasColumnName("continent_name");
            modelBuilder.Entity<Continent>().HasMany<ForeignCountry>().WithOne(fc => fc.Continent);
        }

        private static void ConfigureForeignCountrySet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForeignCountry>().ToTable("Foreign_Countries").HasKey(fc => fc.Id);
            modelBuilder.Entity<ForeignCountry>().Property(fc => fc.Name).HasColumnName("foreign_country_name");
            modelBuilder.Entity<ForeignCountry>().Property(fc => fc.Code).HasColumnName("code");
            modelBuilder.Entity<ForeignCountry>().HasOne<Continent>(fc => fc.Continent).WithMany()
                .HasForeignKey("fk_continent_id");
        }

        private static void ConfigureProvinceSet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().ToTable("Italian_Provinces").HasKey(p => p.Id);
            modelBuilder.Entity<Province>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Province>().Property(p => p.Name).HasColumnName("province_name");
            modelBuilder.Entity<Province>().Property(p => p.Abbreviation).HasColumnName("province_abbr");
            modelBuilder.Entity<Province>().Property(p => p.AlternativeName)
                .HasColumnName("province_name_alternative");
            modelBuilder.Entity<Province>().HasOne<ItalianMunicipality>().WithOne(m => m.Province);
            modelBuilder.Entity<Province>().HasOne<Region>(p => p.Region).WithMany()
                .HasForeignKey("fk_id_italian_region");
        }

        private static void ConfigureRegionSet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().ToTable("Italian_Regions").HasKey(r => r.Id);
            modelBuilder.Entity<Region>().Property(r => r.Name).HasColumnName("region_name");
            modelBuilder.Entity<Region>().Property(r => r.AlternativeName)
                .HasColumnName("region_name_alternative");
            modelBuilder.Entity<Region>().HasMany<Province>().WithOne(p => p.Region);
        }

        private void ConfigureMunicipalitySet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItalianMunicipality>().ToTable("Italian_Municipalities").HasKey(m => m.Id);
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.Id).HasColumnName("id");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.Name).HasColumnName("municipality_name");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.AlternativeName)
                .HasColumnName("municipality_name_alternative");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.Code).HasColumnName("code");

            //modelBuilder.Entity<ItalianMunicipality>().Property<int>("ProvinceId").HasColumnName("fk_province_id");
            modelBuilder.Entity<ItalianMunicipality>().HasOne<Province>(m => m.Province).WithMany()
                .HasForeignKey("fk_province_id");
        }

        private string GetConnectionString(string dbName)
        {
            var executable = Assembly.GetAssembly(typeof(SqliteDataAccessProvider)).Location;
            var path = Path.GetDirectoryName(executable) + "/Data";
            return $"Data Source={path}/{dbName}";
        }

        public Task<ItalianMunicipality> GetMunicipalityByNameAsync(string name)
        {
            var result = ItalianMunicipalities.Include(m => m.Province)
                .ThenInclude(p => p.Region)
                .FirstOrDefaultAsync(m => m.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase));
            return result;
        }

        public Task<List<ItalianMunicipality>> GetAllMunicipalitiesAsListAsync()
        {
            var t = (from italianMunicipality in ItalianMunicipalities select italianMunicipality).ToListAsync();
            return t;
        }


        public Task<List<ForeignCountry>> GetAllForeignCountriesAsListAsync()
        {
            return (from foreignCountry in ForeignCountries select foreignCountry).ToListAsync();
        }

        public ForeignCountry GetForeignCountryByNameAsync(string name)
        {
            var result = ForeignCountries.Include(fc => fc.Continent).FirstOrDefault(fc =>
                fc.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase));
            return result;
        }

        public ItalianMunicipality GetMunicipalityByName(string name)
        {
            var result = ItalianMunicipalities.Include(m => m.Province)
                .ThenInclude(p => p.Region)
                .FirstOrDefault(m => m.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase));
            return result;
        }

        public List<ItalianMunicipality> GetAllMunicipalitiesAsList()
        {
            var result = ItalianMunicipalities.Include(m => m.Province).ThenInclude(p => p.Region).ToList();
            return result;
        }

        public ForeignCountry GetForeignCountryByName(string name)
        {
            var result = ForeignCountries.Include(fc => fc.Continent).FirstOrDefault(fc =>
                fc.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase));
            return result;
        }

        public List<ForeignCountry> GetAllForeignCountriesAsList()
        {
            var result = ForeignCountries.Include(fc => fc.Continent).ToList();
            return result;
        }

        public List<Province> GetProvincesInRegion(string regionName)
        {
            var result = Provinces.Include(p => p.Region).Where(p =>
                p.Region.Name.Contains(regionName, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return result;
        }

        public List<Region> GetAllRegionsAsList()
        {
            return Regions.ToList();
        }

        public List<ItalianMunicipality> GetMunicipalitiesInProvince(string provinceName)
        {
            var result = ItalianMunicipalities.Include(m => m.Province).ThenInclude(p => p.Region).Where(m =>
                m.Province.Name.Contains(provinceName, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return result;
        }

        public IPlace GetPlaceByName(string placeName)
        {
            if (string.IsNullOrWhiteSpace(placeName))
            {
                throw new ArgumentException("The parameter placeName can't be null or whitespace");
            }

            IPlace output = GetMunicipalityByName(placeName);
            if (output == null)
            {
                output = GetForeignCountryByName(placeName);
            }

            return output;
        }
    }
}