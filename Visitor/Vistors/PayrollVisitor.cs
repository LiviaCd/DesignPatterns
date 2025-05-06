using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Core;

namespace Visitor.Vistors
{
    public class PayrollVisitor : IVisitor
    {
        public void Visit(FullTimeEmployee employee)
        {
            Console.WriteLine($"Calculating payroll for full-time employee: {employee.Name}");

            Console.WriteLine($"Total Salary: {employee.MonthlySalary * employee.WorkMonths}");
        }

        public void Visit(ContractEmployee employee)
        {
            Console.WriteLine($"Calculating payroll for contract employee: {employee.Name}");

            Console.WriteLine($"Total Payment: {employee.HourlyRate * employee.WorkHours}");
        }
    }
}
