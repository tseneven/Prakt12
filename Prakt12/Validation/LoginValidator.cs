using Prakt12.Data;
using Prakt12.Data.Repositorys;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Prakt12.Validation
{
    public class LoginValidator : ValidationRule
    {
        public IUser_Repository service { get; set; } = new User_Repository();

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var input = (value ?? "").ToString().Trim();
            if (input == string.Empty)
            {
                return new ValidationResult(false, "Поле является обязательным");
            }

            if(input.Length < 5)
            {
                return new ValidationResult(false, "Логин не должен быть менее 5 символов");
            }

            if (service.LoginIsExist(input))
            {
                return new ValidationResult(false, "Такой логин уже существует");
            }

            return ValidationResult.ValidResult;
        }

    }
}
