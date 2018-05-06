using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Warrior : ICharacter
    {
        private int health;

        public void NormalAttack()
        {
            Console.WriteLine("Swing sword");
        }

        public void SuperAttack()
        {
            Console.WriteLine("Super spinning twirling sword!!!");
        }
    }
}
