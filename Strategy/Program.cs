using Strategy;
using Strategy.Strategies;

class Program
{
    static void Main(string[] args)
    {
        ICalculateStrategy strategy = new AddingNumbers();
        CalculatorService calculatorService = new CalculatorService(strategy);

        Console.WriteLine($"Result is {calculatorService.ExecuteCalculation(2, 3)}");

        calculatorService.SetStrategy(new DecreaseNumbers());
        Console.WriteLine($"Result is {calculatorService.ExecuteCalculation(2, 3)}");

        calculatorService.SetStrategy(new MultiplicationNumbers());
        Console.WriteLine($"Result is {calculatorService.ExecuteCalculation(2, 3)}");

        calculatorService.SetStrategy(new QuotientNumbers());
        Console.WriteLine($"Result is {calculatorService.ExecuteCalculation(7, 3)}");

        calculatorService.SetStrategy(new RemainderNumbers());
        Console.WriteLine($"Result is {calculatorService.ExecuteCalculation(7, 3)}");

    }
}