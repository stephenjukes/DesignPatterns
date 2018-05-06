using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            string input;
            var light = new Light();
            var remote = new Invoker(new LightOnCommand(light), 
                                     new LightOffCommand(light), 
                                     new LightUpCommand(light),
                                     new LightDownCommand(light) 
                                     );
            while(!quit)
            {
                light.Display();
                Console.WriteLine("1: On, 2: Off, 3: Brighten, 4: Dim");
                input = Console.ReadLine();

                switch(input)
                {
                    case "1":   light.SwitchOn();   break;
                    case "2":   light.SwitchOff();  break;
                    case "3":   light.Brighten();   break;
                    case "4":   light.Dim();        break;
                    case "q":   quit = true;        break;
                    default: Console.WriteLine("Selection not recognized. Please try again.");  break;
                }
            }
        }
    }
}
