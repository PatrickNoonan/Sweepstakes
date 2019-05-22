using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public string factoryChoice;
        public MarketingFirm(SweepstakesStackManager queue, SweepstakesStackManager stack)
        {
            Console.WriteLine("Would you like to manage the sweepstakes with a queue or a stack?");
            factoryChoice = Console.ReadLine();

            switch (factoryChoice)
            {
                case "queue":
                    factoryStyle(queue);
                    break;
                case "stack":
                    factoryStyle(stack);
                    break;
                default:
                    Console.WriteLine("meh");
                    break;
            }
        }

        public void factoryStyle(SweepstakesStackManager queueOrStack)
        {
            queueOrStack.GetSweepstakes();
        }
    }
}
