using System;

namespace class_inh
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver шпщк = new Driver();
            шпщк.Move();
        }
    }

    interface IMovable
    {
        void Move();
    }
    abstract class Person : IMovable
    {
        public abstract void Move();
    }
    class Driver : Person
    {
        public override void Move() => Console.WriteLine("Шофер ведет машину");
    }
}
