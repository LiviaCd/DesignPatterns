﻿
namespace Facade.Subsystems
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine($"Check loans for {customer.Name}");
            return true;
        }
    }
}
