using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Vistors;

namespace Visitor.Core
{
    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; }
        public int WorkHours { get; set; }
        public decimal HourlyRate { get; set; }

        public ContractEmployee(string name, int workHours, decimal hourlyRate)
        {
            Name = name;
            WorkHours = workHours;
            HourlyRate = hourlyRate;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
