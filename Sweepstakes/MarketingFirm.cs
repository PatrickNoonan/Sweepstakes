using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public ISweepstakesManager queueOrStack;
        public MarketingFirm(ISweepstakesManager queueOrStack)
        {
            this.queueOrStack = queueOrStack;
        }        
    }
}
