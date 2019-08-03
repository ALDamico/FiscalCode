using System.ComponentModel.DataAnnotations.Schema;
using FiscalCodeLib.Factories;
using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class ItalianMunicipalityModel : IPlace, IFiscalCodeModel
    {
        public ItalianMunicipalityModel(string name, string alternativeName, string code, int provinceId)
        {
            Name = name;
            AlternativeName = alternativeName;
            Code = code;
            ProvinceId = provinceId;
            ModelFactory.GetById(typeof(ProvinceModel), provinceId);
        }

        public int Id { get; private set; }
        public string AlternativeName { get; }

        [NotMapped] public ProvinceModel Province { get; private set; }

        public int ProvinceId { get; }
        public string Name { get; }
        public string Code { get; }

        public override string ToString()
        {
            return $"{Name} ({Province.Abbreviation})";
        }
    }
}