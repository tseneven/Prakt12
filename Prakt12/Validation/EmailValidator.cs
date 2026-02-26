using Prakt12.Data.Repositorys;
using System.Globalization;
using System.Windows.Controls;

namespace Prakt12.Validation
{
    public class EmailValidator : ValidationRule
    {
        public IUser_Repository service { get; set; } = new User_Repository();

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var input = (value ?? "").ToString().Trim();

            if (string.IsNullOrWhiteSpace(input))
                return new ValidationResult(false, "Поле является обязательным");

            try
            {
                var addr = new System.Net.Mail.MailAddress(input);
                if (addr.Address != input)
                    return new ValidationResult(false, "Email некорректный");
            }
            catch
            {
                return new ValidationResult(false, "Email некорректный");
            }

            if (service.EmailIsExist(input))
            {
                return new ValidationResult(false, "Такая почта уже существует");
            }

            return ValidationResult.ValidResult;
        }
    }
}
