using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Student
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Nationality { get; set; }
        protected int Age { get; set; }
        protected double Weight { get; set; }
        protected double Height { get; set; }
        protected string University { get; set; }
        protected int Course { get; set; }
        protected string Speciality { get; set; }
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
            return Age1;
        }
        public static double weight()
        {
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
            return Weight1; 
        }
        public static double height()
        {
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
            return Height1;
        }
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
                while (university.Length == 0 )
                {
                    Console.Clear();
                    Console.WriteLine("Re-entry");
                    university = Console.ReadLine();
                }
                for (int i = 0; i < university.Length; i++)
                {
                    while ( university[0]==' ')
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
        public void show()
        {
            Console.Clear();
            Console.WriteLine("Information about student.\nName: " + Name + "\nSurname: " + Surname + "\nNationality: " + Nationality + "\nAge: "+Age+"\nWeight: "+Weight+"\nHeight: "+
              Height+"\nUniversity: "+University+"\nCourse: "+Course+"\nSpecialty: "+Speciality+"\n");
        }
        public void rename0(ref string imya1)
        {
            Console.WriteLine("Wrtite new name");
            bool k = false;
            do
            {
                k = false;
                while ((imya1=Console.ReadLine()).Length == 0)
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
        public void rename(ref string  imya1)
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
        public Student()
            {
                Console.WriteLine("Write your Name: ");
                Name = Student.Imya();
                Console.WriteLine("Write your Surname: ");
               /* Surname = Student.Imya();
                Console.WriteLine("Write your Nationality: ");
                Nationality = Student.nation();
                Console.WriteLine("Write your Age: ");
                Age = Student.age();
                Console.WriteLine("Write your Weight: ");
                Weight = (int)Student.weight();
                Console.WriteLine("Write your Height in m(for example 1,89): ");
                Height = (int)Student.height();
                Console.WriteLine("Write your University: ");
                University = Student.university();
                Console.WriteLine("Write your Course: ");
                Course = Student.course();
                Console.WriteLine("Write your Speciality: ");
                Speciality = Student.university();*/
            }
    }
    class Program
    {
        public static string imya1;

        static void Main(string[] args)
        {
            Student st = new Student();
            bool N = false;
            char chislo;
            Console.Clear();
            while(N==false)
            {
                Console.WriteLine("\nChoose the number\n1.Show Infomation abot student.\n2.Chage name.\n3.Change Surname.\n4.Change Nationality.\n" +
                    "5.Change age.\n6.Change weight.\n7.Change university.\n8.Chnge speciality.\n9.Change the course.\na.Change height.\n0. Exist\n");
                chislo=Console.ReadKey().KeyChar;
                Console.Clear();
                switch (chislo)
                {
                    case '1': st.show(); break;
                    case '2': st.rename(ref imya1); break;
                    case '3': st.resurname(); break;
                    case '4': st.Renation(); break;
                    case '5': st.Reage(); break;
                    case '6': st.Reweight(); break;
                    case '7': st.Reuniversity(); break;
                    case '8': st.Respeciality(); break;
                    case '9': st.Recourse(); break;
                    case 'a': st.Reheight();break;
                    case '0': N = true; break;
                    default: break;
                }
            }
        }
    }
}


