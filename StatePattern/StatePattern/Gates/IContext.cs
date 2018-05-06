using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    interface IContext
    {
        int PeoplePassed { get; set; }
        void PaySuccess();
        void PayFail();
        void EnterThru();
        void ChangeState(IGateState state);
    }
}
