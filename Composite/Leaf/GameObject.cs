using Composite.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
    public class GameObject : Composite.GameObject
    {
        public GameObject(string name) : base(name) { }
        
        public override void Display(int level = 0)
        {
            string space = new string(' ', level);
            Console.WriteLine(space + Name);
        }
    }
}
