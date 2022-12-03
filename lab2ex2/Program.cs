using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 2: Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura.
            int i, factorial = 1, numar;
            Console.Write("Intoduceti un numar: ");
            numar = int.Parse(Console.ReadLine());
            for (i = 1; i <= numar; i++)
            {
                factorial = factorial * i;
            }
            Console.Write("Factorialul lui " + numar + " este: " + factorial);
        }
    }
}
