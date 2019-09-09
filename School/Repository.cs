using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Repository
    {
        public static List<Course> AllCourses = new List<Course>();
        public static List<Student> AllStudents = new List<Student>();
        public static List<Trainer> AllTrainers = new List<Trainer>();
        public static List<Assignment> AllAssignments = new List<Assignment>();
        public static List<SpC> Allspc = new List<SpC>();
        public static List<TpC> Alltpc = new List<TpC>();
        public static List<ApC> Allapc = new List<ApC>();
        public static List<ApCpS> Allapcps = new List<ApCpS>();

        public static void AddToList<T>(List<T> list, T ob)
        {
            list.Add(ob);

        }

        public static bool IsEmptyList<T>(List<T> list)
        {
            if (list.Count == 0)
                return true;
            else
                return false;
        }

        public static Course CreateCourse()
        {
            Course c = new Course();
            c.InputCourse();
            return c;
        }

        public static Student CreateStudent()
        {
            Student s = new Student();
            s.InputStudent();
            return s;
        }

        public static Trainer CreateTrainer()
        {
            Trainer t = new Trainer();
            t.InputTrainer();
            return t;
        }

        public static Assignment CreateAssignment()
        {
            Assignment a = new Assignment();
            a.InputAssignment();
            return a;
        }

        public static SpC CreateSpC()
        {
            SpC spc = new SpC();
            spc.InputSpC();
            return spc;
        }

        public static TpC CreateTpC()
        {
            TpC tpc = new TpC();
            tpc.InputTpC();
            return tpc;
        }

        public static ApC CreateApC()
        {
            ApC apc = new ApC();
            apc.InputApC();
            return apc;
        }

        public static ApCpS CreateApCpS()
        {
            ApCpS apcps = new ApCpS();
            apcps.InputApCpS();
            return apcps;

        }

        public static void InsertCource()
        {
            Console.WriteLine("How many courses do you want to insert?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Course course = CreateCourse();
                AddToList(AllCourses, course);
            }
        }

        public static void InsertStudent()
        {
            Console.WriteLine("How many students do you want to insert?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student student = CreateStudent();
                AddToList(AllStudents, student);
            }

        }

        public static void InsertTrainer()
        {
            Console.WriteLine("How many trainers do you want to insert?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Trainer trainer = CreateTrainer();
                AddToList(AllTrainers, trainer);
            }

        }

        public static void InsertAssignment()
        {
            Console.WriteLine("How many assigments do you want to insert?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Assignment assigment = CreateAssignment();
                AddToList(AllAssignments, assigment);
            }

        }
        public static void OutputCourse(List<Course> lista)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------COURSES-------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----Title-----+---Stream--+-Type-+-StartDate--+---EndDate--+");

            foreach (var item in lista)
            {
                Console.WriteLine("--------------+-----------+------+------------+------------+");
                item.OutputCourse();
            }
            Console.WriteLine("--------------+-----------+------+------------+------------+");

        }

        public static void OutputStudent(List<Student> lista)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------STUDENTS-------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-FirstName---LastName-+--DateOfBirth---+TuitionFees+");
            foreach (var item in lista)
            {
                Console.WriteLine("----------------------+----------------+---------+");
                item.OutputStudent();
            }
            Console.WriteLine("----------------------+----------------+---------+");
        }

        public static void OutputTrainer(List<Trainer> lista)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------TRAINERS-------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-FirstName---LastName-+---Subject--+");
            foreach (var item in lista)
            {
                Console.WriteLine("----------------------+------------+");
                item.OutputTrainer();
            }
            Console.WriteLine("----------------------+------------+");


        }

        public static void OutputAssignment(List<Assignment> lista)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------ASSIGNMENTS-------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---Title----+-Description+-SubDateTime+-OrM--+-TotM+");
            foreach (var item in lista)
            {
                Console.WriteLine("------------+------------+------------+------+-----+");
                item.OutputAssignment();
            }
            Console.WriteLine("------------+------------+------------+------+-----+");

        }

        public static void OutputSpC(List<SpC> lista)
        {
            Console.WriteLine("------STUDENTs PER COURSE-------");
            foreach (var item in lista)
            {
                item.OutputSpC();
            }

        }

        public static void OutputTpC(List<TpC> lista)
        {
            Console.WriteLine("------TREINERS PER COURSE-------");
            foreach (var item in lista)
            {
                item.OutputTpC();
            }

        }

        public static void OutputApC(List<ApC> lista)
        {
            Console.WriteLine("------ASSIGNMETS PER COURSE-------");
            foreach (var item in lista)
            {
                item.OutputApC();
            }

        }

        public static List<Student> StudentsBelongtoMul(List<ApCpS> lista)
        {
            List<Student> StudentsMul = new List<Student>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Assigmentapcps.Count>1)
                {
                    StudentsMul.Add(lista[i].student);
                }
                
            }
            return StudentsMul;
        }

        public static List<Student> StudentsSubSameWeek(List <ApCpS> list)
        {
            List<Student> StudentsSubSameWeek = new List<Student>();
            List<DateTime> week = new List<DateTime>();
            DateTime day = new DateTime();
            Console.WriteLine("Enter date: ");
            day = Convert.ToDateTime(Console.ReadLine());
            while (!(day.DayOfWeek.ToString() == "Monday"))
                day = day.AddDays(-1);
            
            for (int i = 0; i <= 4; i++)
            {
                week.Add(day);
                day = day.AddDays(1);
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Assigmentapcps.Count; j++)
                {
                    for (int n = 0; n < list[i].Assigmentapcps[j].Assigmentapc.Count; n++)
                    {
                        if (week.Contains(list[i].Assigmentapcps[j].Assigmentapc[n].SubDateTime))
                        {
                            if (!StudentsSubSameWeek.Contains(list[i].student))
                            {
                                StudentsSubSameWeek.Add(list[i].student);
                            }
                        }
                    }
                }
            }
            return StudentsSubSameWeek;

        } 

        public static void SyntheticData()
        {
            DateTime date1 = new DateTime(2019, 6, 19);
            DateTime date2 = new DateTime(2019, 6, 18);
            DateTime date3 = new DateTime(2019, 6, 17);
            DateTime date4 = new DateTime(2019, 6, 21);

            //Courses
            Course c1 = new Course("CB1", "part time", "c#", date3, date4);
            Course c2 = new Course("CB2", "full time", "JAVA", date3, date4);
            Course c3 = new Course("CB3", "full time", "c#", date3, date4);
            Course c4 = new Course("CB4", "part time", "c#", date3, date4);

            List<Course> Courses = new List<Course>();
            Courses.Add(c1);
            Courses.Add(c2);
            Courses.Add(c3);
            Courses.Add(c4);

            //Students
            Student s1 = new Student("Mairi", "Ioannou", date4, 2500);
            Student s2 = new Student("Xristos", "Xristou", date2, 0);
            Student s3 = new Student("Gewrgios", "Gewrgioy", date3, 2200);
            Student s4 = new Student("Panos", "Panou", date2, 2250);

            List<Student> Students = new List<Student>();
            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);

            //Trainers
            Trainer t1 = new Trainer("Argirhs", "Pagidas", "python");
            Trainer t2 = new Trainer("Ektoras", "Gkatsos", "data base");
            Trainer t3 = new Trainer("Georgios", "Tzoras", "html");
            Trainer t4 = new Trainer("Giannhs", "Pappas", "sql");

            List<Trainer> Trainers = new List<Trainer>();
            Trainers.Add(t1);
            Trainers.Add(t2);
            Trainers.Add(t3);
            Trainers.Add(t4);

            //Assignmets
            Assignment a1 = new Assignment("project1", "part A", date1, 52, 36);
            Assignment a2 = new Assignment("project2", "part A", date2, 64, 22);
            Assignment a3 = new Assignment("project3", "part A", date3, 58, 24);
            Assignment a4 = new Assignment("project4", "part A", date4, 40, 40);

            List<Assignment> Assigments = new List<Assignment>();
            Assigments.Add(a1);
            Assigments.Add(a2);
            Assigments.Add(a3);
            Assigments.Add(a4);

            OutputCourse(Courses);
            OutputStudent(Students);
            OutputTrainer(Trainers);
            OutputAssignment(Assigments);

            //SpC
            
            List<Student> Students1 = new List<Student>();
            Students1.Add(s1);
            Students1.Add(s2);
            List<Student> Students2 = new List<Student>();
            Students2.Add(s3);
            Students2.Add(s4);

            SpC spc1 = new SpC();
            spc1.course = c1;
            spc1.Studentspc = Students1;

            SpC spc2 = new SpC();
            spc2.course = c2;
            spc2.Studentspc = Students2;

            List<SpC> SpC = new List<SpC>();
            AddToList(SpC, spc1);
            AddToList(SpC, spc2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------STUDENTS   PER   COURSE-----------");
            foreach (var item in SpC)
                item.OutputSpC();

            //TpC

            List<Trainer> Trainers1 = new List<Trainer>();
            Trainers1.Add(t1);
            Trainers1.Add(t2);
            List<Trainer> Trainers2 = new List<Trainer>();
            Trainers2.Add(t3);
            Trainers2.Add(t4);

            TpC tpc1 = new TpC();
            tpc1.course = c3;
            tpc1.Trainertpc = Trainers1;
            TpC tpc2 = new TpC();
            tpc2.course = c4;
            tpc2.Trainertpc = Trainers2;

            List<TpC> TpC = new List<TpC>();
            AddToList(TpC, tpc1);
            AddToList(TpC, tpc2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------TRAINERS   PER   COURSE-----------");
            foreach (var item in TpC)
                item.OutputTpC();

            //ApC

            List<Assignment> Assignmets1 = new List<Assignment>();
            Assignmets1.Add(a1);
            Assignmets1.Add(a2);
            List<Assignment> Assignmets2 = new List<Assignment>();
            Assignmets2.Add(a3);
            Assignmets2.Add(a4);

            ApC apc1 = new ApC();
            apc1.course = c1;
            apc1.Assigmentapc = Assignmets1;
            ApC apc2 = new ApC();
            apc2.course = c3;
            apc2.Assigmentapc = Assignmets2;

            List<ApC> ApC = new List<ApC>();
            AddToList(ApC, apc1);
            AddToList(ApC, apc2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------ASSIGNMETS   PER   COURSE-----------");
            foreach (var item in ApC)
                item.OutputApC();

            //ApCpS


            List<Assignment> ass2= new List<Assignment>();
            ass2.Add(a2);
            ass2.Add(a3);
            ApC apc4 = new ApC();          //1o
            apc4.course = c4;
            apc4.Assigmentapc = ass2;

            ApC apc3 = new ApC();           //2o
            apc3.course = c3;
            apc3.Assigmentapc = Assignmets1;

            ApCpS apcps1 = new ApCpS();
            apcps1.student = s1;
            apcps1.Assigmentapcps.Add(apc4);
            apcps1.Assigmentapcps.Add(apc3);

            ApCpS apcps2 = new ApCpS();
            apcps2.student = s3;
            apcps2.Assigmentapcps.Add(apc3);

            List<ApCpS> APCPC = new List<ApCpS>();
            APCPC.Add(apcps1);
            APCPC.Add(apcps2);

            Console.WriteLine("------ASSIGNMETS   PER   STUDENTS-----------");
            foreach (var item in APCPC)
                item.OutputApCpS();

            Console.WriteLine();
            Console.WriteLine("---------students in multiple courses-------");
            var list= StudentsBelongtoMul(APCPC);
            OutputStudent(list);

            Console.WriteLine("---------students with assignment this calendar week-------");
            Console.WriteLine(@"dokimase me 21/6 :)");
            var lista = StudentsSubSameWeek(APCPC);
            OutputStudent(lista);

        }
    }
}
