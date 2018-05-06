using System;
using System.Linq;
using System.Collections.Generic;
using IteratorPattern.Items;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var hands = new HandHeldInventory(new Sword(), new Shield());
            var knapsack = new KnapsackInventory(new List<Item>(new Item[]{
                new Apple(),
                new Medicine(),
                new Potion(),
                new SpellBook(),
                new Wand()
            }));

            INumerable inventory = knapsack;
            INumerator numerator = inventory.GetNumerator();

            while(!numerator.IsDone())
            {
                Console.WriteLine(numerator.CurrentItem().ToString().Split('.').Last());
                numerator.Next();
            }
        }
    }
}
