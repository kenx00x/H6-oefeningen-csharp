using System;

namespace Hoger_Lager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int getal;
            int randomGetal = random.Next(1, 101);
            do
            {
                Console.Write("Kies een getal: ");
                getal = int.Parse(Console.ReadLine());
                Console.Clear();
                if (randomGetal > getal)
                {
                    Console.WriteLine("Hoger");
                }
                else if (randomGetal < getal)
                {
                    Console.WriteLine("Lager");
                }
                else if (randomGetal == getal)
                {
                    Console.WriteLine("Correct!");
                }
            } while (getal != randomGetal);
        }
    }
}
