using System;

namespace DrugiZadatak
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int broj;


            Console.Write("Upisite br: ");
            broj = Convert.ToInt32(Console.ReadLine());
            if (broj % 4 == 0 && broj % 6 != 0) { Console.WriteLine("Broj je dijeliv s 4 ");  }
            if (broj % 6 == 0 && broj % 4 != 0) { Console.WriteLine("Broj je dijeliv s 6 ");  }
            if (broj % 4 == 0 && broj % 6 == 0) { Console.WriteLine("Broj je dijeliv s 4 i 6 "); }
            if (broj % 4 != 0 && broj % 6 != 0) { Console.WriteLine("Broj je nije dijeliv s 4 i 6 "); }



            Console.ReadKey();

        }
    }
}
