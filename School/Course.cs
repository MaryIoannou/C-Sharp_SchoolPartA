using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{

    public class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
       

        //default constractor
        public Course()
        {

        }

        public Course(string title, string steam, string type, DateTime startdate, DateTime enddate)
        {
            Title = title;
            Stream = steam;
            Type = type;
            StartDate = startdate;
            EndDate = enddate;
            
        }


        public void OutputCourse()
        {
            Console.WriteLine($"{Title,-13} | {Stream,-9} | {Type,-4} | {StartDate.ToString("dd/MM/yyyy"),-10} | {EndDate.ToString("dd/MM/yyyy"),-10} |");
        }

        private void InputTitle()
        {
            Console.WriteLine("Enter Title: ");
            Title = Console.ReadLine();
        }

        private void InputStream()
        {
            Console.WriteLine("Press 1 for Full time or 2 for Part time: ");
            int st;
            while (!Int32.TryParse(Console.ReadLine(), out st) || (st != 1 && st != 2))
            {
                Console.WriteLine("Press 1 for Full time or 2 for Part time again: ");
            }
            if (st == 1)
                Stream = "Full time";
            else
                Stream = "Part time";
        }

        private void InputType()
        {
            Console.WriteLine("Press 1 for Java or 2 for C#: ");
            int t;
            while (!Int32.TryParse(Console.ReadLine(), out t) || (t != 1 && t != 2))
            {
                Console.WriteLine("Press 1 for Java or 2 for C# again: ");
            }
            if (t == 1)
                Type = "Java";
            else
                Type = "C#";
        }

        private void InputStartDate()
        {
            Console.WriteLine("Enter start date (E.g. 5/1/2019): ");
            DateTime day1 = new DateTime();
            while (!DateTime.TryParse(Console.ReadLine(), out day1) && day1 < DateTime.Now)
            {
                Console.WriteLine(@"Enter start date again (E.g. 5/1/1996): ");
            }
            StartDate = day1;
        }

        private void InputEndDate()
        {
            Console.WriteLine("Enter end date: ");
            DateTime day2 = new DateTime();
            while (!DateTime.TryParse(Console.ReadLine(), out day2) && StartDate <= day2)
            {
                Console.WriteLine(@"Enter end date again (E.g. 5/1/2019): ");
            }
            EndDate = day2;
        }

        public void InputCourse()
        {
            Console.WriteLine("------COURSES------");
            InputTitle();
            InputStream();
            InputType();
            InputStartDate();
            InputEndDate();

        }

    }
}
