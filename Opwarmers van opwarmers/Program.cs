using System;

namespace Opwarmers_van_opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int n;
            int uitkomst = 0;
            do
            {
                Console.Write("Geef getal in(0 om te stoppen): ");
                n = int.Parse(Console.ReadLine());
                uitkomst += n;
            } while (n != 0);
            Console.WriteLine($"som = {uitkomst}");
            Console.WriteLine();

            //2
            int uitkomstpos = 0;
            int uitkomstneg = 0;
            do
            {
                Console.Write("Geef getal in(0 om te stoppen): ");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    uitkomstpos++;
                }
                else if (n < 0)
                {
                    uitkomstneg++;
                }
            } while (n != 0);
            Console.WriteLine($"postieve = {uitkomstpos}");
            Console.WriteLine($"negatieve = {uitkomstneg}");
            Console.WriteLine();

            //3
            int uitkomstnul = 0;
            do
            {
                Console.Write("Geef getal in(-32768 om te stoppen): ");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    uitkomstpos++;
                }
                else if (n < 0)
                {
                    uitkomstneg++;
                }
                else if (n == 0)
                {
                    uitkomstnul++;
                }
            } while (n != -32768);
            Console.WriteLine($"postieve = {uitkomstpos}");
            Console.WriteLine($"negatieve = {uitkomstneg}");
            Console.WriteLine($"nullen = {uitkomstnul}");
            Console.WriteLine();

            //4
            uitkomst = 1;
            do
            {
                Console.Write("Geef getal in(0 om te stoppen): ");
                n = int.Parse(Console.ReadLine());
                if (n !=0)
                {
                    uitkomst *= n;
                }
            } while (n != 0);
            Console.WriteLine($"product = {uitkomst}");
            Console.WriteLine();
        }
    }
}
