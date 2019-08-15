using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class ForeignCountry : IPlace, IFiscalCodeModel
    {
        internal ForeignCountry(string name, string code, int continentId)
        {
            Name = name;
            Code = code;
            ContinentId = continentId;
            using (var dap = new SqliteDataAccessProvider())
            {
                Continent = dap.Continents.FirstOrDefault(c => c.Id == continentId);
            }
        }

        public int Id { get; private set; }
        public int ContinentId { get; }
        [NotMapped] public Continent Continent { get; set; }

        public string Name { get; }
        public string Code { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}