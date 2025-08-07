using System;

namespace Interfaces
{
    internal class Program
    {
        interface IMovable
        {
            void Move();
        }

        public class Car : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Car is moving");
            }
        }

        public class Bicycle : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Bicycle is moving");
            }
        }

        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.Move();

            Bicycle Bicycle1 = new Bicycle();
            Bicycle1.Move();
        }
    }
}
