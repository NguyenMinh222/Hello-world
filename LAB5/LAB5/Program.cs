using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using belarus;
using poland;
using another;

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
      
        public Student()
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
        }
        public virtual void stu()
        {
            Console.WriteLine("");
        }
    }
    
    class Program
    {
        public static string imya1;

        static void Main(string[] args)
        {
            bool N = false;
            bool KAK = false;
            char chislo;
            string Chislo1;
            int chislo1;
            Console.Clear();
            while (KAK == false)
            {
                Console.Clear();
                Console.WriteLine("Where are you study? \n 1.Belarus\n 2.Poland\n 3.Another country\n");
                Chislo1 = Console.ReadLine();
                int.TryParse(Chislo1, out chislo1);
                while(chislo1<1||chislo1>3){
                    Console.WriteLine("Choose the number from 1 to 3:");
                    Console.WriteLine("Where are you study? \n 1.Belarus\n 2.Poland\n 3.Another country\n");
                    Chislo1=Console.ReadLine();
                    int.TryParse(Chislo1, out chislo1);
                }
                switch(chislo1)
                {
                    case 1:
                        Console.Clear();
                        Belarus bel = new Belarus();
                        Console.Clear();
                        bel.stu();
                        while (N == false)
                  {
                          Console.WriteLine("\nChoose the number\n1.Show Infomation abot student.\n2.Chage name.\n3.Change Surname.\n4.Change Nationality.\n" +
                          "5.Change age.\n6.Change weight.\n7.Change university.\n8.Chnge speciality.\n9.Change the course.\na.Change height.\n0. Exist\n");
                          chislo = Console.ReadKey().KeyChar;
                           Console.Clear();
                    switch (chislo)
                    {
                        case '1': bel.show2(); break;
                        case '2': bel.rename(ref imya1); break;
                        case '3': bel.resurname(); break;
                        case '4': bel.Renation(); break;
                        case '5': bel.Reage(); break;
                        case '6': bel.Reweight(); break;
                        case '7': bel.Reuniversity(); break;
                        case '8': bel.Respeciality(); break;
                        case '9': bel.Recourse(); break;
                        case 'a': bel.Reheight(); break;
                        case '0': N = true; break;
                        default: break;
                    }
                   }
                        break;
                    case 2:
                        Console.Clear();
                        Poland pol = new Poland();
                        Console.Clear();
                        pol.stu();
                        while (N == false)
                        {
                            Console.WriteLine("\nChoose the number\n1.Show Infomation abot student.\n2.Chage name.\n3.Change Surname.\n4.Change Nationality.\n" +
                            "5.Change age.\n6.Change weight.\n7.Change university.\n8.Chnge speciality.\n9.Change the course.\na.Change height.\n0. Exist\n");
                            chislo = Console.ReadKey().KeyChar;
                            Console.Clear();
                            switch (chislo)
                            {
                            
                                case '1': pol.show1(); break;
                                case '2': pol.rename(ref imya1); break;
                                case '3': pol.resurname(); break;
                                case '4': pol.Renation(); break;
                                case '5': pol.Reage(); break;
                                case '6': pol.Reweight(); break;
                                case '7': pol.Reuniversity(); break;
                                case '8': pol.Respeciality(); break;
                                case '9': pol.Recourse(); break;
                                case 'a': pol.Reheight(); break;
                                case '0': N = true; break;
                                default: break;
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Another an = new Another();
                        Console.Clear();
                        an.stu();
                        while (N == false)
                        {
                            Console.WriteLine("\nChoose the number\n1.Show Infomation abot student.\n2.Chage name.\n3.Change Surname.\n4.Change Nationality.\n" +
                            "5.Change age.\n6.Change weight.\n7.Change university.\n8.Chnge speciality.\n9.Change the course.\na.Change height.\n0. Exist\n");
                            chislo = Console.ReadKey().KeyChar;
                            Console.Clear();
                            switch (chislo)
                            {
                                case '1': an.show3(); break;
                                case '2': an.rename(ref imya1); break;
                                case '3': an.resurname(); break;
                                case '4': an.Renation(); break;
                                case '5': an.Reage(); break;
                                case '6': an.Reweight(); break;
                                case '7': an.Reuniversity(); break;
                                case '8': an.Respeciality(); break;
                                case '9': an.Recourse(); break;
                                case 'a': an.Reheight(); break;
                                case '0': N = true; break;
                                default: break;
                            }
                        }
                        break;
                    default:
                        break;
                }
                var stude = new List<Student>
                {
                    new Belarus(),
                    new Poland(),
                    new Another()
                };
            foreach(var st in stude)
            {
                    st.stu();
                
                }
                
            }
        }
    }
}


