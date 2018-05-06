using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Facade Pattern allows multiple classes to be combined within itself so that a client (code) need only deal with the facade instead of multiple classes. All the complexity that would have been required inside the client now resides within the facade.

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new BankFacade(12345678, 1234);
            bank.Withdrawal(500);
            bank.Withdrawal(600);
            bank.Withdrawal(300);
            bank.Deposit(800);
        }
    }
}
