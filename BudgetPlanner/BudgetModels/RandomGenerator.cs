using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels
{
    public static class RandomGenerator
    {
        private static Random RNG { get; } = new Random();
        public static decimal GeterateDecimal( int min, int max, int maxDec, decimal multiplyer )
        {
            decimal output = 0;

            output += RNG.Next(min, max);
            output += RNG.Next(0, maxDec) * multiplyer;

            return output;
        }
    }
}
