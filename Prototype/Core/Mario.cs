using Prototype.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Core
{
    public class Mario : CreaturePrototype
    {
        public override CreaturePrototype Clone()
        {
            Mario copy = (Mario)MemberwiseClone();
            copy.Level = new Level { BaseHealth = Level.BaseHealth, BaseAttack = Level.BaseAttack };
            return copy;
        }

        public void DisplayDataMario()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Base Health: {Level.BaseHealth}");
            Console.WriteLine($"Base Attack: {Level.BaseAttack}");
        }
    }
}
