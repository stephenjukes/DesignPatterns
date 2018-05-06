using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Transaction
    {
        private decimal balance = 1000;

        public bool EnoughFunds(decimal intendedWithdrawal)
        {
            return balance >= intendedWithdrawal;
        }

        public void Withdraw(decimal amount)
        {
            if ( EnoughFunds(amount) )
            {
                balance -= amount;
                Console.WriteLine($"Please take your {amount}.");
            }
            else
            {
                Console.WriteLine($"Unable to withdraw {amount}");
            }

            DisplayBalance();
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"{amount} received.");
            DisplayBalance();
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Remaining balance: {balance}.\n");
        }

    }
}
