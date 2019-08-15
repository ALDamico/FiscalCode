using FiscalCodeLib.Data.DataAccess;
using FiscalCodeLib.Generator;
using FiscalCodeLib.Models;

namespace FiscalCodeLib.Validator
{
    public class FiscalCodeValidator
    {
        public FiscalCodeValidator(string fiscalCodeToValidate, PersonalInfo person)
        {
            _fiscalCodeToValidate = new FiscalCode(fiscalCodeToValidate);
            _person = person;
            _generator = new FiscalCodeGenerator(_person);
        }

        private FiscalCode _fiscalCodeToValidate;
        private PersonalInfo _person;
        private FiscalCodeGenerator _generator;
    }
}