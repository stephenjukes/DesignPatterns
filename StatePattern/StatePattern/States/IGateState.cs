using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    interface IGateState
    { 
        void PayOk();
        void PayFail();
        void Enter();
    }
}
