using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Mage : ICharacter
    {
        private int health;

        public void NormalAttack()
        {
            Console.WriteLine("Abracadabra");
        }

        public void SuperAttack()
        {
            Console.WriteLine("By the power of grayskull!!!");
        }
    }
}
