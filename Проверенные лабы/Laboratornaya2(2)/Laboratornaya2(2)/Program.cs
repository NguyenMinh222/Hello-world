using System;
using System.Threading;

namespace Laboratornaya2_2_
{
    class Program
    {
        static void Main()
        {
            int a = 0, b = 0, c = 0, d = 0, e=0, f=0, g=0, k=0, l=0;
            string Format1;
            Format1 = DateTime.Now.ToString();
            Console.WriteLine("Slavyanski format");
            Console.WriteLine(Format1);
            Console.WriteLine("one:    two:  three:   four:   five:   six:   seven:  eight:  nine:");
            for (int i = 0; i < Format1.Length; i++)
                switch (Format1[i])
                {
                    case '1': 
                        a++; break;
                    case '2':
                        b++; break;
                    case '3':
                        c++; break;
                    case '4':
                        d++; break;
                    case '5':
                        e++; break;
                    case '6':
                        f++; break;
                    case '7':
                        g++; break;
                    case '8':
                        k++; break;
                    case '9':
                        l++; break;
                }
            Console.WriteLine(" "+a+"\t "+b+"\t" + c + "\t" + d + "\t" + e + "\t" + f + "\t" + g + "\t" + k + "\t" + l + "\t");
            int z = 0, x = 0, v = 0, q = 0, n = 0, m = 0, p = 0, u = 0, y = 0;
            DateTime DD = new DateTime();
            DD = DateTime.Now; 
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string Format2;
            Format2 = DD.ToString();
            Console.WriteLine("Zapadniy format");
            Console.WriteLine(Format2);
            Console.WriteLine("one:    two:  three:   four:   five:   six:   seven:  eight:  nine:");
            for (int i = 0; i < Format2.Length; i++)
                switch (Format2[i])
                {
                    case '1':
                        z++; break;
                    case '2':
                        x++; break;
                    case '3':
                        v++; break;
                    case '4':
                        q++; break;
                    case '5':
                        n++; break;
                    case '6':
                        m++; break;
                    case '7':
                        p++; break;
                    case '8':
                        u++; break;
                    case '9':
                        y++; break;
                }
            Console.WriteLine(" " + z + "\t " + x + "\t" + v + "\t" + q + "\t" + n + "\t" + m + "\t" + p + "\t" + u + "\t" + y + "\t");
            Console.ReadKey();
        }
    }
}
