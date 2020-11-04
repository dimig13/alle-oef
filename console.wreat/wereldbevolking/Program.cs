using System;

namespace wereldbevolking
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime vandaag = DateTime.Now;
            long aantaldagen = 0;
            long bevolking = 7816000000;


            Console.WriteLine($"wereldbevolking op {vandaag.ToLongDateString()} is {bevolking:n0}");
            Console.WriteLine();

            while (bevolking < 10000000000)
            {
                aantaldagen++;
                bevolking += 270000;
            }

            Console.WriteLine($"wereldbevolking op {vandaag.AddDays(aantaldagen).ToLongDateString()} is {bevolking:n0}");
        }
    }
}
