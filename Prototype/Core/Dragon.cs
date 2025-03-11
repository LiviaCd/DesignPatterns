using Prototype.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Core
{
    public class Dragon : CreaturePrototype
    {
        private string _color { get; set; } = string.Empty;
        public override CreaturePrototype Clone()
        {
            Dragon copy = (Dragon)MemberwiseClone();
            copy.Level = new Level { BaseHealth = Level.BaseHealth, BaseAttack = Level.BaseAttack };
            return copy;
        }
        public Dragon()
        {
            _color = "red"; 
        }
        public void DisplayDataDragon()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Color: {_color}");
            Console.WriteLine($"Base Health: {Level.BaseHealth}");
            Console.WriteLine($"Base Attack: {Level.BaseAttack}");
        }

    }
}
