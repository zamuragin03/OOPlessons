using System;
using static System.Console;
using printer= System.Console;

namespace ООП
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string middleName;
        public string lastName;
        public int age;
        public string group;
    }
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.firstName = "Игорь";
            student.middleName = "Михайлович";
            student.lastName = "Замурагин";
            student.age = 18;
            student.id = Guid.NewGuid();
            student.group = "БИВТ-21-5";
            return student;
        }
        static void Print(Student student)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Информация");
            WriteLine($"ID:{student.id}");
            WriteLine($"Фамилия:{student.lastName}");
            WriteLine($"Имя:{student.firstName}");
            WriteLine($"Отчество:{student.middleName}");
            WriteLine($"Возраст:{student.age}");
            WriteLine($"Группа:{student.group}");
        }
        static void Main()
        {
            var student1 = GetStudent();
            Print(student1);
            WriteLine();
            Transport car = new Car("Audi");
            Transport aircraft = new Aircraft("kosmolet");
            Aircraft aircraft2 = new Aircraft("zvezdolet");
            aircraft2.Move();
            aircraft.Move();
            car.Move();

            Shape square = new Square(2);
            Shape circle = new Circle(3);
            double SqS = square.GetArea();
            double SqP = square.GetPerimetr();
            Console.WriteLine(SqS+" площадь квадрата");
            Console.WriteLine(SqP + " перметр квадрата");
            double CirS = circle.GetArea();
            double CirP = circle.GetPerimetr();
            WriteLine(CirP + " площадь круга");
            WriteLine(CirP+ " длина окружности");

        }

    }

    abstract class Transport
    {
        public string Name { get; set; }

        public Transport(string Name)
        {
            this.Name = Name;
        }
        public void Move()
        {
            WriteLine($"{Name} движется");
        }
    }

    class Car : Transport
    {
        public Car(string name) : base(name) { }
    }
    class Aircraft : Transport
    {
        public Aircraft(string name) : base(name) { }
    }

    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimetr();

    }

    class Square:Shape
    {
        public double Height{get; set; }

        public Square(double Height)
        {
            this.Height = Height;
        }
        public override double GetArea() => Height * Height;

        public override double GetPerimetr() => Height * 4;
    }

    class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

        public override double GetPerimetr() => 2 * Math.PI * Radius;

    }
}
