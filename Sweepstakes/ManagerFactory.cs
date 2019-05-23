using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerFactory
    {
        public string factoryChoice;
        public MarketingFirm newMarketingFirm;
        public SweepstakesQueueManager queueManage;
        public SweepstakesStackManager stackManage;

        public ManagerFactory()
        {            
        }
        public void SweepstakesManagerFactory()
        {
            Console.WriteLine("Would you like to manage the sweepstakes with a queue or a stack?");
            factoryChoice = Console.ReadLine();

            switch (factoryChoice)
            {
                case "queue":
                    queueManage = new SweepstakesQueueManager();
                    newMarketingFirm = new MarketingFirm(queueManage);
                    break;
                case "stack":
                    stackManage = new SweepstakesStackManager();
                    newMarketingFirm = new MarketingFirm(stackManage);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }  
        }
    }
}
