using System;
namespace LAB8
{
    class Program
    {
        static void Main()
        {
            try
            {
                RatNumber num1 = new RatNumber(0, 1);
                RatNumber num2 = new RatNumber(0, 1);
                string str = "";
                string str2 = "";
                ConsoleKeyInfo ch;
                ConsoleKeyInfo ch1;

                Console.WriteLine("Vvedite chislitel for vashego Rational Number:");
                num1.A = int.Parse(Console.ReadLine());
                Console.WriteLine("Vvedite znamenatel for vashego Rational Number:");
                num1.B = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Choose string format:");
                Console.WriteLine("1");
                Console.WriteLine("2");
                ch = Console.ReadKey();
                if (ch.KeyChar == '1')
                    str = num1.ToString();
                if (ch.KeyChar == '2')
                    str = num1.StrFormat();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Your rational number: ");
                    Console.WriteLine(str);
                    Console.WriteLine("");
                    Console.WriteLine("1 - Add the rational number");
                    Console.WriteLine("2 - Subtract the rational number");
                    Console.WriteLine("3 - Multiplied by the rational number");
                    Console.WriteLine("4 - Divided by the rational number");
                    Console.WriteLine("5 - To equal with rational number");
                    Console.WriteLine("6 - Change string format");
                    Console.WriteLine("7 - To compare two rational numbers");
                    Console.WriteLine("0 - Exit");
                    ch1 = Console.ReadKey();
                    if (ch1.KeyChar == '1')
                    {
                        Console.Clear();
                        Console.WriteLine("Vvedite A");
                        num2.A = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Vvedite B");
                        num2.B = int.Parse(Console.ReadLine());
                        num1 = num1 + num2;
                        if (ch.KeyChar == '1')
                            str = num1.ToString();
                        if (ch.KeyChar == '2')
                            str = num1.StrFormat();
                        Console.Clear();
                        Console.WriteLine("Nazhmite na lybuyu knopku for continue");
                    }

                    if (ch1.KeyChar == '2')
                    {
                        Console.Clear();
                        Console.WriteLine("Vvedite A");
                        num2.A = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Vvedite B");
                        num2.B = int.Parse(Console.ReadLine());
                        num1 = num1 - num2;
                        if (ch.KeyChar == '1')
                            str = num1.ToString();
                        if (ch.KeyChar == '2')
                            str = num1.StrFormat();
                        Console.Clear();
                        Console.WriteLine("Nazhmite na lybuyu knopku for continue");
                    }

                    if (ch1.KeyChar == '3')
                    {
                        Console.Clear();
                        Console.WriteLine("Vvedite A");
                        num2.A = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Vvedite B");
                        num2.B = int.Parse(Console.ReadLine());
                        num1 = num1 * num2;
                        if (ch.KeyChar == '1')
                            str = num1.ToString();
                        if (ch.KeyChar == '2')
                            str = num1.StrFormat();
                        Console.Clear();
                        Console.WriteLine("Nazhmite na lybuyu knopku for continue");
                    }

                    if (ch1.KeyChar == '4')
                    {
                        Console.Clear();
                        Console.WriteLine("Vvedite A");
                        num2.A = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Vvedite B");
                        num2.B = int.Parse(Console.ReadLine());
                        num1 = num1 / num2;
                        if (ch.KeyChar == '1')
                            str = num1.ToString();
                        if (ch.KeyChar == '2')
                            str = num1.StrFormat();
                        Console.Clear();
                        Console.WriteLine("Nazhmite na lybuyu knopku for continue");
                    }

                    if (ch1.KeyChar == '5')
                    {
                        Console.Clear();
                        Console.WriteLine("Enter rational number: ");
                        str2 = Console.ReadLine();
                        num2 = num2.StrToObj(str2);
                        Console.Clear();
                        if (num1.Equals(num2))
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No");
                    }
                    if (ch1.KeyChar == '6')
                    {
                        Console.Clear();
                        Console.WriteLine("Choose string format:");
                        Console.WriteLine("1");
                        Console.WriteLine("2");
                        ch = Console.ReadKey();
                        if (ch.KeyChar == '1')
                            str = num1.ToString();
                        if (ch.KeyChar == '2')
                            str = num1.StrFormat();
                        Console.Clear();
                        Console.WriteLine("Nazhmite na lybuyu knopku for continue");
                    }
                    if (ch1.KeyChar == '7')
                    {
                        Console.Clear();
                        Console.WriteLine("VVedite A");
                        num2.A = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Vvedite B");
                        num2.B = int.Parse(Console.ReadLine());
                        if (num1 > num2)
                        {
                            Console.WriteLine("{0} > {1}", num1, num2);
                        }
                        else
                        {
                            if (num2 > num1)
                            {
                                Console.WriteLine("{0} < {1}", num1, num2);
                            }
                        }
                    }

                    if (ch1.KeyChar == '0')
                        break;
                    Console.ReadKey();
                }
            }
            catch (Exception exc)
            {
                Console.Clear();
                Console.WriteLine(exc.Message);
            }
        }
        
    };
}