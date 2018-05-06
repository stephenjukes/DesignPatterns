using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class OpenState : IGateState
    {
        IContext _gate;

        public OpenState(IContext gate)
        {
            _gate = gate;
        }

        public void PayOk()
        {
            Console.WriteLine("Light remains green:\tNo further funds taken from card");
        }

        public void PayFail()
        {
            Console.WriteLine("Light remains green:\tPayment already received.");
        }

        public void Enter()
        {
            Console.WriteLine("Light turns red:\tOne person allowed to pass.");
            _gate.PeoplePassed++;
            _gate.ChangeState(new ClosedState(_gate));
        }
    }
}
