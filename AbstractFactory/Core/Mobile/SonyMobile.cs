using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Mobile
{
    public class SonyMobile : Mobile
    {
        public override void TakePhoto()
        {
            Console.WriteLine($"You took a photo on your Sony phone {Model}");
        }
    }
}
