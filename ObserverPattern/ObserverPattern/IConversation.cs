using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface IConversation
    {
        void Register(IUser user);
        void Unregister(IUser user);
    }
}
