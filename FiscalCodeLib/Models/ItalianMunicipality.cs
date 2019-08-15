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
            Province = new Province("", "", "", provinceId);
            //Province = ModelFactory.GetById(typeof(Province), provinceId) as Province;
        }

        public ItalianMunicipality(string name, string alternativeName, string code, Province province)
        {
            Name = name;
            AlternativeName = alternativeName;
            Code = code;
            Province = province;
        }

        public ItalianMunicipality(string name, string alternativeName, string code)
        {
            Name = name;
            AlternativeName = alternativeName;
            Code = code;
        }

        public ItalianMunicipality(int id, string name, string alternativeName, string code, Province province)
        {
            Id = id;
            Name = name;
            AlternativeName = alternativeName;
            Code = code;
            Province = province;
        }

        public int Id { get; set; }
        public string AlternativeName { get; set; }

        public Province Province { get; set; }


        public string Name { get; }
        public string Code { get; }

        public override string ToString()
        {
            return $"{Name} ({Province.Abbreviation})";
        }
    }
}