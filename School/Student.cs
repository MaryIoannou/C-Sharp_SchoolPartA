using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        


        //default constractor
        public Student()
        {

        }

        public Student(string firstname, string lastname, DateTime dateofbirth, int tuitionfees)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            TuitionFees = tuitionfees;
            
        }

        public void OutputStudent()
        {
            Console.WriteLine($" {FirstName,-10} {LastName,-9} | {DateOfBirth.ToString("dd / MM / yyyy"),-10} | {TuitionFees,-7} |");
        }

        private void InputFirstName()
        {
            Console.WriteLine("Enter her/his First name: ");
            FirstName = Console.ReadLine();

        }

        private void InputLastName()
        {
            Console.WriteLine("Enter her/his Last name: ");
            LastName = Console.ReadLine();

        }
        private void InputDateOfBirth()
        {
            Console.WriteLine(@"Enter her/his date of birth: ");
            DateTime day = new DateTime();
            while (!DateTime.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine(@"Enter her/his date of birth again(E.g. 5/1/2019): ");
            }
            DateOfBirth = day;
        }

        private void InputTuitionFees()
        {
            Console.WriteLine(@"Enter her/his tuition fees(0-5000): ");
            int tf;
            while (!Int32.TryParse(Console.ReadLine(), out tf) || tf < 0 || tf > 5000)
            {
                Console.WriteLine(@"Enter her/his tuition fees again(0-5000): ");
            }
            TuitionFees = tf;
        }



        public void InputStudent()
        {
            Console.WriteLine("------STUDENTS------");
            InputFirstName();
            InputLastName();
            InputDateOfBirth();
            InputTuitionFees();

        }
    }
}
