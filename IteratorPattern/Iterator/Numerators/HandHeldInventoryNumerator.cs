using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class HandHeldInventoryNumerator : INumerator
    {
        private HandHeldInventory _inventory;
        private int index = 0;

        public HandHeldInventoryNumerator(HandHeldInventory inventory)
        {
            _inventory = inventory;
        }

        public bool IsDone()
        {
            return index >= 2;
        }

        public Item CurrentItem()
        {
            switch(index)
            {
                case 0: return _inventory.RightHand;
                case 1: return _inventory.LeftHand;
                default: return null;
            }
            
        }

        public void Next()
        {
            {
                index ++;
            }
        }





    }
}
