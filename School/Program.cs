using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while (option != 4)
            {
                Console.WriteLine("-------SCHOOL MENU-------");
                Console.WriteLine("Choose 1-4 for: ");
                Console.WriteLine("1.Insert data");
                Console.WriteLine("2.View data");
                Console.WriteLine("3.Synthetic data");
                Console.WriteLine("4.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        option = 0;
                        Console.WriteLine("------------insert data-------------");
                        Console.WriteLine("Choose 1-8 for: ");
                        Console.WriteLine("1.Course");
                        Console.WriteLine("2.Student");
                        Console.WriteLine("3.Trainer");
                        Console.WriteLine("4.Assigment");
                        Console.WriteLine("5.Students per course");
                        Console.WriteLine("6.Trainers per course");
                        Console.WriteLine("7.Assigments per course");
                        Console.WriteLine("8.Assigments per student");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case (1):
                                Repository.InsertCource();
                                break;
                            case (2):
                                Repository.InsertStudent();
                                break;
                            case (3):
                                Repository.InsertTrainer();
                                break;
                            case (4):
                                Repository.InsertAssignment();
                                break;
                            case (5):
                                Repository.AddToList(Repository.Allspc, Repository.CreateSpC());
                                break;
                            case (6):
                                Repository.AddToList(Repository.Alltpc, Repository.CreateTpC());
                                break;
                            case (7):
                                Repository.AddToList(Repository.Allapc, Repository.CreateApC());
                                break;
                            case (8):
                                Repository.AddToList(Repository.Allapcps, Repository.CreateApCpS());
                                break;
                            default:
                                Console.WriteLine("Something went wrong");
                                break;
                        }
                        break;
                    case 2:
                        option = 0;
                        Console.WriteLine("------------view data-------------");
                        Console.WriteLine("Choose 1-10 for: ");
                        Console.WriteLine("1.Course");
                        Console.WriteLine("2.Student");
                        Console.WriteLine("3.Trainer");
                        Console.WriteLine("4.Assigment");
                        Console.WriteLine("5.Students per course");
                        Console.WriteLine("6.Trainers per course");
                        Console.WriteLine("7.Assigments per course");
                        Console.WriteLine("8.Assigments per student");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case (1):
                                if (Repository.IsEmptyList(Repository.AllCourses))
                                    Console.WriteLine("Empty courses list,you have to insert courses first!");
                                else
                                    Repository.OutputCourse(Repository.AllCourses);
                                break;
                            case (2):
                                if (Repository.IsEmptyList(Repository.AllStudents))
                                    Console.WriteLine("Empty students list,you have to insert students first!");
                                else
                                    Repository.OutputStudent(Repository.AllStudents);
                                break;
                            case (3):
                                if (Repository.IsEmptyList(Repository.AllTrainers))
                                    Console.WriteLine("Empty trainer list,you have to insert trainer first!");
                                else
                                    Repository.OutputTrainer(Repository.AllTrainers);
                                break;
                            case (4):
                                if (Repository.IsEmptyList(Repository.AllAssignments))
                                    Console.WriteLine("Empty assigments list,you have to insert assigments first!");
                                else
                                    Repository.OutputAssignment(Repository.AllAssignments);
                                break;
                            case (5):
                                if (Repository.IsEmptyList(Repository.Allspc))
                                    Console.WriteLine("Empty students per course list,you have to insert something first!");
                                else
                                    Repository.OutputSpC(Repository.Allspc);
                                break;
                            case (6):
                                if (Repository.IsEmptyList(Repository.Alltpc))
                                    Console.WriteLine("Empty trainers per course list,you have to insert something first!");
                                else
                                    Repository.OutputTpC(Repository.Alltpc);
                                break;
                            case (7):
                                if (Repository.IsEmptyList(Repository.Allapc))
                                    Console.WriteLine("Empty assigments per course list,you have to insert something first!");
                                else
                                    Repository.OutputApC(Repository.Allapc);
                                break;
                            case (8):
                                if (Repository.IsEmptyList(Repository.Allapcps))
                                    Console.WriteLine("Empty assigments per student list,you have to insert something first!");
                                else
                                {
                                    foreach (var item in Repository.Allapcps)
                                        item.OutputApCpS();
                                }
                                break;
                            default:
                                Console.WriteLine("Something went wrong");
                                break;
                        }
                        break;
                    case 3:
                        option = 0;
                        Console.WriteLine("----------Synthetic data------------");
                        Repository.SyntheticData();
                        break;

                }

            }


        }
    }
}
