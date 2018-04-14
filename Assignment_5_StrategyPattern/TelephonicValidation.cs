using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_5_StrategyPattern
{
    public class TelephonicValidation : IStrategy
    {
        public Boolean doValidation(string valueToValidate)
        {
            if (valueToValidate.Trim() == null || (valueToValidate.Trim() == ""))
            {
                return false;
            }

            else

            {

                Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

                return regex.IsMatch(valueToValidate);

            }
        }
    }

       
}
