using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Vistors;

namespace Visitor.Core
{
    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public int WorkMonths { get; set; }
        public decimal MonthlySalary { get; set; }

        public FullTimeEmployee(string name, int workMonths, decimal monthlySalary)
        {
            Name = name;
            WorkMonths = workMonths;
            MonthlySalary = monthlySalary;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
