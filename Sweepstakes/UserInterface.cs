using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        //has this
        public Contestant NewConstestant;

        //constructor
        public UserInterface()
        {
            
        }

        //does this
        public void GetInfo()
        {
            NewConstestant = new Contestant();
            Console.WriteLine("Thank you for entering the sweepstakes!");
            Console.WriteLine("Please enter your first name");
            NewConstestant.firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            NewConstestant.lastName = Console.ReadLine();

            Console.WriteLine("Please enter your email address");
            NewConstestant.emailAddress = Console.ReadLine();

            Console.WriteLine("Please enter your registration number");
            NewConstestant.registrationNum = Convert.ToInt32(Console.ReadLine());
        }
    }
}
