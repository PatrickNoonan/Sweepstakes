using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class UserInterface
    {
        //has this

        //constructor
        public UserInterface()
        {
            
        }

        //does this
        public void GetInfo(Contestant contestant)
        {
            Console.WriteLine("Thank you for entering the sweepstakes!");
            Console.WriteLine("Please enter your first name");
            contestant.firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            contestant.lastName = Console.ReadLine();

            Console.WriteLine("Please enter your email address");
            contestant.emailAddress = Console.ReadLine();

            Console.WriteLine("Please enter your registration number");
            contestant.registrationNum = Console.ReadLine();
        }
    }
}
