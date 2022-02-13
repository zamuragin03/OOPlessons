using System;

namespace delegates
{
    delegate void Message();

    delegate double Mather(double a, double b);
    enum OperationType
    {
        Add, Subtract, Multiply
    }
    class Program
    {
        static double Addition(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        
        delegate int Operation(double x, double y);
        static void Text() => Console.WriteLine("Text");
        static void Hello() => Console.WriteLine("Hello");
        static void Main(string[] args)
        {
            Message mes1 = Text;
            mes1 += Hello;
            mes1.Invoke();
            Mather Add = new Mather(Addition);
            Console.WriteLine(Add(3, 4));
            Mather Operation = Addition;
            //Operation += Substraction;
            //Operation += Multiply;
            Console.WriteLine(Operation.Invoke(2, 4));


        }
    }

    

}
