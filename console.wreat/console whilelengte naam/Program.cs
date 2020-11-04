using System;

namespace console_whilelengte_naam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een naam:  ");
            string naam = Console.ReadLine().ToUpper();

            while (!naam.Equals("END"))
            {
                Console.WriteLine();
                Console.WriteLine($"aantal karakters in {naam} is {naam.Length} ");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Geef een naam:   ");
                naam = Console.ReadLine().ToUpper();
            }
        }
    }
}
