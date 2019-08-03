using System;
using FiscalCodeLib.Enums;
using UnidecodeSharpCore;

namespace FiscalCodeLib.Models
{
    public class PersonalInfoModel
    {
        public string Name
        {
            get => _name;
            set => _name = ValidateName(value);
        }

        public string Surname
        {
            get => _surname;
            set => _surname = ValidateName(value);
        }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        //TODO Add IPlace interface and ItalianMunicipality and ForeignCountry classes
        public string PlaceOfBirth { get; set; }

        private string _name;
        private string _surname;

        private string ValidateName(string name)
        {
            string transliterated = name.Unidecode();
            var replace = transliterated.Replace(" ", "")
                .Replace("-", "")
                .Replace(".", "")
                .Replace("'", "");
            return replace;
        }
    }
}