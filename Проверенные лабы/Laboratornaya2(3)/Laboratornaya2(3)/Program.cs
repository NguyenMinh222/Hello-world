using System;
using System.Threading;
namespace Laboratornaya2_3_
{
    class Program
    {           
        static void xz()
            {
                Console.WriteLine("Choose language: ru-Russian, en-English, fr-French");
            } 
        static void Main()
        {
            xz();
            string yazik;
            yazik = Console.ReadLine();
            while (yazik != "en"&&yazik!="ru"&&yazik!="fr")
            {
                Console.WriteLine("Povtorite vvod (you can write only 2 letters as above) :");
                yazik=Console.ReadLine();
                Console.Clear();
                xz();
            }
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(yazik);
            for (int i = 1; i <= 12; i++)
            {
                DateTime Fran = new DateTime(2021, i, 3);
                Console.WriteLine("{0:MMMM }", Fran);
            }
              Console.ReadKey();
        }
    }
}
