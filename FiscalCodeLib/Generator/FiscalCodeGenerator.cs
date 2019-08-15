using System;
using System.Collections.Generic;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Models;
using FiscalCodeLib.Utils;

namespace FiscalCodeLib.Generator
{
    public class FiscalCodeGenerator
    {
        public FiscalCodeGenerator(PersonalInfo person)
        {
            _person = person;
            if (_person == null) throw new ArgumentException("The parameter person can't be null!");
            FiscalCodes = new List<FiscalCode>();
            CalculateFiscalCodes();
        }

        public List<FiscalCode> FiscalCodes { get; private set; }

        private readonly PersonalInfo _person;

        private string CalculateNameTriplet()
        {
            var name = _person.Name;
            var splitter = new VowelsConsonantsSplitter(name);
            string nameTriplet = "";
            if (splitter.Consonants.Count >= 4)
            {
                nameTriplet = splitter.Consonants[0] + splitter.Consonants[2].ToString() +
                              splitter.Consonants[3];
            }
            else if (splitter.Consonants.Count == 3)
            {
                nameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() + splitter.Consonants[2];
            }
            else if (splitter.Consonants.Count == 2)
            {
                nameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() + splitter.Vowels[0];
            }
            else if (splitter.Consonants.Count == 1)
            {
                if (splitter.Vowels.Count >= 2)
                    nameTriplet = splitter.Consonants[0] + splitter.Vowels[0].ToString() + splitter.Vowels[1];
                else
                    nameTriplet = splitter.Consonants[0] + splitter.Vowels[0].ToString() + "X";
            }
            else
            {
                nameTriplet = splitter.Vowels[0] + splitter.Vowels[1].ToString() + "X";
            }

            return nameTriplet;
        }

        private string CalculateDayRepresentation()
        {
            var gender = 0;
            string dayGenderRepresentation = "";
            if (_person.Gender == Gender.Female) gender += 40;

            dayGenderRepresentation = _person.DateOfBirth.Day + gender >= 10
                ? (_person.DateOfBirth.Day + gender).ToString()
                : "0" + _person.DateOfBirth.Day.ToString();
            return dayGenderRepresentation;
        }

        private string CalculateSurnameTriplet()
        {
            var surname = _person.Surname;
            var splitter = new VowelsConsonantsSplitter(surname);
            string surnameTriplet = "";
            if (splitter.Consonants.Count >= 3)
            {
                surnameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() + splitter.Consonants[2];
            }
            else if (splitter.Consonants.Count == 2)
            {
                surnameTriplet = splitter.Consonants[0] + splitter.Consonants[1].ToString() + splitter.Vowels[0];
            }
            else if (splitter.Consonants.Count == 1)
            {
                if (splitter.Vowels.Count >= 2)
                    surnameTriplet = splitter.Consonants[0] + splitter.Vowels[0].ToString() + splitter.Vowels[1];
                else
                    surnameTriplet = splitter.Consonants[0] + splitter.Vowels[0].ToString() + "X";
            }
            else
            {
                surnameTriplet = splitter.Vowels[0] + splitter.Vowels[1].ToString() + "X";
            }

            return surnameTriplet;
        }

        private string CalculateYearRepresentation()
        {
            return _person.DateOfBirth.Year.ToString().Substring(2, 2);
        }

        private string MapMonthToRepresentation()
        {
            var month = _person.DateOfBirth.Month;
            var monthRepresentation = CommonDataStructures.MonthMap[month];
            if (string.IsNullOrWhiteSpace(monthRepresentation)) throw new ArgumentException();
            return monthRepresentation;
        }

        private string GetPlaceCode()
        {
            return _person.PlaceOfBirth.Code;
        }

        private char CalculateCheckDigit(string partialFiscalCode)
        {
            var temporaryFiscalCode = partialFiscalCode;
            if (temporaryFiscalCode.Length != 15)
            {
                throw new ArgumentException("An error occurred. Invalid length in temporary fiscal code");
            }

            var accumulator = 0;
            for (var i = 0; i < temporaryFiscalCode.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    accumulator += CommonDataStructures.EvenPositionMap[temporaryFiscalCode[i]];
                }
                else
                {
                    accumulator += CommonDataStructures.OddPositionMap[temporaryFiscalCode[i]];
                }
            }

            return CommonDataStructures.GetCheckDigit(accumulator);
        }

        private void CalculateFiscalCodes()
        {
            string initialFiscalCode = CalculateSurnameTriplet() + CalculateNameTriplet() +
                                       CalculateYearRepresentation() + MapMonthToRepresentation() +
                                       CalculateDayRepresentation() + GetPlaceCode();
            char initialCheckDigit = CalculateCheckDigit(initialFiscalCode);
            FiscalCode firstFiscalCode = new FiscalCode(CalculateSurnameTriplet(),
                CalculateNameTriplet(), CalculateYearRepresentation(), MapMonthToRepresentation(),
                CalculateDayRepresentation(), GetPlaceCode(), initialCheckDigit);
            FiscalCodes.Add(firstFiscalCode);
            foreach (var letter in initialFiscalCode)
            {
                if (char.IsDigit(letter))
                {
                    initialFiscalCode = initialFiscalCode.Replace(letter,
                        Utils.CommonDataStructures.OmocodeSubstitutions[letter], 1);
                    char cd = CalculateCheckDigit(initialFiscalCode);
                    var surnameTriplet = initialFiscalCode.Substring(0, 3);
                    var nameTriplet = initialFiscalCode.Substring(3, 3);
                    var yearRepr = initialFiscalCode.Substring(6, 2);
                    var monthRepr = initialFiscalCode.Substring(8, 1);
                    var dayRepr = initialFiscalCode.Substring(9, 2);
                    var code = initialFiscalCode.Substring(11, 4);
                    var newModel = new FiscalCode(surnameTriplet, nameTriplet, yearRepr,
                        monthRepr, dayRepr, code, cd);
                    FiscalCodes.Add(newModel);
                }
            }
        }
    }
}