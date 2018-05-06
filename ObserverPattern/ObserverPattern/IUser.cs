using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface IUser
    {
        string Name { get; }
        void WriteMessage(string message);
        void Update();
    }
}
