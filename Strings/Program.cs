using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //proramm küsib kasutajal sisestada tema eesnime
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime viimase tähe

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine(firstName[0]);
            Console.WriteLine(firstName[0]);

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Teie nimi on {firstNameLength} sümbolit pikk");

            //viimase tähe indeks 
            Console.WriteLine(firstName[firstNameLength-1]);
        }
    }
}

