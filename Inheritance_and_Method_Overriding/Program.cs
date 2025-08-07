using System;

namespace Inheritance_and_Method_Overriding
{
    internal class Program
    {

        private class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic sound");
            }
        }

        private class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        private class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.MakeSound();

            Dog dog1 = new Dog();
            dog1.MakeSound();

            Cat cat1 = new Cat();
            cat1.MakeSound();
        }
    }
}
