using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Invoker
    {
        ICommand _on;
        ICommand _off;
        ICommand _up;
        ICommand _down;

        public Invoker(ICommand on, ICommand off, ICommand up, ICommand down)
        {
            _on = on;
            _off = off;
            _up = up;
            _down = down;
        }

        public void SwitchOn()
        {
            _on.Execute();
        }

        public void SwitchOff()
        {
            _off.Execute();
        }

        public void Brighten()
        {
            _up.Execute();
        }

        public void Dim()
        {
            _down.Execute();
        }
    }
}
