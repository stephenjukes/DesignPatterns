using System;

namespace FactoryMethod
{
    class CharacterBuilder : ICharacterBuilder
    {
        private ICharacter[] characters = { new Mage(), new Warrior(), new Dragon() };

        public ICharacter BuildCharacter()
        {
            Random r = new Random();
            int index = r.Next(0, 2);

            ICharacter character = characters[index];

            Console.WriteLine($"New {character} created.");
            return character;
        }
    }
}
