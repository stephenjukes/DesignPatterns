using System;

namespace FacadePattern
{
    class PinCheck
    {
        private int pin = 1234;

        public bool CorrectNum(int pinToCheck)
        {
            return pinToCheck == pin;
        }
    }
}
