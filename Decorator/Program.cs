using Decorator.Components;
using Decorator.Decorators;

class Program
{
    static void Main(string[] args)
    {
        IComponent textComponent = new TextComponent("Design Patterns ... ");

        textComponent = new BoldDecorator(textComponent);
        textComponent = new UnderlinedDecorator(textComponent);
        textComponent = new ItalicDecorator(textComponent);
        textComponent = new FaintDecorator(textComponent);

        textComponent.PrintComponent();

        Console.WriteLine("\nsimple text");
        
    }
}