using System;

namespace som
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0, som = 0;
            Console.WriteLine("Maak de som van 5 ingevoerde gehele getallen");
            

            for(int i= 1;i < 6; i++)
            {
                Console.WriteLine($"Geef getal {i}:");
                getal = int.Parse(Console.ReadLine());
                som += getal;
                Console.Write($" --> som voorgaande getallen: {som}\n");
                

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Druk op enter om af te sluiten......");
            Console.ReadLine();
        }
    }
}
