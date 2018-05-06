using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class BankFacade
    {
        private int _accountNumber;
        private int _pin;
        private AccountNumCheck _accountCheck;
        private PinCheck _pinCheck;
        private Transaction _transaction;

        public BankFacade(int accountNumber, int pin)
        {
            _accountNumber = accountNumber;
            _pin = pin;
            
            _accountCheck = new AccountNumCheck();
            _pinCheck = new PinCheck();
            _transaction = new Transaction();
        }

        public void Withdrawal(int amount)
        {
            if( _accountCheck.CorrectNum(_accountNumber) && _pinCheck.CorrectNum(_pin) ) 
            {
                _transaction.Withdraw(amount);
            }
        }

        public void Deposit(int amount)
        {
            if ( _accountCheck.CorrectNum(_accountNumber) && _pinCheck.CorrectNum(_pin) )
            {
                _transaction.Deposit(amount);
            }
        }
    }
}
