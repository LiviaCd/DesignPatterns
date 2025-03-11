using AbstractFactory.Core.Laptop;
using AbstractFactory.Core.Mobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class SonyCreateFactory : IDevice
    {
        public Laptop CreateLaptop()
        {
            return new SonyLaptop();
        }

        public Mobile CreateMobile()
        {
            return new SonyMobile();
        }
    }
}
