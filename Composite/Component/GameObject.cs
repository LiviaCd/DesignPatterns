using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    abstract public class GameObject
    {
        public string Name { get; set; }
        protected GameObject(string name)
        {
            Name = name;
        }

        public abstract void Display(int level = 0);

    }
}
