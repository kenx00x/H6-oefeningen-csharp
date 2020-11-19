using System;

namespace Opwarmers_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toon alle natuurlijke getallen van 1 tot n.
            Console.Write("Geef n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Toon alle natuurlijke getallen van n tot 1.
            Console.Write("Geef n: ");
            for (n = int.Parse(Console.ReadLine()); n < 1 + 1; n++)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            //Toon alle even getallen tussen 1 en 100.
            for (int i = 1; i < 101; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Toon alle oneven getallen tussen 1 en 100.
            for (int i = 2; i < 101; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Toon de som van alle getallen van 1 tot n (dus 1+2+3+4+...+n).
            int j = 0;
            Console.Write("Geef n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                j += i;
            }
            Console.WriteLine(j);
            Console.WriteLine();

            //Toon de som van alle even getallen van 1 tot n.
            j = 0;
            Console.Write("Geef n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i += 2)
            {
                j += i;
            }
            Console.WriteLine(j);
            Console.WriteLine();

            //Toon de som van alle oneven getallen van 1 tot n.
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
