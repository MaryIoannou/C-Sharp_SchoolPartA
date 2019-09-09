using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }


        //default constractor
        public Trainer()
        {

        }

        public Trainer(string firstname, string lastname, string subject)
        {
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;


        }

        public void OutputTrainer()
        {
            Console.WriteLine($" {FirstName,-10} {LastName,-9} | {Subject,-10} |");
        }

        private void InputFirstName()
        {
            Console.WriteLine("Enter his/her First name: ");
            FirstName = Console.ReadLine();
        }

        private void InputLastName()
        {
            Console.WriteLine("Enter his/her Last name: ");
            LastName = Console.ReadLine();
        }

        private void InputSubject()
        {
            Console.WriteLine("Enter the subject that you will teach: ");
            Subject = Console.ReadLine();
        }



        public void InputTrainer()
        {
            Console.WriteLine("------TRAINERS------");
            InputFirstName();
            InputLastName();
            InputSubject();


        }





    }
}
