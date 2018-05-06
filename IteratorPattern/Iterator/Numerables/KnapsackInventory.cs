using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class KnapsackInventory : INumerable
    {
        public List<Item> Items { get; set; }

        public KnapsackInventory(List<Item> items)
        {
            Items = items;
        }

        public INumerator GetNumerator()
        {
            return new KnapsackInventoryNumerator(this);
        }


    }
}
