using System;

namespace intrfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable tom = new Person("Tom");
            tom.MoveEvent += () => Console.WriteLine($"{tom.Name} is walking");
            tom.Move();
        }
    }

    interface IMovable
    {
        protected internal void Move();
        protected internal string Name { get; }

        delegate void MoveHandler();

        protected internal event MoveHandler MoveEvent;
    }

    class Person:IMovable
    {
        public Person(string name)
        {
            this.name = name;
        }
        private string name;
        private IMovable.MoveHandler? moveEvent;
        void IMovable.Move()
        {
            Console.WriteLine($"{name} is walking");
            moveEvent.Invoke();
        }

        string IMovable.Name
        {
            get => name;
        }

        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add => moveEvent += value;
            remove => moveEvent -= value;
        }
    }

}
