using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorBase : CalcProperties, CalcCore
    {
        public long add(long a)
        {
            this.Result += a;
            return this.Result;
        }

        public long subtract(long a)
        {
            this.Result -= a;
            return this.Result;
        }
    }
}
