using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class KnapsackInventoryNumerator : INumerator
    {
        private KnapsackInventory _inventory;
        private int _index = 0;

        public KnapsackInventoryNumerator(KnapsackInventory inventory)
        {
            _inventory = inventory;
        }

        public bool IsDone()
        {
            return _index >= _inventory.Items.Count;
        }

        public Item CurrentItem()
        {
            return _inventory.Items[_index];
        }

        public void Next()
        {
            _index ++;
        }
    }
}
