using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class RemainderNumbers : ICalculateStrategy
    {
        public int Calculate(int firstValue, int secondValue)
        {
            return firstValue % secondValue;
        }
    }
}
