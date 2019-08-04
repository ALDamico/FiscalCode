using System;
using System.Collections.Generic;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Utils;

namespace FiscalCodeLib.Models
{
    public class FiscalCodeModel
    {
        public FiscalCodeModel(PersonalInfoModel person)
        {
            Person = person ?? throw new ArgumentException("The PersonalInfoModel object can't be null");
            
            Omocodes = new List<string>();
            
            CalculateSurnameTriplet();
            CalculateNameTriplet();
            CalculateYearRepresentation();
            CalculateDayRepresentation();
            MapMonthToRepresentation();
            SetPlaceCode();
            CalculateCheckDigit();
        }

        public PersonalInfoModel Person { get; }
        public string NameTriplet { get; private set; }
        public string SurnameTriplet { get; private set; }
        public string YearOfBirthRepresentation { get; private set; }
        public string DayGenderRepresentation { get; private set; }
        public string MonthRepresentation { get; private set; }
        public string Code { get; private set; }
        public char CheckDigit { get; private set; }

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
                NameTriplet = splitter.Consonants[0] + splitter.Consonants[2].ToString() +
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

            DayGenderRepresentation = Person.DateOfBirth.Day + gender >= 10?(Person.DateOfBirth.Day + gender).ToString(): "0" + Person.DateOfBirth.Day;
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
            var temporaryFiscalCode = SurnameTriplet + NameTriplet + YearOfBirthRepresentation + MonthRepresentation +
                                      DayGenderRepresentation + Code;
            if (temporaryFiscalCode.Length != 15)
            {
                throw new ArgumentException("An error occurred. Invalid length in temporary fiscal code");
            }

            int accumulator = 0;
            for (int i = 0; i < temporaryFiscalCode.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    accumulator += UtilityMethods.EvenPositionMap[temporaryFiscalCode[i]];
                }
                else
                {
                    accumulator += UtilityMethods.OddPositionMap[temporaryFiscalCode[i]];
                }

                
            }
            CheckDigit = UtilityMethods.GetCheckDigit(accumulator);
        }

        public string GetFiscalCode()
        {
            return SurnameTriplet + NameTriplet + YearOfBirthRepresentation + MonthRepresentation +
                   DayGenderRepresentation + Code + CheckDigit;
        }
        
        public List<string> Omocodes { get; private set; }
    }
}