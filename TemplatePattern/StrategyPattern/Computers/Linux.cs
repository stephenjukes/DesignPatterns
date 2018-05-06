using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Linux : Computer
    {
        protected override string Name { get; set; } = "Linux";

        protected override void DisplayLogo()
        {
            Console.WriteLine("Display Penguin");
        }
    }
}
