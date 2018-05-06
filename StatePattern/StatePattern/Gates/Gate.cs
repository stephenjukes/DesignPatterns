using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Gate : IContext
    {
        IGateState _state;
        public int PeoplePassed { get; set; } = 0;

        public Gate()
        {
            _state = new ClosedState(this);
            
        }

        public void PaySuccess()
        {
            _state.PayOk();
        }

        public void PayFail()
        {
            _state.PayFail();
        }

        public void EnterThru()
        {
            _state.Enter();
        }

        public void ChangeState(IGateState state)
        {
            _state = state;
        }
    }
}