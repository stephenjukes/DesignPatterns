using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 The Composite Pattern deals with one type, some objects of which contain objects of the same type (rather like the decorator pattern) and others which do not. This can be compared to a tree where some branches contain other branches, and other branches (ie: leaves) do not. Both composites (branches) and leaves implement the same interface, which allows a methods within the composite to handles both composites and leaves alike (by polymorphism), as in the recursive method included in this demonstration.
*/
namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IItem wakeUp = new Item("Wake Up");
            IItem brushTeeth = new Item("Brush Teeth");
            IItem washFace = new Item("Wash Face");

            IItem goShopping = new ItemList("Go Shopping", new List<IItem>(new IItem[] {
                new Item("Milk"),
                new Item("Apples"),
                new Item("Chocolate")
            }));

            IItem payBills = new ItemList("Pay Bills", new List<IItem>(new IItem[] {
                new Item("Gas"),
                new Item("Water"),
                new Item("Electric")
            }));

            IItem visitFriends = new ItemList("Visit Friends", new List<IItem>(new IItem[] {
                new Item("Huey"),
                new Item("Dewey"),
                new Item("Louie")
            }));


            var toDoList = new ItemList("ToDo List", new List<IItem>(new IItem[] {
                wakeUp, brushTeeth, washFace, goShopping, payBills, visitFriends
            }));

            string html = toDoList.GetHtml("");
            Console.WriteLine(html);
        }
    }
}
