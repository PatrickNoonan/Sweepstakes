using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //has this
        public Dictionary<string, string> contestantInfo;
        public UserInterface newUserInterface;

        //constructor
        public Sweepstakes(string name)
        {
            newUserInterface = new UserInterface();
            Contestant newContestant = new Contestant();
            RegisterContestant(newContestant);

        }

        //does this
        public void RegisterContestant(Contestant contestant)
        {
            newUserInterface.GetInfo(contestant);
            PrintContestantInfo(contestant);
            
        }
        public string PickWinner()
        {
            return "";
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            contestantInfo.Add("First Name: ", contestant.firstName);
            contestantInfo.Add("Last Name: ", contestant.lastName);
            contestantInfo.Add("Email Address: ", contestant.emailAddress);
            contestantInfo.Add("Registration Number: ", contestant.registrationNum);


            foreach (KeyValuePair<string, string> entry in contestantInfo)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
