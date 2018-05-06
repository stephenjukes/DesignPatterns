using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class ClosedState : IGateState
    {
        IContext _gate;

        public ClosedState(IContext gate)
        {
            _gate = gate;
        }

        public void PayOk()
        {
            Console.WriteLine("Light turns green:\tProceed to Enter.");
            _gate.ChangeState(new OpenState(_gate));
        }

        public void PayFail()
        {
            Console.WriteLine("Light remains red:\tInsufficient funds.");
        }

        public void Enter()
        {
            Console.WriteLine("Light remains red:\tCannot enter while closed");
        }
    }
}
