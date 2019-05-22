using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQeueManager : ISweepstakesManager
    {
        //has this
        public Queue<Sweepstakes> sweepQueue;

        //ctor
        public SweepstakesQeueManager()
        {
            sweepQueue = new Queue<Sweepstakes>();
        }

        //does this
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepQueue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepQueue.Dequeue();
        }
    }
}
