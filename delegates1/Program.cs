using System;

namespace delegates1
{
    class Program
    {
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;

        enum OperationType
        {
            Add, Subtract, Multiply
        }
        delegate int Operation(int x, int y);
        static void Main()
        {
            Operation SelectOperation(OperationType opType)
            {
                switch (opType)
                {
                    case OperationType.Add: return Add;
                    case OperationType.Subtract: return Subtract;
                    default: return Multiply;
                }
            }

            Operation operation = SelectOperation(OperationType.Add);
            Console.WriteLine(operation(10, 4));    // 14

            operation = SelectOperation(OperationType.Subtract);
            Console.WriteLine(operation(10, 4));    // 6

            operation = SelectOperation(OperationType.Multiply);
            Console.WriteLine(operation(10, 4));    // 40
        }


    }
}
