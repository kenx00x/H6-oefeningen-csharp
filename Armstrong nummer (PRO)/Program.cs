using System;

namespace Armstrong_nummer__PRO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());
            //1° Aantal cijfers ontdekken
            int aantalcijfers = 0;
            int deling = 0;
            int maaltien = 10;
            do
            {
                deling = getal / maaltien;
                maaltien *= 10;
                aantalcijfers++;
            } while (deling != 0);

            //2° Kijken of het armstrong is
            int som = 0;
            int enkelgetal = 0;
            int aantalloops = aantalcijfers;
            int tussengetal = getal;
            while (aantalloops > 0)
            {
                enkelgetal = tussengetal / (int)Math.Pow(10, aantalloops - 1);
                som += (int)Math.Pow(enkelgetal, aantalcijfers);

                tussengetal = tussengetal - (enkelgetal * (int)Math.Pow(10, aantalloops - 1));
                aantalloops--;
            }

            if (som == getal)
            {
                Console.WriteLine("Getal is een armstrong getal!");
            }
        }
    }
}
