using Prakt12.Data.Repositorys.GroupInterestRepository;
using Prakt12.Data.Repositorys.UserRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Prakt12.Validation
{
    public class GroupValidation : ValidationRule
    {
        private readonly IGroupInterest_Repository service  = new GroupInterest_Repository();

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            var input = (value ?? "").ToString().Trim();

            if (input == string.Empty)
            {
                return new ValidationResult(false, "Поле является обязательным");
            }

            if (service.GroupIsExist(input))
            {
                return new ValidationResult(false, "Такая группа уже существует");
            }

            return ValidationResult.ValidResult;


        }
    }
}
