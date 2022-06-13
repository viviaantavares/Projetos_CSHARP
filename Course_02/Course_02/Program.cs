using System;
using System.Globalization;

namespace Course_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 11, 25); 
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 02);
            DateTime d3 = DateTime.Today;
            DateTime d4 = DateTime.Parse("2000 - 08 - 15");
            DateTime d5 = DateTime.ParseExact("2000 - 08 - 15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                  

            Console.WriteLine(d1);  
            Console.WriteLine(d1.Ticks); // ticks unidade do .Net que representa 100 nanosegundos
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);






        }

    }
}