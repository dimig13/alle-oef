using System;
using System.Text.RegularExpressions;

namespace macht
{
    class Program
    {
        static void Main(string[] args)
        {
            double macht;

            Console.Write("Geef je grondtal in kleiner dan 85: ");
            int grondtal = int.Parse(Console.ReadLine());

            //test of getal kleiner is dan 85
            if(grondtal< 85)
            {
                Console.WriteLine();
                for (int i = 1; i <= 10; i++)
                {
                    macht = Math.Pow(grondtal, i);

                    Console.WriteLine($"De macht {i,2} van {grondtal} = {macht:n0}");
                }
            }
            else
            {
                Console.WriteLine("\n\n Geef getal kleiner dan 85!");
            }
        }
    }
}
