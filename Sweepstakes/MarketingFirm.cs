using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm : IManage
    {
        public string factoryChoice;
        public ISweepstakesManager queueOrStack;
        public MarketingFirm(ISweepstakesManager queueOrStack)
        {
            this.queueOrStack = queueOrStack;
        }

        public void SweepstakesManagerFactory()
        {
            Console.WriteLine("Would you like to manage the sweepstakes with a queue or a stack?");
            factoryChoice = Console.ReadLine();

            switch (factoryChoice)
            {
                case "queue":
                    queueOrStack = new SweepstakesQueueManager();
                    break;
                case "stack":
                    queueOrStack = new SweepstakesStackManager();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
