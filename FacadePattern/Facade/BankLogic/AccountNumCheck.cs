using System;

namespace FacadePattern
{
    class AccountNumCheck
    {
        private int account = 12345678;

        public bool CorrectNum(int accountToCheck)
        {
            return accountToCheck == account;
        }
    }
}

