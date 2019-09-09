using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SpC
    {
        public Course course { get; set; }

        public List<Student> Studentspc { get; set; }  = new List<Student>();

        public SpC()
        {

        }

        public void InputSpC()
        {
            
            Console.WriteLine("Create a course");
            course =Repository.CreateCourse();
            Repository.AddToList(Repository.AllCourses, course);           
            
            Console.WriteLine("How many Students per course do you want to insert?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student student=Repository.CreateStudent();
                Repository.AddToList(Repository.AllStudents, student);    
                Repository.AddToList(Studentspc,student);
            }
            
        }

        public void OutputSpC()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------COURSES-------");
            Console.ForegroundColor = ConsoleColor.White;
            course.OutputCourse();
            Repository.OutputStudent(Studentspc);
        }
        
    }
}
