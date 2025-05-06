using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CalculatorService
    {
        private ICalculateStrategy _strategy;
        public CalculatorService(ICalculateStrategy strategy)
        {
            _strategy = strategy;
        }
        public int ExecuteCalculation(int value1, int value2)
        { 
            return _strategy.Calculate(value1, value2);
        }

        public void SetStrategy(ICalculateStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
