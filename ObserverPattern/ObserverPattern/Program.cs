using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Observer Pattern allows multiplie observers to be updated when state within a subject, (ie: observed object) is changed. Observers each possess a reference to the subject (injected into the constructor) and is registered to a list within the subject.

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var conversation = new Conversation();
            var anna = new User("Anna", conversation);
            var bill = new User("Bill", conversation);
            var carl = new User("Carl", conversation);

            anna.WriteMessage("Anyone going out today?");
            bill.WriteMessage("Sure, where do you wanna go?");
            carl.WriteMessage("Sorry, got too much on tonight.");
            anna.WriteMessage("@bill: How about going to the bar?");
        }
    }
}
