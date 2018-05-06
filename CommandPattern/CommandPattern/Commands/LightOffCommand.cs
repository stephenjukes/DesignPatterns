using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class LightOffCommand : ICommand
    {
        Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.SwitchOff();
        }

        public void Unexecute()
        {
            _light.SwitchOn();
        }
    }
}
