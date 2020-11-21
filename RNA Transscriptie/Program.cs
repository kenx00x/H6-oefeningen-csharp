using System;

namespace RNA_Transscriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = "", DNA = "", RNA = "";
            do
            {
                Console.WriteLine("Voer G, C, T of A in");
                inp = Console.ReadLine();
                switch (inp)
                {
                    case "G":
                        DNA += "G";
                        RNA += "C";
                        break;
                    case "C":
                        DNA += "C";
                        RNA += "G";
                        break;
                    case "T":
                        DNA += "T";
                        RNA += "A";
                        break;
                    case "A":
                        DNA += "A";
                        RNA += "U";
                        break;
                    default:
                        Console.WriteLine("Onbekende invoer. We stoppen ermee.");
                        inp = "stop";
                        break;
                }
            } while (inp != "stop");
            Console.WriteLine("Resultaat:");
            Console.WriteLine(DNA);
            Console.WriteLine(RNA);
        }
    }
}
