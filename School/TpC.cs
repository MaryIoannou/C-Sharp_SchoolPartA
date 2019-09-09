using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TpC
    {
        public Course course { get; set; }

        public List<Trainer> Trainertpc { get; set; } = new List<Trainer>();

        public TpC()
        {

        }

        public void InputTpC()
        {

            Console.WriteLine("Create a course");
            course = Repository.CreateCourse();
            Repository.AddToList(Repository.AllCourses, course);           //Vazw to course poy mou edwse mesa se ola ta courses

            Console.WriteLine("How many Trainers per course do you want to insert?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Trainer trainer = Repository.CreateTrainer();
                Repository.AddToList(Repository.AllTrainers,trainer);     //Vazw ton trainer poy mou edwse mesa se olous tous trainers
                Repository.AddToList(Trainertpc,trainer);
            }

        }

        public void OutputTpC()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------COURSES-------");
            Console.ForegroundColor = ConsoleColor.White;
            course.OutputCourse();
            Repository.OutputTrainer(Trainertpc);
        }
    }
}
