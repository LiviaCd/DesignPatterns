using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Printer
    {
        public string Name { get; set; }
        public string Quality {  get; set; }  
        public string Format {  get; set; } 

        private static Printer _instance;

        private static readonly object _lock = new object();
        private Printer() 
        {
            Console.WriteLine("Printer is initialized");
        }
        
        public static Printer GetInstance()
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Printer();
                    }
                }
            }
            return _instance;
        }

        public void PrintFile(string fileName, int countCopy)
        {
            if (countCopy <= 0)
            {
                Console.WriteLine("Invalid number of copy");
                return;
            }

            for (int i = 0; i < countCopy; i++)
            {
                Console.WriteLine($"{fileName} was printing");
                Console.WriteLine($"Name: {Name}, Format: {Format}, Quality: {Quality}");
            }
            return;
        }

    }
}
