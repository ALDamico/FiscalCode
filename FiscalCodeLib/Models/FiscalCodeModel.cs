using System;
using System.Collections.Generic;
using System.Text;
using FiscalCodeLib.Enums;
using FiscalCodeLib.Utils;

namespace FiscalCodeLib.Models
{
    public class FiscalCodeModel
    {
        internal FiscalCodeModel(string surnameTriplet, string nameTriplet, string yearOfBirthRepresentation,
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

        public string NameTriplet { get; private set; }
        public string SurnameTriplet { get; private set; }
        public string YearOfBirthRepresentation { get; private set; }
        public string DayGenderRepresentation { get; private set; }
        public string MonthRepresentation { get; private set; }
        public string Code { get; private set; }
        public char CheckDigit { get; private set; }


        public string FiscalCode
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(SurnameTriplet).Append(NameTriplet).Append(YearOfBirthRepresentation)
                    .Append(MonthRepresentation).Append(DayGenderRepresentation).Append(Code).Append(CheckDigit);
                return builder.ToString();
            }
        }
    }
}