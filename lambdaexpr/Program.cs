using System;

namespace lambdaexpr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //сумма чисел больше 5
            int result1 = Sum(integers, x => x > 5);
            Console.WriteLine(result1); // 30

            // найдем сумму четных чисел
            int result2 = Sum(integers, x => x % 2 == 0);
            Console.WriteLine(result2);  //20


        }
        static int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }
    }
    delegate bool IsEqual(int x);
}
