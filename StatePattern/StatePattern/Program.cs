using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gate = new Gate();
            Action[] requests = { gate.PaySuccess, gate.PayFail, gate.EnterThru };
            Random random = new Random();  

            for(var i = 0; i < 20; i++)
            {
                int index = random.Next(0, 3);
                Action method = requests[index];
                Console.Write(method.GetMethodInfo().ToString().Split(' ').Last() + "\t");
                method.Invoke();
            }

            string people = gate.PeoplePassed == 1 ? "person" : "people";
            Console.WriteLine($"\n{gate.PeoplePassed} {people} enterred through the gate\n");
        }
    }
}
