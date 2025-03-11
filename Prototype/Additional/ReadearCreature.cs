using Prototype.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Additional
{
    public class ReadearCreature
    {
        public static Dragon ReadDragon()
        {
            Dragon dragon = new Dragon();
            dragon.Name = "Spyro";
            dragon.Type = "Dragon";
            dragon.Level = new Level { BaseHealth = 10, BaseAttack = 20 };

            return dragon;
        }

        public static Mario ReadMario()
        {
            Mario mario = new Mario();
            mario.Name = "Mario";
            mario.Type = "Mario";
            mario.Level = new Level { BaseHealth = 10, BaseAttack = 5 };

            return mario;
        }
    }
}
