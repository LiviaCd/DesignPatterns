using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Laptop
{
    public class SonyLaptop : Laptop
    {
        public override void DownloadApplication()
        {
            Console.WriteLine("Application is downloaded on Sony laptop");
        }
    }
}
