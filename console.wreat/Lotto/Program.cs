using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int teller = 1;
            Random rnd = new Random();
            int ak;
            Console.Write("hoeveel keren wil je lotto genereren? ");
             ak = int.Parse(Console.ReadLine());

            while(teller <= ak)
            {
                Console.WriteLine("De 6 LOTTO-getallen zijn: ");
                for(int i = 1; i< 7; i++)
                {
                    Console.WriteLine($"Getal {i}: {rnd.Next(1, 46)}");
                }
                teller++;
                Console.WriteLine();
                    
                
            }
        }
    }
}
