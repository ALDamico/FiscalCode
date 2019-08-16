using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using FiscalCodeLib.Validator;
using Microsoft.EntityFrameworkCore;

//UNTESTED
namespace FiscalCodeLib.Data.Localization
{
    public class MysqlLocalizationProvider : DbContext, ILocalizationProvider
    {
        public MysqlLocalizationProvider(CultureInfo targetCulture)
        {
            TargetCulture = targetCulture;
        }

        public FiscalCodeValidationResult GetLocalizedMessage(string messageName)
        {
            return LocalizedMessages.FirstOrDefault(m =>
                m.MessageName == messageName && m.LanguageCode == TargetCulture.Name);
        }

        public FiscalCodeValidationResult GetFormattedLocalizedMessage(string messageName, object[] parameters)
        {
            var output = GetLocalizedMessage(messageName);
            output.Message = string.Format(output.Message, parameters);
            return output;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(GetConnectionString("places.db"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ValidationMessageDto>().ToTable("Validation_Messages").Property(vm => vm.Id)
                .HasColumnName("id");
            modelBuilder.Entity<ValidationMessageDto>().Property(vm => vm.MessageName).HasColumnName("message_name");
            modelBuilder.Entity<ValidationMessageDto>().Property(vm => vm.Message).HasColumnName("message");
            modelBuilder.Entity<ValidationMessageDto>().Property(vm => vm.LanguageCode).HasColumnName("language");
            modelBuilder.Entity<ValidationMessageDto>().Property(vm => vm.Result).HasColumnName("result");
            base.OnModelCreating(modelBuilder);
        }

        internal DbSet<ValidationMessageDto> LocalizedMessages { get; set; }

        private string GetConnectionString(string dbName)
        {
            var executable = Assembly.GetAssembly(typeof(SqliteLocalizationProvider)).Location;
            var path = Path.GetDirectoryName(executable) + "/Data";
            return $"Data Source={path}/{dbName}";
        }

        public CultureInfo TargetCulture { get; set; }
    }
}