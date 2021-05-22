using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3;

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
        public Another()
        {

            Console.WriteLine("Write your university: ");
            University = Another.university();
            Console.WriteLine("Write your course: ");
            Course = Another.course();
            Console.WriteLine("Write your speciality: ");
            Speciality = Another.university();
            Console.WriteLine("Write the country in which you study: ");
            country = Another.university();
            
        }
         public  void show3()
        {
            Console.Clear();
            Console.WriteLine("Information about student.\nName: " + Name + "\nSurname: " + Surname + "\nNationality: " + Nationality + "\nAge: " + Age + "\nWeight: " + Weight + "\nHeight: " +
              Height + "\nUniversity: " + University + "\nCourse: " + Course + "\nSpecialty: " + Speciality + "\nStudy in "+country+"\n"+Another.Hobby.Artist+"\n");
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
