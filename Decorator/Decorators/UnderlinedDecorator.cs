using Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class UnderlinedDecorator : ComponentDecorator
    {
        public UnderlinedDecorator(IComponent textComponent) : base(textComponent) { }

        public override void PrintComponent()
        {
            Console.Write("\u001b[4m");

            _textComponent.PrintComponent();

            Console.Write("\u001b[0m");
        }
    }
}
