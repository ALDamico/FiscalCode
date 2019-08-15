using System;
using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Factories;
using FiscalCodeLib.Interfaces;
using UnidecodeSharpCore;

namespace FiscalCodeLib.Models
{
    public class PersonalInfo
    {
        private string _name;
        private string _surname;

        public PersonalInfo(string name, string surname, Gender gender, DateTime dateOfBirth, string placeOfBirth)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            using (var dap = new SqliteDataAccessProvider())
            {
                PlaceOfBirth = dap.GetMunicipalityByNameAsync(placeOfBirth).Result;
            }
        }

        public PersonalInfo(string name, string surname, Gender gender, DateTime dateOfBirth, IPlace placeOfBirth)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
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