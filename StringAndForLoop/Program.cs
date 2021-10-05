using System;

namespace StringAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string FirstName = Console.ReadLine();

            for (int i = 0; i < FirstName.Length; i++)
            {
                Console.WriteLine(FirstName[i]);
            }
        }
    }
}
