using System;

namespace DiFazioEsVettori1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 400;
            int i = 0;
            Random generatore = new Random();
            for (int c = 0; c < dimensione; c++)
            {
                int numerocasuale = generatore.Next(0, 101);
                Console.WriteLine($"{numerocasuale}");
            }


        }
    }
}
