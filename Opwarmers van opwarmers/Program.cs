﻿using System;

namespace Opwarmers_van_opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("1");
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
            Console.WriteLine("2");
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
            Console.WriteLine("3");
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
            Console.WriteLine($"negatieve = {uitkomstneg - 1}");
            Console.WriteLine($"nullen = {uitkomstnul}");
            Console.WriteLine();

            //4
            Console.WriteLine("4");
            uitkomst = 1;
            do
            {
                Console.Write("Geef getal in(0 om te stoppen): ");
                n = int.Parse(Console.ReadLine());
                if (n != 0)
                {
                    uitkomst *= n;
                }
            } while (n != 0);
            Console.WriteLine($"product = {uitkomst}");
            Console.WriteLine();

            //5
            Console.WriteLine("5");
            Console.Write("Geef getal in: ");
            string getal = Console.ReadLine();
            int lengte = getal.Length;
            n = 0;
            for (int i = 0; i < lengte; i++)
            {
                n += int.Parse(getal.Substring(i, 1));
            }
            Console.WriteLine($"Som = {n}");
            Console.WriteLine();

            //6
            Console.WriteLine("6");
            n = 0;
            int aantal = 0;
            decimal gemiddelde = 0;
            do
            {
                Console.Write("Geef getal in(negatief getal om af te sluiten): ");
                aantal++;
                n = int.Parse(Console.ReadLine());
                if (n >= 0)
                {
                    gemiddelde += n;
                }
            } while (n >= 0);
            Console.WriteLine($"Gemiddelde = {Math.Round(gemiddelde / Convert.ToDecimal(aantal-1), 0)}");
            Console.WriteLine();

            //7
            Console.WriteLine("7");
            string strKleinsteGetal = "";
            n = 0;
            do
            {
                Console.Write("Geef getal in(-32768 om te stoppen): ");
                n = int.Parse(Console.ReadLine());
                if ((strKleinsteGetal == "" || n < int.Parse(strKleinsteGetal)) && n != -32768)
                {
                    strKleinsteGetal = Convert.ToString(n);
                }
            } while (n != -32768);
            Console.WriteLine($"Kleinste getal = {strKleinsteGetal}");
            Console.WriteLine();

            //8
            Console.WriteLine("8");
            n = -2147483648;
            int oudGetal;
            do
            {
                Console.Write("Geef getal in(Geef een getal in kleiner dan het vorige om te stopper): ");
                oudGetal = n;
                n = int.Parse(Console.ReadLine());
            } while (n > oudGetal);
            Console.WriteLine("fout in sorteervolgorde");
            Console.WriteLine();

            //9
            Console.WriteLine("9");
            n=1;
            aantal = 0;
            gemiddelde = 0;
            do
            {
                Console.Write("Geef getal in(geef 2 keer 0 in om te stoppen): ");
                oudGetal = n;
                n = int.Parse(Console.ReadLine());
                gemiddelde += n;
                aantal++;
            } while (oudGetal !=0 || n != 0);
            Console.WriteLine($"gemiddelde = {gemiddelde/(aantal-2)}");
            Console.WriteLine();

            //10
            Console.WriteLine("10");
            uitkomst = 0;
            for (int i = 50; i < 101; i++)
            {
                uitkomst += i* i;
            }
            Console.WriteLine($"som = {uitkomst}");
            Console.WriteLine();

            //11
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Geef getal in: ");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Het getal is deelbaar door 2");
                    }
                    if (n % 3 == 0)
                    {
                        Console.WriteLine("Het getal is deelbaar door 3");
                    }
                    if (n % 6 == 0)
                    {
                        Console.WriteLine("Het getal is deelbaar door 6");
                    }
                }
            }
            Console.WriteLine();
            //12
            Console.WriteLine("12");
            decimal uwu = 0;
            for (int i = 1; i < 31; i++)
            {
                uwu += i * 6;
            }
            Console.WriteLine(uwu);
            uwu = 4;
            for (int i = 1; i < 30; i++)
            {
                uwu += 4 + (i * 8);
            }
            Console.WriteLine(uwu);
            uwu = 1;
            for (int i = 1; i < 30; i++)
            {
                uwu += Convert.ToDecimal(Math.Pow(2, i));
            }
            Console.WriteLine(uwu);
            uwu = 1;
            for (int i = 1; i < 30; i++)
            {
                uwu += Convert.ToDecimal(1 / Math.Pow(2, i));
            }
            Console.WriteLine(uwu);
            uwu = 1;
            for (double i = 1; i < 30; i++)
            {
                uwu += Convert.ToDecimal(1.0 / ((i * 2.0) + 1.0));
            }
            Console.WriteLine(uwu);
            uwu = 0;
            for (double i = 1; i < 30; i++)
            {
                uwu += Convert.ToDecimal(1 / (i + Math.Pow(2, i)));
            }
            Console.WriteLine(uwu);
            Console.WriteLine();
            //13
            Console.WriteLine("13");
            decimal owo = 0;
            for (int i = 1; i < 21; i++)
            {
                owo += i * 4;
            }
            Console.WriteLine(owo);
            owo = 4;
            for (int i = 1; i < 20; i++)
            {
                owo += 4 + (i * 6);
            }
            Console.WriteLine(owo);
            owo = 1;
            for (int i = 1; i < 20; i++)
            {
                owo += Convert.ToDecimal(Math.Pow(3, i));
            }
            Console.WriteLine(owo);
            owo = 0;
            for (int i = 1; i < 20; i++)
            {
                owo += Convert.ToDecimal(1.0 / (2.0 * i));
            }
            Console.WriteLine(owo);
            owo = 1;
            for (double i = 1; i < 20; i++)
            {
                owo += Convert.ToDecimal(1 / Math.Pow(2, i));
            }
            Console.WriteLine(owo);
            owo = 1;
            int idk = 3;
            for (double i = 1; i < 20; i++)
            {
                owo += Convert.ToDecimal(1.0 / idk);
                idk += idk + 1;
            }
            Console.WriteLine(owo);
        }
    }
}