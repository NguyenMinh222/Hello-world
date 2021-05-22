using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using belarus;
using poland;
using another;
using Lab6;

using System.Runtime.Serialization;

namespace LAB3
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        protected string Nationality { get; set; }
        public int Age { get; set; }
        protected double Weight { get; set; }
        protected double Height { get; set; }
        public int CompareTo(Student o)
        {
            Student p = o as Student;
            if (p != null)
                return this.Age.CompareTo(p.Age);
            else
                throw new Exeption("Impossible to compare two objects");
        }
        public static string Imya()
        {
            string imya;
            bool k = false;
            do
            {
                k = false;
                imya = Console.ReadLine();
                while (imya.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You can't walk without a name. Write your name/surname!");
                    imya = Console.ReadLine();
                }
                string imya2 = imya;
                for (int i = 0; i < imya2.Length; i++)
                {
                    while (imya2[i] < 'A' || (imya2[i] > 'Z' && imya2[i] < 'a') || imya2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Pishite slova tolko iz english bukvi!");
                        k = true;
                        break;
                    }
                }
            } while (k);
            return imya;
        }
        public static string nation()
        {
            string nation;
            bool k = false;
            do
            {
                k = false;
                nation = Console.ReadLine();
                while (nation.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Write your nationality!");
                    nation = Console.ReadLine();
                }
                string nation2 = nation;
                for (int i = 0; i < nation2.Length; i++)
                {
                    while (nation2[i] < 'A' || (nation2[i] > 'Z' && nation2[i] < 'a') || nation2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Pishite slova tolko iz english bukvi!");
                        k = true;
                        break;
                    }
                }
            } while (k);
            return nation;
        }
        public static int age()
        {
            string age1;
            int Age1;
            do
            {
                try
                {
                    age1 = Console.ReadLine();
                    if (!int.TryParse(age1, out Age1))
                    {
                        Console.Clear();
                        throw new Exception("Re-enter");
                    }
                    else if (Convert.ToInt32(age1) < 16)
                    {
                       throw new Exception($"Can not be! What are you, a child prodigy? ");
                    }
                    else if (Convert.ToInt32(age1) > 100)
                    {
                        throw new Exception($"You are already very old for this");
                       
                    }
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Voznihlo iskluchenie: {e.Message}");
                }
               
            } while (true);
            return Age1;
        }
        public static double weight()
        {
            string weight1;
            double Weight1;
            do
            {
                try
                {
                    weight1 = Console.ReadLine();
                    if (!double.TryParse(weight1, out Weight1))
                    {
                        Console.Clear();
                        throw new Exception("Re-enter");
                    }
                    else if (Convert.ToDouble(weight1) < 40)
                    {
                        throw new Exception("You are too thin for a student. I don't believe.");
                    }
                    else if (Convert.ToDouble(weight1) > 450)
                    {
                        throw new Exception("No human weighs that much.");
                    }
                    else break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Voznihlo iskluchenie: {e.Message}");
                }
            } while (true);
            return Weight1;
        }
        public static double height()
        {
            string height1;
            double Height1;
            do
            {
                try{ 
                height1 = Console.ReadLine();
                if (!double.TryParse(height1, out Height1))
                {
                    Console.Clear();
                        throw new Exception("Re-enter");
                }
                else if (Convert.ToDouble(height1) < 0.50 || Convert.ToDouble(height1) > 2.50)
                {
                        throw new Exception("Such growth is impossible!");
                }
                else break;
                 }
                 catch (Exception e)
                {
                    throw new Exception($"Voznihlo iskluchenie: {e.Message}");
                }
            } while (true);
            return Height1;
        }

        public void show()
        {
            Console.Clear();
            Console.WriteLine("Information about student.\nName: " + Name + "\nSurname: " + Surname + "\nNationality: " + Nationality + "\nAge: " + Age + "\nWeight: " + Weight + "\nHeight: " +
              Height /*+ "\nUniversity: " + University + "\nCourse: " + Course0 + "\nSpecialty: " + Speciality + "\n"*/);
        }
        public void rename0(ref string imya1)
        {
            Console.WriteLine("Wrtite new name");
            bool k = false;
            do
            {
                k = false;
                while ((imya1 = Console.ReadLine()).Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You can't walk without a name. Write your name/surname!");
                    imya1 = Console.ReadLine();
                }
                string imya2;
                imya2 = imya1;
                for (int i = 0; i < imya2.Length; i++)
                {
                    while (imya2[i] < 'A' || (imya2[i] > 'Z' && imya2[i] < 'a') || imya2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Pishite slova tolko iz english bukvi!");
                        k = true;
                        break;
                    }
                }
            } while (k);
        }
        public void rename(ref string imya1)
        {
            rename0(ref imya1);
            Name = imya1;
        }
        public void resurname()
        {
            Console.WriteLine("Wrtite new Surname");
            string imya1;
            bool k = false;
            do
            {
                k = false;

                while ((imya1 = Console.ReadLine()).Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You can't walk without a name. Write your name/surname!");
                    imya1 = Console.ReadLine();
                }
                string imya2;
                imya2 = imya1;
                for (int i = 0; i < imya2.Length; i++)
                {
                    while (imya2[i] < 'A' || (imya2[i] > 'Z' && imya2[i] < 'a') || imya2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Pishite slova tolko iz english bukvi!");
                        k = true;
                        break;
                    }
                }
            } while (k);
            Surname = imya1;
        }
        public void Renation()
        {
            Console.WriteLine("Wtrite another nationality: ");
            string nation1;
            bool k = false;
            do
            {
                k = false;
                nation1 = Console.ReadLine();
                while (nation1.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Write your nationality!");
                    nation1 = Console.ReadLine();
                }
                string nation2 = nation1;
                for (int i = 0; i < nation2.Length; i++)
                {
                    while (nation2[i] < 'A' || (nation2[i] > 'Z' && nation2[i] < 'a') || nation2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Pishite slova tolko iz english bukvi!");
                        k = true;
                        break;
                    }
                }
            } while (k);
            Nationality = nation1;
        }
        public void Reage()
        {
            Console.WriteLine("Age:");
            string age1;
            int Age1;
            do
            {
                age1 = Console.ReadLine();
                if (!int.TryParse(age1, out Age1))
                {
                    Console.Clear();
                    Console.WriteLine("Re-enter");
                }
                else if (Convert.ToInt32(age1) < 16)
                {
                    Console.WriteLine("Can not be! What are you, a child prodigy?");
                }
                else if (Convert.ToInt32(age1) > 100)
                {
                    Console.WriteLine("You are already very old for this(");
                }
                else break;
            } while (true);
            Age = Convert.ToInt32(age1);
        }
        public void Reweight()
        {
            Console.WriteLine("Weight: ");
            string weight1;
            double Weight1;
            do
            {
                weight1 = Console.ReadLine();
                if (!double.TryParse(weight1, out Weight1))
                {
                    Console.Clear();
                    Console.WriteLine("Re-enter");
                }
                else if (Convert.ToDouble(weight1) < 40)
                {
                    Console.WriteLine("You are too thin for a student. I don't believe.");
                }
                else if (Convert.ToDouble(weight1) > 450)
                {
                    Console.WriteLine("No human weighs that much.");
                }
                else break;
            } while (true);
            Weight = Convert.ToDouble(weight1);
        }
        public void Reheight()
        {
            Console.WriteLine("Height: ");
            string height1;
            double Height1;
            do
            {
                height1 = Console.ReadLine();
                if (!double.TryParse(height1, out Height1))
                {
                    Console.Clear();
                    Console.WriteLine("Re-enter");
                }
                else if (Convert.ToDouble(height1) < 0.50 || Convert.ToDouble(height1) > 2.50)
                {
                    Console.WriteLine("Such growth is impossible!");
                }
                else break;
            } while (true);
            Height = Convert.ToDouble(height1);
        }

        public virtual void stu()
        {
            Console.WriteLine("");
        }
        public virtual void stu(string country)
        {
            Console.WriteLine("");
        }
    }

    [Serializable]
    internal class Exeption : Exception
    {
        public Exeption()
        {
        }

        public Exeption(string message) : base(message)
        {
        }

        public Exeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Exeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}


