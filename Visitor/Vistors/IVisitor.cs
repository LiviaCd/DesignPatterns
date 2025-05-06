using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Core;

namespace Visitor.Vistors
{
    public interface IVisitor
    {
        void Visit(FullTimeEmployee employee);
        void Visit(ContractEmployee employee);
    }
}
