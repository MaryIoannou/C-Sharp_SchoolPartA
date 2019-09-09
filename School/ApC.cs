using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class ApC
    {
        public Course course { get; set; }

        public List<Assignment> Assigmentapc { get; set; } = new List<Assignment>();

        public ApC()
        {

        }

        public void InputApC()
        {

            Console.WriteLine("Create a course");
            course = Repository.CreateCourse();
            Repository.AddToList(Repository.AllCourses, course);            

            Console.WriteLine("How many Assigments per course do you want to insert?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Assignment assigment = Repository.CreateAssignment();
                Repository.AddToList(Repository.AllAssignments, assigment);  
                Repository.AddToList(Assigmentapc, assigment);
            }

        }

        public void OutputApC()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------COURSES-------");
            Console.ForegroundColor = ConsoleColor.White;
            course.OutputCourse();
            Repository.OutputAssignment(Assigmentapc);
        }
    }
}
