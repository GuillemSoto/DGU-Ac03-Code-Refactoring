// Program.cs
using System;

namespace CodeWithIssues
{
    class Program
    {
        static void Main(string[] args)
        {
            int unusedVar = 10;

            Console.WriteLine("Benvingut al programa de càlculs!");
            Console.WriteLine("Benvingut al programa de càlculs!");

            int a = 5;
            int b = 10;
            int c = 15;
            int result = 0;

            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        result = a + b + c;
                    }
                    else
                    {
                        result = a + b;
                    }
                }
                else
                {
                    result = a;
                }
            }
            else
            {
                result = 0;
            }

            if (result == 0)
            {
                Console.WriteLine("El resultat és zero.");
            }
            else if (result > 0)
            {
                Console.WriteLine("El resultat és positiu.");
            }
            else
            {
                Console.WriteLine("El resultat és negatiu.");
            }

            int counter = 0;
            while (true)
            {
                counter++;
                if (counter > 100)
                {
                    break;
                }
            }

            // int oldVar = 20;

            int x = 5;
            x = x + 0;

            Console.WriteLine("Finalitzant el programa...");
            Console.WriteLine("Finalitzant el programa...");
        }
    }
}