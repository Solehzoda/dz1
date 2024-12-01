using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");int num2 = int.Parse(Console.ReadLine());
            while (num1 >= num2)
            {
                num1 -= num2;
            }
            Console.WriteLine(num1);
        }
    }
}