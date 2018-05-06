using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Light
    {
        int brightness = 0;

        public void SwitchOn()
        {
            brightness = 100;
        }

        public void SwitchOff()
        {
            brightness = 0;
        }

        public void Brighten()
        {
            brightness += brightness < 100 ? 10 : 0;
        }

        public void Dim()
        {
            brightness -= brightness > 0 ? 10 : 0;
        }

        public void Display()
        {
            Console.WriteLine($"Brightness: {brightness}");
        }
    }
}
