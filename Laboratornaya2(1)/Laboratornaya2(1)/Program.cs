using System;
using System.Text;

namespace Laboratornaya2_1_
{
    class Program
    {
        static void Main()
        {
            StringBuilder _Stroka = new StringBuilder(Console.ReadLine());
            string Slova = _Stroka.ToString();
            for (int i = Slova.Length - 1; i > 0; i--)
            {
                while (Slova[i] < ' ' || (Slova[i] > ' ' && Slova[i] < '-') || (Slova[i] > '-' && Slova[i] < 'A') || (Slova[i] > 'Z' && Slova[i] < 'a') || Slova[i] > 'z')
                {
                    Console.WriteLine("Pishite slova tolko iz english bukv!");
                    Slova = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(Slova);
                    i = Slova.Length - 1;
                }
            }
            string[] Stroka2 = Slova.Split(' ');//Delim stroku na massiv podstrok 
            Array.Reverse(Stroka2);// Reverses the sort of the values of the Array.
            for (int i = 0; i < Stroka2.Length; i++)
            {
                if (Stroka2[i] != "")
                {
                    Console.Write(Stroka2[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
