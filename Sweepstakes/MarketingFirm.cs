using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public MarketingFirm(SweepstakesStackManager qeue, SweepstakesStackManager stack)
        {
            qeue.GetSweepstakes();
            stack.GetSweepstakes();
        }
    }
}
