using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //oef 3 

            Console.WriteLine("Geef een getal in");
             int z;
             bool isgelukt = int.TryParse("30", out z);
           
         
             if (isgelukt)
             {
                 if (z % 5 == 0)
                 {
                     Console.WriteLine("deelbaar door 5");
                 }
                 else if (z % 6 == 0)
                 {
                     Console.WriteLine("deelbaar door 6");
                 }
                 else
                 {
                     Console.WriteLine("niet deelbaar door vijf of zes");
                 }
             }
             else
             {
                 Console.WriteLine("Dit is geen geldige input");
             }



         }
     }
 }              

           











