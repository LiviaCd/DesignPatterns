using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Core.Mobile
{
    public abstract class Mobile
    {
        public string Model = "S25";

        public abstract void TakePhoto();
    }
}
