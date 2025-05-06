using Facade.Facade;
using Facade;
using Facade.Subsystems;

class Program
{
    static void Main(string[] args)
    {
        Mortgage mortgage = new Mortgage(new Bank (), new Credit (), new Loan ());

        Customer customer = new Customer("Ana");

        bool eligible = mortgage.IsEligible(customer, 125000);

        Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

        Console.ReadKey();
    }
}
