using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3700.8;
            double y = 4500.6;
            double resultaat = x * y;
            Console.WriteLine(resultaat);
            if (resultaat > 10000)
            {
                Console.WriteLine("dit kan niet")
            }
            else
            {
                Console.WriteLine("het antwoord is dit");
            }

            
        }
        
    }
}
