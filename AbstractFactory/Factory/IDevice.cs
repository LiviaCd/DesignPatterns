using AbstractFactory.Core.Laptop;
using AbstractFactory.Core.Mobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public interface IDevice
    {
        public Laptop CreateLaptop();
        public Mobile CreateMobile();
    }
}
