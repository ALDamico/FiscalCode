using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FiscalCodeLib.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FiscalCodeLib.Models
{
    public class ForeignCountryModel : IPlace
    {
        public int Id { get; private set; }

        internal ForeignCountryModel(string name, string code, int continentId)
        {
            Name = name;
            Code = code;
            ContinentId = continentId;
            using (DataAccessProvider dap = new DataAccessProvider())
            {
                Continent = dap.Continents.FirstOrDefault(c => c.Id == continentId);
            }
        }

        public string Name { get; private set; }
        public string Code { get; private set; }
        public int ContinentId { get; private set; }
        [NotMapped] public ContinentModel Continent { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}