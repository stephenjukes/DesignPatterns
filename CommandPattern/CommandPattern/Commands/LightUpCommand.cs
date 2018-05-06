using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class LightUpCommand : ICommand
    {
        Light _light;

        public LightUpCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Brighten();
        }

        public void Unexecute()
        {
            _light.Dim();
        }
    }
}
