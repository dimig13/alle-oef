using System;

namespace optelling_per_tien
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0, eindsom, tel = 0;
            Console.Write("tot welke eindsom moet er opgeteld worden met 10? ");
            eindsom = int.Parse(Console.ReadLine());
            Console.WriteLine();



            while (som <= eindsom)
            {
                som += 10;
                tel++;
            }

            Console.WriteLine();
            Console.WriteLine($"Aantal keren opgeteld: {--tel}");

        } 
    }
}
