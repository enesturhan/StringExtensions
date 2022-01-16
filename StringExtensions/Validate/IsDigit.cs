using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.Validate
{
    public class IsDigit:IValidation
    {

        public bool Validation(string str)
        {
            var isValid = str.Any(x => char.IsDigit(x));

            if (isValid)
            {
                return isValid;
            }
            throw new Exception("Not digit");

        }
    }
}
