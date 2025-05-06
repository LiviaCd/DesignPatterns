using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Vistors;

namespace Visitor.Core
{
    public interface IEmployee
    {
        void Accept(IVisitor visitor);
    }
}
