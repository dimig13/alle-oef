using System;

namespace optellen_tot_eindsom
{
    class Program
    {
        static void Main(string[] args)
        {
            int som=10, eindsom, stapgrootte;
            Console.Write("Optellen tot eindsom: ");
            eindsom = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Afdruk per stapgrootte van:  ");
            stapgrootte = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n\n=== Afdruk per stapgrootte van: {stapgrootte} tot {eindsom}===");

            while ( som <= eindsom)
            {
                som += stapgrootte;
                Console.WriteLine($"waarde van som: {som}");
            }
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadLine();
               
        }
    }
}
