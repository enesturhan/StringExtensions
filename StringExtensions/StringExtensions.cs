using StringExtensions.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Yazdıgımız her validasyonu burada interface yapısı sayesinde tutmus oluyoruz böylece bu validasyonlaarı tek tek yazmak yerine dizi halinde kontrol etmis oluyoruz.
        /// </summary>
        /// <param name="pass"></param>
        /// <param name="valid"></param>
        /// <returns></returns>
        public static bool IsValidPassword(this string pass, params IValidation[] valid)
        {

            foreach (var item in valid)
            {
                if (item.Validation(pass))
                {
                    return true;
                }

            }
            return false;
        }

    }
}