using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cześć w tym programie sprawdzimy czy podałeś wartość parzystą czy nie parzystą.\nProszę podaj swoją liczbę:");
            var number = CheckNumber();
            if (number % 2 == 0)
            {
                Console.WriteLine($"Liczba którą wprowadziłeś czyli {number} jest liczbą parzystą.");
            }
            if (number % 2 != 0)
            {
                Console.WriteLine($"Liczba którą wprowadziłeś czyli {number} jest liczbą nieparzystą.");
            }
        }

        private static int CheckNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("Podałeś nieprawidłową wartość. Podaj ją jeszcze raz.");
                    continue;
                }
                return num;
            }
        }
    }
}
