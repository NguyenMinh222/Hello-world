using System;
using System.Collections.Generic;
namespace LAB7
{
    class RatNumber
    {
        public int A { get; set; }
        public int B { get; set; }
        static string str;
        public static int A1()
        {
            string a;
            int AA1;
            do
            {
                try
                {
                    a=  Console.ReadLine();
                    if (!int.TryParse(a, out AA1))
                    {
                        Console.Clear();
                        throw new Exception("Re-enter");
                    }
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Voznihlo iskluchenie: {e.Message}");
                }

            } while (true);

            return AA1;
        }
        public static int A2()
        {
            string a1;
            int AA2;
            do
            {
                try
                {
                    a1 = Console.ReadLine();
                    if (!int.TryParse(a1, out AA2))
                    {
                        Console.Clear();
                        throw new Exception("Re-enter");
                    }
                    else if (Convert.ToInt32(a1) == 0)
                    {
                        throw new Exception("Znamenatel ne mozhet be null!");
                    }
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Voznihlo iskluchenie: {e.Message}");
                }

            } while (true);

            return AA2;
        }
        public RatNumber(int n, int m)
        {
            A = n; B = m;
            if (B == 0)
            {
                throw new Exception("Znamenatel ne mozhet be null!");
            }

        }
        void ReduceFraction()
        {
            int i = 2;
            uint j = 2;
            for (; i <= Math.Abs(A) && j <= B;)
                if (Math.Abs(A) % i == 0 && B % i == 0)
                {
                    A /= i;
                    B /= (int)j;
                }
                else
                {
                    i++;
                    j++;
                }
        }
        public static RatNumber operator +(RatNumber a, RatNumber b)
        {
            int CommonDenominator = MyMath.CommonMultiple(a.A, b.B);
            int NOD = Math.Abs(MyMath.CommonDivisor(a.A * CommonDenominator / a.B + b.A * CommonDenominator / b.B, CommonDenominator));
            return new RatNumber((a.A * CommonDenominator / a.B + b.B * CommonDenominator / b.B) / NOD, CommonDenominator / NOD);
        }

        public static RatNumber operator +(RatNumber a, int b)
        {
            int NOD = Math.Abs(MyMath.CommonDivisor(a.A + b * a.B, a.A));
            return new RatNumber((a.A + b * a.B) / NOD, a.B / NOD);
        }
        public static RatNumber operator -(RatNumber a, RatNumber b)
        {
            int CommonDenominator = MyMath.CommonMultiple(a.B, b.B);
            int NOD = Math.Abs(MyMath.CommonDivisor(a.A * CommonDenominator / a.B - b.A * CommonDenominator / b.B, CommonDenominator));
            return new RatNumber((a.A * CommonDenominator / a.B - b.A * CommonDenominator / b.B) / NOD, CommonDenominator / NOD);
        }
        public static RatNumber operator -(RatNumber a, int b)
        {
            int NOD = Math.Abs(MyMath.CommonDivisor(a.A - b * a.B, a.B));
            return new RatNumber((a.A - b * a.B) / NOD, a.B / NOD);
        }
        public static RatNumber operator *(RatNumber a, RatNumber b)
        {
            RatNumber mul = new RatNumber(a.A * b.A, a.B * b.B);
            mul.ReduceFraction();
            return mul;
        }

        public static RatNumber operator /(RatNumber a, RatNumber b)
        {
            RatNumber div = new RatNumber(a.A * b.B, a.B * b.A);
            div.ReduceFraction();
            return div;
        }
        public static bool operator >(RatNumber a, RatNumber b)
        {
            return (double)a.A / a.B > (double)b.A / b.B;
        }
        public static bool operator <(RatNumber a, RatNumber b)
        {
            return (double)a.A / a.B < (double)b.A / b.B;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", A, B);
        }

        public string StrFormat()
        {
            return string.Format("Numerator: {0}, Denominator: {1}", A, B);
        }

        public RatNumber StrToObj(string str)
        {
            string strn = "";
            string strm = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '/')
                {
                    for (i++; i < str.Length; i++)
                    {
                        strm += str[i];
                    }
                }
                else strn += str[i];
            }
            RatNumber ratnum1 = new RatNumber(Convert.ToInt32(strn), Convert.ToInt32(strm));
            return ratnum1;
        }

        public bool Equals(RatNumber other)
        {
            if (other == null)
                return false;
            if (((double)this.A) / ((double)this.B) == (((double)other.A) / ((double)other.B)))
                return true;
            else
                return false;
        }
        public bool Compare(RatNumber other)
        {
            if (other == null)
                return false;
            if (this.A == other.A && this.B == other.B)
                return true;
            else
                return false;
        }

        public static implicit operator RatNumber(double x)
        {
            string strint = "";
            string strfract = "";
            double counter = 0;
            int n;
            int m;

            str = x.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.' || str[i] == ',')
                {
                    for (i++; i < str.Length; i++)
                    {
                        strfract += str[i];
                        counter++;
                    }
                }
                else strint += str[i];
            }
            if (strfract.Length == 0)
                strfract = "0";
            m = (int)Math.Pow(10, counter);
            n = (Convert.ToInt32(strint) * m + Convert.ToInt32(strfract));
            return new RatNumber(n, m);
        }

        public static implicit operator RatNumber(int x)
        {
            return new RatNumber(x, 1);
        }

        public static implicit operator double(RatNumber ratnum)
        {
            return (((double)ratnum.A) / ((double)ratnum.B));
        }

        public static implicit operator int(RatNumber ratnum)
        {
            return (ratnum.A / ratnum.B);
        }

        public static implicit operator string(RatNumber ratnum)
        {
            return ratnum.ToString();
        }
    };
}