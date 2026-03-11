using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Prakt12.Validation
{
    public class PasswordValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var input = (value ?? "").ToString().Trim();
            if (input == string.Empty)
            {
                return new ValidationResult(false, "Поле является обязательным");
            }

            var pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            bool result = Regex.IsMatch(input, pattern);

            if(result == false)
            {
                return new ValidationResult(false, "Пароль должен содержать сивмолы, буквы, цифры и быть не менее 8 символов");
            }

            return ValidationResult.ValidResult;
        }

    }
}
