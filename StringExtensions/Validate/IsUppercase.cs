using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.Validate
{
    public class IsUppercase :IValidation
    {
        public bool Validation(string str)
        {
            var isUpper = str.Any(x => char.IsUpper(x));
            if (isUpper)

                return isUpper;

            else
                throw new Exception("Is Not upper");



                }
    }
}
