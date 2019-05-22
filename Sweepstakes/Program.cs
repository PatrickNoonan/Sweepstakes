using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes newSweepstakes;
            Console.WriteLine("Welcome! What sweepstakes would you like to enter");
            string newName = Console.ReadLine();
            newSweepstakes = new Sweepstakes(newName);
        }
    }
}
