using Singleton;

class Program
{
    static void Main(string[] args)
    {
        Printer.GetInstance().Name = "Canon";
        Printer.GetInstance().Quality = "High";
        Printer.GetInstance().Format = "A4";

        Printer.GetInstance().PrintFile("raport", 2);
    }
}