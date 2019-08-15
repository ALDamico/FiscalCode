using System.IO;
using System.Reflection;
using FiscalCodeLib.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace FiscalCodeLib.Data.Localization
{
    public class SqliteLocalizationProvider : DbContext
    {
        SqliteLocalizationProvider()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(GetConnectionString("places.db"));
            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString(string dbName)
        {
            var executable = Assembly.GetAssembly(typeof(SqliteLocalizationProvider)).Location;
            var path = Path.GetDirectoryName(executable) + "/Data";
            return $"Data Source={path}/{dbName}";
        }
    }
}