using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_StrategyPattern
{
    public class NumericValidation : IStrategy
    {

        public Boolean doValidation(string valueToValidate)
        {
                int value;

                return int.TryParse(valueToValidate, out value);
            
        }
    } 
}

