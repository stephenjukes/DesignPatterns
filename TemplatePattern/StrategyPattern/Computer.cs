using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    abstract class Computer
    {
        protected abstract string Name { get; set; }
        protected abstract void DisplayLogo();

        protected void UseMouse()
        {
            Console.WriteLine("Move arrow");
        }

        protected void UseKeyboard()
        {
            Console.WriteLine("Print text");
        }

        public void ShowDetails()
        {
            Console.WriteLine(Name);
            DisplayLogo();
            UseMouse();
            UseKeyboard();
        }
    }
}
