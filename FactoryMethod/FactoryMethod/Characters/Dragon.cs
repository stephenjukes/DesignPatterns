using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Dragon : ICharacter
    {
        private int health;

        public void NormalAttack()
        {
            Console.WriteLine("Breathe Fire");
        }

        public void SuperAttack()
        {
            Console.WriteLine("Blazing Inferno !!!");
        }
    }
}
