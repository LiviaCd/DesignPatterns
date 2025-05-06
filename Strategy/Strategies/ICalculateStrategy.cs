using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public interface ICalculateStrategy
    {
        int Calculate(int firstValue, int secondValue);
    }
}
