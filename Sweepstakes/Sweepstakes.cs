using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //has this
        public Dictionary<string, string> contestantInfo;
        public UserInterface newUserInterface;
        public Random random = new Random();

        //constructor
        public Sweepstakes(string name)
        {
            contestantInfo = new Dictionary<string, string>();
            newUserInterface = new UserInterface();
            Contestant newContestant = new Contestant();
            RegisterContestant(newContestant);
        }

        //does this
        public void RegisterContestant(Contestant contestant)
        {
            newUserInterface.GetInfo(contestant);
            contestantInfo.Add("First Name: ", contestant.firstName);
            contestantInfo.Add("Last Name: ", contestant.lastName);
            contestantInfo.Add("Email Address: ", contestant.emailAddress);
            contestantInfo.Add("Registration Number: ", contestant.registrationNum);
            PickWinner();
            PrintContestantInfo(contestant);            
        }
        public string PickWinner()
        {
           int rand = random.Next(0, 100);
            if (Convert.ToInt32(contestantInfo["Registration Number: "]) == rand)
            {
                Console.WriteLine($"Contest number {rand} is the winner!");
            }
            try
            {
                return contestantInfo["FirstName: "] + " " + contestantInfo["Last Name: "];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"There is no contestant with the registration number of {rand}");
                Console.ReadLine();
                return "";
            }
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<string, string> entry in contestantInfo)
            {
                Console.WriteLine(entry);
            }
            Console.ReadLine();
        }
    }
}