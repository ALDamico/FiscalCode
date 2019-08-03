using System;
using FiscalCodeLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FiscalCodeLib
{
    public partial class DataAccessProvider : DbContext
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
            ConfigureForeignContrySet(modelBuilder);

            ConfigureContinentSet(modelBuilder);
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
        }

        private static void ConfigureContinentSet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContinentModel>().HasKey(c => c.Id);
            modelBuilder.Entity<ContinentModel>().Property(c => c.Name).HasColumnName("continent_name");
        }

        private static void ConfigureForeignContrySet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForeignCountryModel>().ToTable("Foreign_Countries").HasKey(fc => fc.Id);
            modelBuilder.Entity<ForeignCountryModel>().Property(fc => fc.ContinentId).HasColumnName("fk_continent_id");
            modelBuilder.Entity<ForeignCountryModel>().Property(fc => fc.Name).HasColumnName("foreign_country_name");
            modelBuilder.Entity<ForeignCountryModel>().Property(fc => fc.Code).HasColumnName("code");
        }
    }
}