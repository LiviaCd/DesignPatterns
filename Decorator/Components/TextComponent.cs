using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Components
{
    public class TextComponent : IComponent
    {
        protected string _textComponent;
        public TextComponent(string textComponent)
        {
            _textComponent = textComponent;
        }

        public void PrintComponent()
        {
            Console.WriteLine($"Text component: {_textComponent}");
        }
    }
}
