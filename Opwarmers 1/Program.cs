using System;

namespace Opwarmers_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.Write("Geef n: ");
            for (n = int.Parse(Console.ReadLine()); n < 1 + 1; n++)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            for (int i = 1; i < 101; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 2; i < 101; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int j = 0;
            Console.Write("Geef n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                j += i;
            }
            Console.WriteLine(j);
            Console.WriteLine();

            j = 0;
            Console.Write("Geef n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i += 2)
            {
                j += i;
            }
            Console.WriteLine(j);
            Console.WriteLine();

            j = 0;
            Console.Write("Geef n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n + 1; i += 2)
            {
                j += i;
            }
            Console.WriteLine(j);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
