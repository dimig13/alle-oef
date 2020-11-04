using System;

namespace console.write
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine();

            Console.Write("geef een getal: ");
            int getal = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("afdruk");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Naam: {naam} getal: {getal:n2}");

        }
    }
}
