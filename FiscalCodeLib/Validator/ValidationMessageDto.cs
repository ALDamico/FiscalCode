namespace FiscalCodeLib.Validator
{
    public class ValidationMessageDto
    {
        public ValidationMessageDto(int id, int? result, string messageName, string message)
        {
            Id = id;
            MessageName = messageName;
            Message = message;
            LanguageCode = null;
            Result = result;
        }

        public ValidationMessageDto(int id, int? result, string messageName, string message, string languageCode)
        {
            Id = id;
            MessageName = messageName;
            Message = message;
            LanguageCode = languageCode;
            Result = result;
        }

        public int Id { get; set; }
        public string MessageName { get; set; }
        public string Message { get; set; }
        public int? Result { get; set; }
        public string LanguageCode { get; set; }

        public static implicit operator FiscalCodeValidationResult(ValidationMessageDto dto)
        {
            bool? result;
            switch (dto.Result)
            {
                case 0:
                    result = false;
                    break;
                case 1:
                    result = true;
                    break;
                default:
                    result = null;
                    break;
            }

            return new FiscalCodeValidationResult(result, dto.Message, dto.LanguageCode);
        }

        public override string ToString()
        {
            return Message;
        }
    }
}