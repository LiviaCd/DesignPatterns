using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facade
{
    public class Mortgage
    {
        private readonly Bank _bank;
        private readonly Credit _credit; 
        private readonly Loan _loan;

        public Mortgage(Bank bank, Credit credit, Loan loan)
        {
            _bank = bank;
            _credit = credit;
            _loan = loan;            
        }

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1} loan\n",
                customer.Name, amount);
            bool eligible = true;
 
            if (!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}
