using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Decorator Pattern allows various combinations of 'decorations' to change the value of one or many objects of the same type, overcoming the class explosion that would arise from accounting for all of these combinations. Though the coffee shop theme demonstrates this usage, this scenario would probably be dealt with by passing decorations into a list and then simply aggregating over the list to arrive at a final price. The Decorator Pattern really becomes useful when decorations differ in overall behaviour, not simply on different property values. A good clue to the suitability of the decorator pattern is also whether the decorators are in fact of the same type of the object they decorate. Note, in this case while cappuccino and mocha are beverages, whipped cream and sprinkles are not.

// I believe abstract classes are used instead of interfaces to ensure that decorators not only 'implement' certain behaviour, but 'are' the same type as the objects they decorate.

namespace DecoratorPattern
{
    // WhippedCream:    1
    // Sprinkles:       2
    // Mocha:           3
    // Cappuccino       4
    class Program
    {
        static void Main(string[] args)
        {
            var annasBeverage = new Sprinkles(new Cappuccino());                    // 6
            var billsBeverage = new Sprinkles(new Mocha());                         // 5
            var carlsBeverage = new WhippedCream(new Cappuccino());                 // 5
            var davesBeverage = new WhippedCream(new Mocha());                      // 4
            var erinsBeverage = new Sprinkles(new WhippedCream(new Cappuccino()));  // 7
            var fransBeverage = new WhippedCream(new Sprinkles(new Cappuccino()));  // 7
            var galesBeverage = new Sprinkles(new WhippedCream(new Mocha()));       // 6
            var henrysBeverage = new Cappuccino();                                  // 4
            var ivonnesBeverage = new Mocha();                                      // 3

            Beverage[] customerBeverages = { annasBeverage, billsBeverage, carlsBeverage, davesBeverage, erinsBeverage, fransBeverage, galesBeverage, henrysBeverage, ivonnesBeverage };

            foreach (var beverage in customerBeverages)
            {
                Console.WriteLine(beverage.Cost());
            }


        }
    }
}
