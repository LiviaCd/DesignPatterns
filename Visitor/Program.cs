using Visitor.Core;
using Visitor.Vistors;

class Program
{
    static void Main()
    {
        IEmployee employee1 = new FullTimeEmployee("John Doe", 12, 4000);
        IEmployee employee2 = new ContractEmployee("Jane Smith", 160, 30);

        PayrollVisitor payrollVisitor = new PayrollVisitor();

        employee1.Accept(payrollVisitor);
        employee2.Accept(payrollVisitor);
    }
}