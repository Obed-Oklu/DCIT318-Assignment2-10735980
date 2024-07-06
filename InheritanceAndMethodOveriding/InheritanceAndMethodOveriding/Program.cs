using System;

namespace InheritanceAndMethodOveriding
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some Generic Sound");
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }     
        }


        class program
        {
            static void Main(string[] args)
            {
                Animal LandAnimal = new Animal();
                Dog Scooby = new Dog();
                Cat Kitty = new Cat();

                LandAnimal.MakeSound();
                Scooby.MakeSound();
                Kitty.MakeSound();
                Console.ReadKey();
            }
        }

    }
    
}
