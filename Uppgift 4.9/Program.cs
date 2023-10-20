using System;

namespace Uppgift_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång ska sidlängden i triangeln vara?");
            int sidlängd = int.Parse(Console.ReadLine());

            for(int i = 0; i < sidlängd; i++)
            {
                for(int j = i; j+1 > 0; j-- )
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}