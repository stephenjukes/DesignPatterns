using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class LightDownCommand : ICommand
    {
        Light _light;

        public LightDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Dim();
        }

        public void Unexecute()
        {
            _light.Brighten();
        }
    }
}
