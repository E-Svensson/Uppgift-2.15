using System;

namespace Uppgift_215
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med endast tre ord och en punkt");
            Console.Write("Skriv här: "); string mening = Console.ReadLine();

            string[] ord = mening.Split(' ', '.');

            Console.WriteLine("Din mening baklänges blir då: " + ord[2] + " " + ord[1] + " " + ord[0] + ".");
        }
    }
}
