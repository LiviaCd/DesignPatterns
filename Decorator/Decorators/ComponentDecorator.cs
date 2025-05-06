using Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public abstract class ComponentDecorator : IComponent
    {
        protected IComponent _textComponent;
        protected ComponentDecorator(IComponent textComponent)
        {
            _textComponent = textComponent;
        }

        public abstract void PrintComponent();
    }
}
