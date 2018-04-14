using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_StrategyPattern
{
    public class Context 
    {
        private IStrategy strategy;

        public Context(IStrategy strategy) 
        {
            this.strategy = strategy;
        }

        public Boolean executeStrategy(string valueToValidate)
        {
            return strategy.doValidation(valueToValidate);
        }


    }
}
