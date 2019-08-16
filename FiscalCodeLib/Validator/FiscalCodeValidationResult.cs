using System.Globalization;

namespace FiscalCodeLib.Validator
{
    public class FiscalCodeValidationResult
    {
        public bool? Result { get; set; }
        public string Message { get; set; }

        public CultureInfo TargetCulture { get; set; }

        public FiscalCodeValidationResult(bool? result, string message, string cultureName)
        {
            Result = result;
            Message = message;
            TargetCulture = new CultureInfo(cultureName);
        }

        public FiscalCodeValidationResult()
        {
            Result = null;
            Message = "";
            TargetCulture = CultureInfo.InvariantCulture;
        }

        public override string ToString()
        {
            return Message;
        }
    }
}