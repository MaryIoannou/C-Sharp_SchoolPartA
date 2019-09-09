using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }



        //default constractor
        public Assignment()
        {

        }

        public Assignment(string title, string description, DateTime subdatetime, int oralmark, int totalmark)
        {
            Title = title;
            Description = description;
            SubDateTime = subdatetime;
            OralMark = oralmark;
            TotalMark = totalmark;
        }

        public void OutputAssignment()
        {
            Console.WriteLine($" {Title,-10} | {Description,10} | {SubDateTime.ToString("dd/MM/yyyy"),-10} | {OralMark,4} | {TotalMark,4}|");
        }

        private void InputTitle()
        {
            Console.WriteLine("Enter Title: ");
            Title = Console.ReadLine();
        }

        private void InputDescription()
        {
            Console.WriteLine("Give a Description: ");
            Description = Console.ReadLine();
        }

        private void InputSubDateTime()
        {
            Console.WriteLine("Enter last date of submition (E.g. 5/1/2019): ");
            DateTime day = new DateTime();
            while (!DateTime.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine(@"Enter last date of submition again(E.g. 5/1/1996): ");
            }
            SubDateTime = day;
        }

        private void InputOralMark()
        {
            Console.WriteLine("Enter her/his oral mark(0-100): ");
            int mark;
            while (!Int32.TryParse(Console.ReadLine(), out mark) || mark < 0 || mark > 100)
            {
                Console.WriteLine("Enter her/his oral mark(0-100) again: ");
            }
            OralMark = mark;
        }

        private void InputTotalMark()
        {

            Console.WriteLine("Enter her/his total mark(0-100): ");
            int mark;
            while (!Int32.TryParse(Console.ReadLine(), out mark) || mark < 0 || mark > 100)
            {
                Console.WriteLine("Enter her/his total mark again(0-100): ");
            }
            TotalMark = mark;
        }


        public void InputAssignment()
        {
            Console.WriteLine("------ASSIGNMENTS------");
            InputTitle();
            InputDescription();
            InputSubDateTime();
            InputOralMark();
            InputTotalMark();

        }







    }
}
