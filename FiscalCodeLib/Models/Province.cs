using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class Province : IFiscalCodeModel
    {
        public Province(string name, string abbreviation, string alternativeName, int regionId)
        {
            Name = name;
            Abbreviation = abbreviation;
            AlternativeName = alternativeName;
        }

        public Province(string name, string abbreviation, string alternativeName, Region region = null)
        {
            Name = name;
            Abbreviation = abbreviation;
            AlternativeName = alternativeName;
            Region = region;
        }

        public Province(string name, string abbreviation, string alternativeName)
        {
            Name = name;
            Abbreviation = abbreviation;
            AlternativeName = alternativeName;
            Region = null;
        }

        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int Id { get; set; }

        [NotMapped] public Region Region { get; set; }

        public string AlternativeName { get; set; }
    }
}