using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiscalCodeLib.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace FiscalCodeLib.Data.DataAccess
{
    public class MysqlDataAccessProvider : DbContext, IDataAccessProvider
    {
        public MysqlDataAccessProvider()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=fiscalcode;Uid=root;Pwd=breathingsorrow;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItalianMunicipality>().ToTable("italian_municipalities");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.Id).HasColumnName("id");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.Name).HasColumnName("municipality_name");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.AlternativeName)
                .HasColumnName("municipality_name_alternative");
            modelBuilder.Entity<ItalianMunicipality>().Property(m => m.Code).HasColumnName("code");
            modelBuilder.Entity<ItalianMunicipality>().Property("ProvinceId").HasColumnName("fk_province_id");
//            modelBuilder.Entity<ItalianMunicipality>().HasOne<Province>(m => Provinces.FirstOrDefault(p => p.Id == m.Province.Id)).WithMany()
//                .HasForeignKey("fk_province_id");

            //Provinces
            modelBuilder.Entity<Province>().ToTable("italian_provinces");
            modelBuilder.Entity<Province>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Province>().Property(p => p.Name).HasColumnName("province_name");
            modelBuilder.Entity<Province>().Property(p => p.AlternativeName)
                .HasColumnName("province_name_alternative");
            modelBuilder.Entity<Province>().Property(p => p.Abbreviation).HasColumnName("province_abbr");
            modelBuilder.Entity<Province>().HasOne<Region>(p => p.Region).WithMany()
                .HasForeignKey("fk_id_italian_region");

            //Regions
            modelBuilder.Entity<Region>().ToTable("italian_regions");
            modelBuilder.Entity<Region>().Property(r => r.Id).HasColumnName("id");
            modelBuilder.Entity<Region>().Property(r => r.Name).HasColumnName("region_name");
            modelBuilder.Entity<Region>().Property(r => r.AlternativeName)
                .HasColumnName("region_name_alternative");
        }

        public DbSet<ItalianMunicipality> ItalianMunicipalities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Province> Provinces { get; set; }

        public Task<ItalianMunicipality> GetMunicipalityByNameAsync(string name)
        {
            var result = ItalianMunicipalities.Include(m => m.Province)
                .ThenInclude(p => p.Region)
                .FirstOrDefaultAsync(m => m.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase));
            return result;
        }

        public Task<List<ItalianMunicipality>> GetAllMunicipalitiesAsListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ForeignCountry>> GetAllForeignCountriesAsListAsync()
        {
            throw new System.NotImplementedException();
        }

        public ForeignCountry GetForeignCountryByNameAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public ItalianMunicipality GetMunicipalityByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<ItalianMunicipality> GetAllMunicipalitiesAsList()
        {
            throw new NotImplementedException();
        }

        public ForeignCountry GetForeignCountryByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<ForeignCountry> GetAllForeignCountriesAsList()
        {
            throw new NotImplementedException();
        }

        public List<Province> GetProvincesInRegion(string regionName)
        {
            throw new NotImplementedException();
        }

        public List<Region> GetAllRegionsAsList()
        {
            throw new NotImplementedException();
        }

        public List<ItalianMunicipality> GetMunicipalitiesInProvince(string provinceName)
        {
            throw new NotImplementedException();
        }
    }
}