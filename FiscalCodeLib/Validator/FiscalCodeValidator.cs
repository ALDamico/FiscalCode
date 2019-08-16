using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FiscalCodeLib.Data.Localization;
using FiscalCodeLib.Generator;
using FiscalCodeLib.Models;
using FiscalCodeLib.Utils;
using Microsoft.EntityFrameworkCore.Internal;

namespace FiscalCodeLib.Validator
{
    public class FiscalCodeValidator
    {
        public FiscalCodeValidator(string fiscalCodeToValidate, PersonalInfo person, CultureInfo targetCulture)
        {
            _fiscalCodeToValidate = new FiscalCode(fiscalCodeToValidate);
            _person = person;
            _generator = new FiscalCodeGenerator(_person);
            ValidationResults = new List<FiscalCodeValidationResult>();
            _localizationProvider = new SqliteLocalizationProvider(targetCulture);
            Validate();
        }

        public FiscalCodeValidator(FiscalCode fiscalCode, PersonalInfo person, CultureInfo targetCulture)
        {
            _fiscalCodeToValidate = fiscalCode;
            _person = person;
            _localizationProvider = new SqliteLocalizationProvider(targetCulture);
        }

        public List<FiscalCodeValidationResult> Validate()
        {
            CheckLength();
            CheckSurnameTriplet();
            CheckNameTriplet();
            CheckYearRepresentation();
            CheckMonthRepresentation();
            CheckDayGender();
            CheckPlaceOfBirth();
            CheckCheckDigit();

            return ValidationResults;
        }

        private void CheckCheckDigit()
        {
            FiscalCodeValidationResult result = null;

            char expectedCheckDigit = _fiscalCodeToValidate.CalculateCheckDigit();
            if (expectedCheckDigit == _fiscalCodeToValidate.CheckDigit)
            {
                result = _localizationProvider.GetLocalizedMessage("msg_checkdigit_ok");
            }
            else
            {
                result = _localizationProvider.GetFormattedLocalizedMessage("msg_checkdigit_wrong",
                    new[] {(object) expectedCheckDigit, _fiscalCodeToValidate.CheckDigit});
            }

            ValidationResults.Add(result);
        }

        private void CheckPlaceOfBirth()
        {
            FiscalCodeValidationResult result = null;
            if (_generator.MainFiscalCode.Code == _fiscalCodeToValidate.Code)
            {
                result = _localizationProvider.GetLocalizedMessage("msg_place_code_main_ok");
            }
            else if (_generator.FiscalCodes.Any(fc => fc.Code == _fiscalCodeToValidate.Code))
            {
                result = _localizationProvider.GetLocalizedMessage("msg_place_code_omocode_ok");
            }
            else
            {
                result = _localizationProvider.GetFormattedLocalizedMessage("msg_place_code_wrong",
                    new[] {_generator.MainFiscalCode.Code, _fiscalCodeToValidate.Code});
            }

            ValidationResults.Add(result);
        }

        private void CheckDayGender()
        {
            FiscalCodeValidationResult result = null;
            if (_generator.MainFiscalCode.DayGenderRepresentation == _fiscalCodeToValidate.DayGenderRepresentation)
            {
                result = _localizationProvider.GetLocalizedMessage("msg_day_gender_main_ok");
            }
            else if (_generator.FiscalCodes.Any(fc =>
                fc.DayGenderRepresentation == _fiscalCodeToValidate.DayGenderRepresentation))
            {
                result = _localizationProvider.GetLocalizedMessage("msg_day_gender_omocode_ok");
            }
            else
            {
                result = _localizationProvider.GetFormattedLocalizedMessage("msg_day_gender_wrong",
                    new[]
                    {
                        _generator.MainFiscalCode.DayGenderRepresentation,
                        _fiscalCodeToValidate.DayGenderRepresentation
                    });
            }

            ValidationResults.Add(result);
        }

        private void CheckLength()
        {
            if (_fiscalCodeToValidate.Length == 11)
            {
                if (_fiscalCodeToValidate.ToString().All(char.IsDigit))
                {
                    ValidationResults.Add(_localizationProvider.GetLocalizedMessage("msg_length_temporary"));
                }
                else
                {
                    ValidationResults.Add(_localizationProvider.GetFormattedLocalizedMessage("msg_length_wrong",
                        new[] {(object) _fiscalCodeToValidate.Length}));
                }
            }
            else if (_fiscalCodeToValidate.Length != 16)
            {
                ValidationResults.Add(_localizationProvider.GetFormattedLocalizedMessage("msg_length_wrong",
                    new[] {(object) _fiscalCodeToValidate.Length}));
            }
            else
            {
                ValidationResults.Add(_localizationProvider.GetLocalizedMessage("msg_length_ok"));
            }
        }

        private void CheckSurnameTriplet()
        {
            if (_fiscalCodeToValidate.SurnameTriplet == _generator.FiscalCodes[0].SurnameTriplet)
            {
                ValidationResults.Add(_localizationProvider.GetLocalizedMessage("msg_surname_triplet_ok"));
            }
            else
            {
                ValidationResults.Add(_localizationProvider.GetFormattedLocalizedMessage("msg_surname_triplet_wrong",
                    new[] {_generator.FiscalCodes[0].SurnameTriplet, _fiscalCodeToValidate.SurnameTriplet}));
            }
        }

        private void CheckNameTriplet()
        {
            FiscalCodeValidationResult result = null;
            if (_fiscalCodeToValidate.NameTriplet == _generator.FiscalCodes[0].NameTriplet)
            {
                result = _localizationProvider.GetLocalizedMessage("msg_name_triplet_ok");
            }
            else
            {
                result = _localizationProvider.GetFormattedLocalizedMessage("msg_name_triplet_wrong",
                    new[] {_generator.FiscalCodes[0].NameTriplet, _fiscalCodeToValidate.NameTriplet});
            }

            ValidationResults.Add(result);
        }

        private void CheckYearRepresentation()
        {
            FiscalCodeValidationResult result = null;
            if (_fiscalCodeToValidate.YearOfBirthRepresentation == _generator.MainFiscalCode.YearOfBirthRepresentation)
            {
                result = _localizationProvider.GetLocalizedMessage("msg_year_main_ok");
            }
            else if (_generator.FiscalCodes.Any(fc =>
                fc.YearOfBirthRepresentation == _fiscalCodeToValidate.YearOfBirthRepresentation))
            {
                result = _localizationProvider.GetLocalizedMessage("msg_year_omocode_ok");
            }
            else
            {
                result = _localizationProvider.GetFormattedLocalizedMessage("msg_year_wrong",
                    new[]
                    {
                        _generator.MainFiscalCode.YearOfBirthRepresentation,
                        _fiscalCodeToValidate.YearOfBirthRepresentation
                    });
            }

            ValidationResults.Add(result);
        }

        private void CheckMonthRepresentation()
        {
            FiscalCodeValidationResult result = null;
            if (_fiscalCodeToValidate.MonthRepresentation == _generator.MainFiscalCode.MonthRepresentation)
            {
                result = _localizationProvider.GetLocalizedMessage("msg_month_ok");
            }
            else
            {
                result = _localizationProvider.GetFormattedLocalizedMessage("msg_month_wrong",
                    new[] {_generator.MainFiscalCode.MonthRepresentation, _fiscalCodeToValidate.MonthRepresentation});
            }

            ValidationResults.Add(result);
        }

        public List<FiscalCodeValidationResult> ValidationResults { get; }
        private readonly FiscalCode _fiscalCodeToValidate;
        private PersonalInfo _person;
        private readonly FiscalCodeGenerator _generator;
        private readonly SqliteLocalizationProvider _localizationProvider;
        public bool IsValid => ValidationResults.All(result => result.Result == true);
    }
}