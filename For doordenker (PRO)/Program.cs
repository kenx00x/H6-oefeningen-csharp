using System;

namespace For_doordenker__PRO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef max in: ");
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = max; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}