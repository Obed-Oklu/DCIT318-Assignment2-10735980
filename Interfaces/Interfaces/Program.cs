using System;


namespace Interfaces
{
    class Program
    {
        interface IMovable
        {
            void Move();
        }
        class Car : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Car is moving");
            }
        }

        class Bicycle : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Bicycle is moving");
            }
        }

        static void Main(string[] args)
        {
            IMovable BMW = new Car();
            IMovable BMX = new Bicycle();

            BMW.Move();
            BMX.Move();

            Console.ReadKey();
        }
    }
}
