using System;

namespace HolaMundo
{
    class Programa
    {
        static void Main(string[] args)
        {
            int i;

            for( i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hola! {i}");
            }
            Console.ReadLine();
        }
    }
}