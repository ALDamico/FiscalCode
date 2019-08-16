using FiscalCodeLib.Validator;

namespace FiscalCodeLib.Data.Localization
{
    public interface ILocalizationProvider
    {
        FiscalCodeValidationResult GetFormattedLocalizedMessage(string messageName, object[] parameters);
        FiscalCodeValidationResult GetLocalizedMessage(string messageName);
    }
}