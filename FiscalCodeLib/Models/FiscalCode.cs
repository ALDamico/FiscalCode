using System;
using System.Collections.Generic;
using System.Text;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Utils;

namespace FiscalCodeLib.Models
{
    public class FiscalCode
    {
        private FiscalCode()
        {
            NameTriplet = "";
            SurnameTriplet = "";
            YearOfBirthRepresentation = "";
            MonthRepresentation = "";
            DayGenderRepresentation = "";
            Code = "";
            CheckDigit = new char();
        }

        public FiscalCode(string surnameTriplet, string nameTriplet, string yearOfBirthRepresentation,
            string monthRepresentation, string dayGenderRepresentation, string code, char checkDigit)
        {
            NameTriplet = nameTriplet;
            SurnameTriplet = surnameTriplet;
            YearOfBirthRepresentation = yearOfBirthRepresentation;
            DayGenderRepresentation = dayGenderRepresentation;
            MonthRepresentation = monthRepresentation;
            Code = code;
            CheckDigit = checkDigit;
        }

        public FiscalCode(string fullFiscalCode) : this()
        {
            if (string.IsNullOrEmpty(fullFiscalCode))
            {
                throw new ArgumentNullException("The fullFiscalCode parameter must not be null!");
            }

            try
            {
                SurnameTriplet = fullFiscalCode.Substring(0, 3).ToUpper();
                NameTriplet = fullFiscalCode.Substring(3, 3).ToUpper();
                YearOfBirthRepresentation = fullFiscalCode.Substring(6, 2).ToUpper();
                MonthRepresentation = fullFiscalCode.Substring(8, 1).ToUpper();
                DayGenderRepresentation = fullFiscalCode.Substring(9, 2).ToUpper();
                Code = fullFiscalCode.Substring(11, 4).ToUpper();
                CheckDigit = char.ToUpper(fullFiscalCode[15]);
            }
            catch (ArgumentOutOfRangeException)
            {
                //In theory we shouldn't be doing anything here
            }
        }

        public string NameTriplet { get; private set; }
        public string SurnameTriplet { get; private set; }
        public string YearOfBirthRepresentation { get; private set; }
        public string DayGenderRepresentation { get; private set; }
        public string MonthRepresentation { get; private set; }
        public string Code { get; private set; }
        public char CheckDigit { get; private set; }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(SurnameTriplet).Append(NameTriplet).Append(YearOfBirthRepresentation)
                .Append(MonthRepresentation).Append(DayGenderRepresentation).Append(Code).Append(CheckDigit);
            return builder.ToString().Trim('\0');
        }

        public char CalculateCheckDigit()
        {
            string partialCode = GetPartialCode();
            var checkDigit =
                CommonDataStructures.GetCheckDigit(CommonDataStructures.GetAccumulationResult(partialCode));
            return checkDigit;
        }

        private string GetPartialCode()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(SurnameTriplet).Append(NameTriplet).Append(YearOfBirthRepresentation)
                .Append(MonthRepresentation).Append(DayGenderRepresentation).Append(Code);
            return builder.ToString();
        }

        public int Length => ToString().Length;
    }
}