using Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class ItalicDecorator : ComponentDecorator
    {
        public ItalicDecorator(IComponent textComponent) : base(textComponent) { }

        public override void PrintComponent()
        {
            Console.Write("\u001b[3m");

            _textComponent.PrintComponent();

            Console.Write("\u001b[0m");
        }
    }
}
