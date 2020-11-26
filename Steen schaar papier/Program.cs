using System;

namespace Steen_schaar_papier
{
    class Program
    {
        static void Main(string[] args)
        {
            int mensScore = 0;
            int computerScore = 0;
            int mensKeuze = 0;
            int computerKeuze = 0;
            Random random = new Random();
            while (mensScore != 10 && computerScore != 10)
            {
                if (mensKeuze == 1 && computerKeuze == 2)
                {
                    Console.WriteLine("Computer won");
                    computerScore++;
                }
                else if (mensKeuze == 1 && computerKeuze == 3)
                {
                    Console.WriteLine("Mens won");
                    mensScore++;
                }
                else if (mensKeuze == 2 && computerKeuze == 1)
                {
                    Console.WriteLine("Mens won");
                    mensScore++;
                }
                else if (mensKeuze == 2 && computerKeuze == 3)
                {
                    Console.WriteLine("Computer won");
                    computerScore++;
                }
                else if (mensKeuze == 3 && computerKeuze == 1)
                {
                    Console.WriteLine("Computer won");
                    computerScore++;
                }
                else if (mensKeuze == 3 && computerKeuze == 2)
                {
                    Console.WriteLine("Mens won");
                    mensScore++;
                }
                else if (mensKeuze == computerKeuze && computerKeuze != 0)
                {
                    Console.WriteLine("Jullie kozen hetzelfde");
                }
                if (mensScore != 10 && computerScore != 10)
                {
                    Console.WriteLine($"U heeft {mensScore} punten | De computer heeft {computerScore} punten");
                    Console.WriteLine("1) Schaar");
                    Console.WriteLine("2) Steen");
                    Console.WriteLine("3) Papier");
                    Console.Write("Maak je keuze: ");
                    mensKeuze = int.Parse(Console.ReadLine());
                    computerKeuze = random.Next(1, 4);
                    Console.Clear();
                }
            }
        }
    }
}
