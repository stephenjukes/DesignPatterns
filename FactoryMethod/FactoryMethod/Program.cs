using System;

// The Factory Method is used to create * ONE OF MULTIPLE * types inheriting from a single base type at run time (ie: not at compile time). 
/*
   The Factory Method helps to -
    - keep code DRY by limiting object creation logic to one place (ie: the factory)
    - prevent withold knowledge of all the subtypes from the user.
*/

// QUESTION: Why do demos make use of an abstract class instead of an interface, when the abstract class only makes use of signatures and does not provide any method functionality?

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var characterBuilder = new CharacterBuilder();
            characterBuilder.BuildCharacter();
        }
    }
}
