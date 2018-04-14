using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_5_StrategyPattern
{
    public class AlphanumericValidation : IStrategy
    {
        public Boolean doValidation(string valueToValidate)
        {
            if(valueToValidate.Trim() == null || (valueToValidate.Trim() == ""))
            {
                return false;
            }

            else

            {
                Regex regex = new Regex("^[a-zA-Z0-9]*$");

                return regex.IsMatch(valueToValidate);


            }

        }

    }
}
