using System.ComponentModel.DataAnnotations.Schema;
using FiscalCodeLib.Factories;
using FiscalCodeLib.Interfaces;

namespace FiscalCodeLib.Models
{
    public class ItalianMunicipality : IPlace, IFiscalCodeModel
    {
        public ItalianMunicipality(string name, string alternativeName, string code, int provinceId)
        {
            Name = name;
            AlternativeName = alternativeName;
            Code = code;
            ProvinceId = provinceId;
            ModelFactory.GetById(typeof(Province), provinceId);
        }

        public int Id { get; private set; }
        public string AlternativeName { get; }

        [NotMapped] public Province Province { get; private set; }

        public int ProvinceId { get; }
        public string Name { get; }
        public string Code { get; }

        public override string ToString()
        {
            return $"{Name} ({Province.Abbreviation})";
        }
    }
}