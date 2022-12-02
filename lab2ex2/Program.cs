using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 2: Scrieti un program care va afisa factorialul unui numar n, n fiind citit
                de la tastatura.
             */

            Console.WriteLine("Numarul n este: ");
            int n = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            Console.WriteLine("Rezultatul este: " + result);
        }
    }
}
