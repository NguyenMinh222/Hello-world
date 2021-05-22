using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using belarus;

namespace LAB8
{
    class Money
    {
        public delegate void Message(string mess);
        public event Message notify;
        public event Message notify1;
        public int Oplata { get; private set; }
        public int Oplata1 { get; private set; }
        public Money(int m)
        {
            Oplata = m;
          
        }
        public void Have(int m)
        {
            Oplata = m;

        }
        public void Oplacheno(int m)
        {
            if (Oplata > m)
            {
                Oplata = Oplata - m;
                notify.Invoke($"S vashego schteta snyato {m}$ za obuchenie.");
            }
            else
            { notify.Invoke($"Nevozmozhno snyat money! Popolnite schet!"); }
        }
        public void Popolnenie(int m)
        {
            notify1.Invoke($"Popolnenie balansa na {m}$");
            Oplata = Oplata + m;
        }
      
        //События и обработчики событий находятся в файлах Bel.,Pol.,Another.
        //Генерация искл ситуаций в Program.cs
        static void Main1()
        {
           
        }
       
    }
}
