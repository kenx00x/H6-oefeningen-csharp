using System;

namespace Tafels_van_vermenigvuldigen
{
    class Program
    {
        static void Main(string[] args)
        {
            int teller = 1;
            while (teller <= 10)
            {
                int product = teller * 10;
                Console.WriteLine($"{teller} x 10 = {product}");
                teller++;
            }
        }
    }
}
