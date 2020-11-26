using System;

namespace Tekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            do
            {
                Console.Clear();
                Console.Write("Geef getal1 in (tussen 2 en 20): ");
                getal1 = int.Parse(Console.ReadLine());
            } while (getal1 < 2 || getal1 > 20);
            int getal2;
            do
            {
                Console.Clear();
                Console.Write("Geef getal2 in (tussen 2 en 20): ");
                getal2 = int.Parse(Console.ReadLine());
            } while (getal2 < 2 || getal2 > 20);
            Console.Clear();
            for (int i = 0; i < getal1; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < getal2 - 2; i++)
            {
                Console.WriteLine();
                Console.Write("*");
                for (int j = 2; j < getal1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < getal1; i++)
            {
                Console.Write("*");
            }
        }
    }
}
