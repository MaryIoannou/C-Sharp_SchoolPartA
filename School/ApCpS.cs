using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class ApCpS
    {
        public Student student { get; set; }
        public List<ApC> Assigmentapcps { get; set; } = new List<ApC>();

        public ApCpS()
        {

        }

        public void InputApCpS()
        {

            Console.WriteLine("Create a student");
            student = Repository.CreateStudent();
            Repository.AddToList(Repository.AllStudents, student);            //Vazw ton student poy mou edwse mesa se olous tous students

            Console.WriteLine("se posa mathimata tha anikei o student?");
            int n;
            while (!Int32.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("try again: ");
            }
            for (int i = 0; i < n; i++)
            {
                ApC apc=Repository.CreateApC();
                Repository.AddToList(Repository.Allapc, apc);
                Repository.AddToList(Assigmentapcps, apc);
            }
        }

        public void OutputApCpS()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------STUDENTS-------");
            Console.ForegroundColor = ConsoleColor.White;
            student.OutputStudent();
            foreach (var item in Assigmentapcps)
            {
                item.OutputApC();
            }
            
        }


    }
}
