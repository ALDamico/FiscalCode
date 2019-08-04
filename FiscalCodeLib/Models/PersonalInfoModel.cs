using System;
using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Factories;
using FiscalCodeLib.Interfaces;
using UnidecodeSharpCore;

namespace FiscalCodeLib.Models
{
    public class PersonalInfoModel
    {
        private string _name;
        private string _surname;

        public PersonalInfoModel(string name, string surname, Gender gender, DateTime dateOfBirth, string placeOfBirth)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            using (var db = new DataAccessProvider())
            {
                PlaceOfBirth = ModelFactory.GetByPlaceName(placeOfBirth);
            }
        }

        public string Name
        {
            get => _name;
            private set => _name = ValidateName(value);
        }

        public string Surname
        {
            get => _surname;
            private set => _surname = ValidateName(value);
        }

        public Gender Gender { get; }

        public DateTime DateOfBirth { get; }

        public IPlace PlaceOfBirth { get; set; }

        private string ValidateName(string name)
        {
            var transliterated = name.Unidecode();
            var replace = transliterated.Replace(" ", "")
                .Replace("-", "")
                .Replace(".", "")
                .Replace("'", "").ToUpper();
            return replace;
        }
    }
}