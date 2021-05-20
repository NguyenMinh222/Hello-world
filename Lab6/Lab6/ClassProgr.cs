using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using belarus;
using poland;
using another;
using LAB3;

namespace Lab6
{
    class ClassProgr
    {
        public static string imya1;
        static void Main()
        {
            Student s1 = new Student { Name = "Maria",Surname ="Kravchenko",Age=23 };
            Student s2 = new Student { Name = "Konstantin", Surname = "Kirilenko", Age = 23 };
            Student s3 = new Student { Name = "Lolita", Surname = "Mazurenko", Age = 23 };
            Student s4 = new Student { Name = "Anna", Surname = "Godnaya", Age = 23 };

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
                while (chislo1 < 1 || chislo1 > 3)
                {
                    Console.WriteLine("Choose the number from 1 to 3:");
                    Console.WriteLine("Where are you study? \n 1.Belarus\n 2.Poland\n 3.Another country\n");
                    Chislo1 = Console.ReadLine();
                    int.TryParse(Chislo1, out chislo1);
                }
                switch (chislo1)
                {
                    case 1:
                        Console.Clear();
                        Belarus bel = new Belarus();
                        Console.Clear();
                        bel.stu();
                        while (N == false)
                        {
                            Console.WriteLine("\nChoose the number\n1.Show Infomation abot student.\n2.Chage name.\n3.Change Surname.\n4.Change Nationality.\n" +
                            "5.Change age.\n6.Change weight.\n7.Change university.\n8.Change speciality.\n9.Change the course.\na.Change height.\nq.Compare age with other sudent.\n0. Exist\n");
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
                                case 'q':
                                    Student[] people = new Student[] { s1, s2, s3, s4,bel }; 
                                    Array.Sort(people);
                                    Console.WriteLine("\n");
                                    foreach (Student s in people)
                                    {
                                        Console.WriteLine($"{s.Name} - {s.Surname} - {s.Age}");
                                    }
                                    break;
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
                            "5.Change age.\n6.Change weight.\n7.Change university.\n8.Chnge speciality.\n9.Change the course.\na.Change height.\nq.Compare age with other sudent.\n0. Exist\n");
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
                                case 'q':
                                    Student[] people = new Student[] { s1, s2, s3, s4 , pol};
                                    Array.Sort(people);
                                    Console.WriteLine("\n");
                                    foreach (Student s in people)
                                    {
                                        Console.WriteLine($"{s.Name} - {s.Surname} - {s.Age}");
                                    }
                                    break;
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
                            "5.Change age.\n6.Change weight.\n7.Change university.\n8.Chnge speciality.\n9.Change the course.\na.Change height.\nq.Compare age with other sudent.\n0. Exist\n");
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
                                case 'q':
                                    Student[] people = new Student[] { s1, s2, s3, s4 , an};
                                    Array.Sort(people);
                                    Console.WriteLine("\n");
                                    foreach (Student s in people)
                                    {
                                        Console.WriteLine($"{s.Name} - {s.Surname} - {s.Age}");
                                    }
                                    break;
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
                foreach (var st in stude)
                {
                    st.stu();


                }

            }
        }
    

    }
}
