
namespace Facade.Subsystems
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, decimal amount)
        {
            Console.WriteLine($"Check bank for {customer.Name}");
            return true;
        }
    }
}
