using System.ComponentModel.DataAnnotations.Schema;
using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class ForeignCountry : IPlace, IFiscalCodeModel
    {
        internal ForeignCountry(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public int Id { get; private set; }
        [NotMapped] public Continent Continent { get; set; }

        public string Name { get; }
        public string Code { get; }

        public override string ToString()
        {
            return $"{Name} ({Continent.Name})";
        }
    }
}