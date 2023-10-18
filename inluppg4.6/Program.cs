using System;

namespace inluppg4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv meddelande");
            string input = Console.ReadLine();
            Console.WriteLine("Skriv antal rader förskjutning");
            int rader = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j <= rader; j++)
                {
                    Console.Write(' ');
                }
                Console.Write(input[i] + "\n");
            }
        }
    }
}