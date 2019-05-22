using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //has this
        public Stack<Sweepstakes> sweepStack;

        //ctor
        public SweepstakesStackManager()
        {
            sweepStack = new Stack<Sweepstakes>();
        }

        //does this
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepStack.Pop();
        }
    }
}
