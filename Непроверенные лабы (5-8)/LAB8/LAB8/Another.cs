using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3;
using LAB8;
namespace another
{
    class Another : Student
    {
        protected string University { get; set; }
        protected int Course { get; set; }
        protected string Speciality { get; set; }
        protected string country { get; set; }
        public static string university()
        {
            StringBuilder _University;
            string university;
            bool k = false;
            do
            {
                k = false;
                _University = new StringBuilder(Console.ReadLine());
                university = _University.ToString();
                while (university.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Re-entry");
                    university = Console.ReadLine();
                }
                for (int i = 0; i < university.Length; i++)
                {
                    while (university[0] == ' ')
                    {
                        Console.Clear();
                        Console.WriteLine("Re-entry");
                        university = Console.ReadLine();
                    }
                }
                for (int i = 0; i < university.Length; i++)
                {
                    if (university[i] < ' ' || (university[i] > ' ' && university[i] < '-') || (university[i] > '-' && university[i] < 'A') || (university[i] > 'Z' && university[i] < 'a') || university[i] > 'z')
                    {
                        Console.WriteLine("Pishite slova tolko iz english bukv!");
                        Console.Clear();
                        k = true;
                        break;
                    }
                }
            } while (k);
            string[] Stroka2 = university.Split(' ');//Delim stroku na massiv podstrok 
            for (int i = 0; i < Stroka2.Length; i++)
            {
                if (Stroka2[i] != "")
                {
                    Console.Write(Stroka2[i] + " ");
                }
            }
            Console.WriteLine();
            return university;
        }

        public static int course()
        {
            int course;
            string Course;
            do
            {
                Course = Console.ReadLine();
                if (!int.TryParse(Course, out course))
                {
                    Console.Clear();
                    Console.WriteLine("Re-entry\nWrite your course: ");
                }
                else if (Convert.ToInt32(Course) < 1 || Convert.ToInt32(Course) > 5)
                {
                    Console.Clear();
                    Console.WriteLine("You're not a student!");
                    Console.WriteLine("Re-entry\nWrite your course: ");
                }
                else break;
            } while (true);
            return course;
        }
        public void Reuniversity()
        {
            Console.WriteLine("University: ");
            StringBuilder _University;
            string university;
            bool k = false;
            do
            {
                k = false;
                _University = new StringBuilder(Console.ReadLine());
                university = _University.ToString();
                while (university.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Re-entry");
                    university = Console.ReadLine();
                }
                for (int i = 0; i < university.Length; i++)
                {
                    while (university[0] == ' ')
                    {
                        Console.Clear();
                        Console.WriteLine("Re-entry");
                        university = Console.ReadLine();
                    }
                }
                for (int i = 0; i < university.Length; i++)
                {
                    if (university[i] < ' ' || (university[i] > ' ' && university[i] < '-') || (university[i] > '-' && university[i] < 'A') || (university[i] > 'Z' && university[i] < 'a') || university[i] > 'z')
                    {
                        Console.WriteLine("Pishite slova tolko iz english bukv!");
                        Console.Clear();
                        k = true;
                        break;
                    }
                }
            } while (k);
            string[] Stroka2 = university.Split(' ');//Delim stroku na massiv podstrok 
            for (int i = 0; i < Stroka2.Length; i++)
            {
                if (Stroka2[i] != "")
                {
                    Console.Write(Stroka2[i] + " ");
                }
            }
            Console.WriteLine();
            University = university;
        }
        public void Recourse()
        {
            Console.WriteLine("Course: ");
            int course;
            string Course1;
            do
            {
                Course1 = Console.ReadLine();
                if (!int.TryParse(Course1, out course))
                {
                    Console.Clear();
                    Console.WriteLine("Re-entry\nWrite your course: ");
                }
                else if (Convert.ToInt32(Course1) < 1 || Convert.ToInt32(Course1) > 5)
                {
                    Console.Clear();
                    Console.WriteLine("You're not a student!");
                    Console.WriteLine("Re-entry\nWrite your course: ");
                }
                else break;
            } while (true);
            Course = Convert.ToInt32(Course);
        }
        public void Respeciality()
        {
            Console.WriteLine("Speciality: ");
            StringBuilder _University;
            string university;
            bool k = false;
            do
            {
                k = false;
                _University = new StringBuilder(Console.ReadLine());
                university = _University.ToString();
                while (university.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Re-entry");
                    university = Console.ReadLine();
                }
                for (int i = 0; i < university.Length; i++)
                {
                    while (university[0] == ' ')
                    {
                        Console.Clear();
                        Console.WriteLine("Re-entry");
                        university = Console.ReadLine();
                    }
                }
                for (int i = 0; i < university.Length; i++)
                {
                    if (university[i] < ' ' || (university[i] > ' ' && university[i] < '-') || (university[i] > '-' && university[i] < 'A') || (university[i] > 'Z' && university[i] < 'a') || university[i] > 'z')
                    {
                        Console.WriteLine("Pishite slova tolko iz english bukv!");
                        Console.Clear();
                        k = true;
                        break;
                    }
                }
            } while (k);
            string[] Stroka2 = university.Split(' ');//Delim stroku na massiv podstrok 
            for (int i = 0; i < Stroka2.Length; i++)
            {
                if (Stroka2[i] != "")
                {
                    Console.Write(Stroka2[i] + " ");
                }
            }
            Console.WriteLine();
            Speciality = university;
        }
        public enum Hobby
        {
            Football_player,
            Basket_player,
            Chess_player,
            Dancer,
            Fighter,
            Artist
        }
        string A, B,C,D;
        int a, b,c,d;
        public Another()
        {
            Console.WriteLine("Write your Name: ");
            Name = Student.Imya();
            Console.WriteLine("Write your Surname: ");
            Surname = Student.Imya();
            Console.WriteLine("Write your Nationality: ");
            Nationality = Student.nation();
            Console.WriteLine("Write your Age: ");
            Age = Student.age();
            Console.WriteLine("Write your Weight: ");
            Weight = (int)Student.weight();
            Console.WriteLine("Write your Height in m(for example 1,89): ");
            Height = (int)Student.height();
            Console.WriteLine("Write your university: ");
            University = Another.university();
            Console.WriteLine("Write your course: ");
            Course = Another.course();
            Console.WriteLine("Write your speciality: ");
            Speciality = Another.university();
            Console.WriteLine("Write the country in which you study: ");
            country = Another.university();

            Console.WriteLine("How much money do you have?");
            A = Console.ReadLine();
            Console.WriteLine("How much money did you pay for your study?");
            B = Console.ReadLine();
            int.TryParse(A, out a);
            int.TryParse(B, out b);

        }
        public void show3()
        {
            Console.Clear();
            Console.WriteLine("Information about student.\nName: " + Name + "\nSurname: " + Surname + "\nNationality: " + Nationality + "\nAge: " + Age + "\nWeight: " + Weight + "\nHeight: " + "m" +
              Height + "\nUniversity: " + University + "\nCourse: " + Course + "\nSpecialty: " + Speciality + "\nStudy in " + country + "\n" + Another.Hobby.Artist + "\n");
            Money mon = new Money(Convert.ToInt32(a));
            mon.notify += delegate (string mess)// anonim method
            {
                Console.WriteLine(mess);
            };
            mon.notify1 += mess => Console.WriteLine(mess);// lyambda methods
            mon.Have(Convert.ToInt32(a));
            Console.WriteLine($"Na vashem schete: {mon.Oplata}");
            mon.Oplacheno(Convert.ToInt32(b));
            Console.WriteLine($"Obnovleno\nNa vashem schete: {mon.Oplata}");
            if (c > 0)
            {
                mon.notify1 += mess => Console.WriteLine(mess);
                mon.Popolnenie(Convert.ToInt32(c));
                Console.WriteLine($"Obnovleno\nNa vashem schete: {mon.Oplata}$");
            }
            if (d > 0)
            {
                mon.notify1 += mess => Console.WriteLine(mess);
                mon.Oplacheno(Convert.ToInt32(d));
                Console.WriteLine($"Obnovleno\nNa vashem schete: {mon.Oplata}$");
            }
        }
        public void Popol()
        {
            Console.Write("Vvedite summu for popolneniya: ");
            C = Console.ReadLine();
            int.TryParse(C, out c);

            Money mon = new Money(Convert.ToInt32(a - b));
            mon.notify1 += mess => Console.WriteLine(mess);//lyambda method
            mon.Popolnenie(Convert.ToInt32(c));
        }
        public void Zaplatit()
        {
            Console.Write("Vvedite summu which you wwant to oplatit: ");
            D = Console.ReadLine();
            int.TryParse(D, out d);
            if (a - b < 0)
            {
                Money mon = new Money(Convert.ToInt32(a + c));
                mon.notify += mess => Console.WriteLine(mess);//lyambda method
                mon.Oplacheno(Convert.ToInt32(d));
            }
            else
            {
                Money mon = new Money(Convert.ToInt32(a - b + c));
                mon.notify += mess => Console.WriteLine(mess);//lyambda method
                mon.Oplacheno(Convert.ToInt32(d));

            }
        }
        public override void stu()
        {
            Console.WriteLine("He study in ");
            base.stu();
        }
        public override void stu(string country)
        {
            Console.WriteLine("He study in " + country);
            base.stu();
        }

    }
    class Program
    {
        private static void boi()
        {
            Another another1 = new Another();
            another1.stu();
            another1.stu("Poland");


        }
    }

}
