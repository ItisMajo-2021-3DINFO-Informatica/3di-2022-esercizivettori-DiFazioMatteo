using System;

namespace Di_Fazio_PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Generator");

            int[] numeri = new int[10];
             numeri[0] = 1;
             numeri[1] = 2;
             numeri[2] = 3;
             numeri[3] = 4;
             numeri[4] = 5;
             numeri[5] = 6;
             numeri[6] = 7;
             numeri[7] = 8;
             numeri[8] = 9;
             numeri[9] = 0;

            char[] alfabeto = new char[26];
            alfabeto[0] = 'a';
            alfabeto[01] = 'b';
            alfabeto[02] = 'c';
            alfabeto[03] = 'd';
            alfabeto[04] = 'e';
            alfabeto[05] = 'f';
            alfabeto[06] = 'g';
            alfabeto[07] = 'h';
            alfabeto[08] = 'i';
            alfabeto[09] = 'j';
            alfabeto[10] = 'k';
            alfabeto[11] = 'l';
            alfabeto[12] = 'm';
            alfabeto[13] = 'n';
            alfabeto[14] = 'o';
            alfabeto[15] = 'p';
            alfabeto[16] = 'q';
            alfabeto[17] = 'r';
            alfabeto[18] = 's';
            alfabeto[19] = 't';
            alfabeto[20] = 'u';
            alfabeto[21] = 'v';
            alfabeto[22] = 'w';
            alfabeto[23] = 'x';
            alfabeto[24] = 'y';
            alfabeto[25] = 'z';

            Console.WriteLine("indica la lunghezza della tua password");

            int lunghezza = Convert.ToInt32(Console.ReadLine());

            string NuovaPassword = "";

            Random generatore = new Random();

            for(int i = 0; i < lunghezza; i++)
            {
                int indiceNumeri = generatore.Next(0, 10);
                NuovaPassword = NuovaPassword + alfabeto[indiceNumeri];
            }

            Console.WriteLine("La tua password sicura è: ");
            Console.WriteLine(NuovaPassword);
        }


    }
}
