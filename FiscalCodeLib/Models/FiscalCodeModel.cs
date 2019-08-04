using System;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Utils;

namespace FiscalCodeLib.Models
{
    public class FiscalCodeModel
    {
        public FiscalCodeModel(PersonalInfoModel person)
        {
            if (person == null) throw new ArgumentException("The PersonalInfoModel object can't be null");

            Person = person;
            CalculateSurnameTriplet();
            CalculateNameTriplet();
            CalculateYearRepresentation();
            CalculateDayRepresentation();
            MapMonthToRepresentation();
            SetPlaceCode();
        }

        public PersonalInfoModel Person { get; }
        public string NameTriplet { get; private set; }
        public string SurnameTriplet { get; private set; }
        public string YearOfBirthRepresentation { get; private set; }
        public string DayGenderRepresentation { get; private set; }
        public string MonthRepresentation { get; private set; }
        public string Code { get; private set; }
        public string CheckDigit { get; private set; }

        private void CalculateSurnameTriplet()
        {
            var surname = Person.Surname;
            var splitter = new VowelsConsonantsSplitter(surname);
            if (splitter.Consonants.Count >= 3)
            {
                SurnameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() + splitter.Consonants[2];
            }
            else if (splitter.Consonants.Count == 2)
            {
                SurnameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() + splitter.Vowels[0];
            }
            else if (splitter.Consonants.Count == 1)
            {
                if (splitter.Vowels.Count >= 2)
                    SurnameTriplet = splitter.Consonants[0] + splitter.Vowels[0].ToString() + splitter.Vowels[1];
                else
                    SurnameTriplet = splitter.Consonants[0] + splitter.Vowels[0].ToString() + "X";
            }
            else
            {
                SurnameTriplet = splitter.Vowels[0] + splitter.Vowels[1].ToString() + "X";
            }
        }

        private void CalculateNameTriplet()
        {
            var name = Person.Name;
            var splitter = new VowelsConsonantsSplitter(name);
            if (splitter.Consonants.Count >= 4)
            {
                NameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() +
                              splitter.Consonants[3];
            }
            else if (splitter.Consonants.Count == 3)
            {
                NameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() + splitter.Consonants[2];
            }
            else if (splitter.Consonants.Count == 2)
            {
                NameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() + splitter.Vowels[0];
            }
            else if (splitter.Consonants.Count == 1)
            {
                if (splitter.Vowels.Count >= 2)
                    NameTriplet = splitter.Consonants[0] + splitter.Vowels[0].ToString() + splitter.Vowels[1];
                else
                    NameTriplet = splitter.Consonants[0] + splitter.Vowels[0].ToString() + "X";
            }
            else
            {
                NameTriplet = splitter.Vowels[0] + splitter.Vowels[1].ToString() + "X";
            }
        }

        private void CalculateYearRepresentation()
        {
            var year = Person.DateOfBirth.Year.ToString();
            YearOfBirthRepresentation = year.Substring(2, 2);
        }

        private void CalculateDayRepresentation()
        {
            var gender = 0;
            if (Person.Gender == Gender.Female) gender += 40;

            DayGenderRepresentation = (Person.DateOfBirth.Day + gender).ToString();
        }

        private void MapMonthToRepresentation()
        {
            var month = Person.DateOfBirth.Month;
            MonthRepresentation = UtilityMethods.MonthMap[month];
            if (string.IsNullOrWhiteSpace(MonthRepresentation)) throw new ArgumentException();
        }

        private void SetPlaceCode()
        {
            Code = Person.PlaceOfBirth.Code;
        }

        private void CalculateCheckDigit()
        {
        }
    }
}