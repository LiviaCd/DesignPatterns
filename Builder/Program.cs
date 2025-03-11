using Builder;

class Program
{
    static void Main(string[] args)
    {
        Book book = Book.With()
                        .Title("The Mystery of the Blue Train")
                        .Authour("Agatha Christie")
                        .ISBN("2-1234-5678-9")
                        .Genre("Detectiv")
                        .Language("EN")
                        .Rating(5.0)
                        .Build();

        Console.ReadLine();

    }
}