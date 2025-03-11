using Prototype.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Core
{
    public abstract class CreaturePrototype
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
       
        public Level Level;

        public abstract CreaturePrototype Clone();
    }
}
