using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class HandHeldInventory : INumerable
    {
        public Item RightHand { get; set; }
        public Item LeftHand { get; set; }

        public HandHeldInventory(Item rightHand, Item leftHand)
        {
            RightHand = rightHand;
            LeftHand = leftHand;
        }

        public INumerator GetNumerator()
        {
            return new HandHeldInventoryNumerator(this);
        }
    }
}
