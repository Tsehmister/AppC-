using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число");

            string str = Console.ReadLine();

            int a = Convert.ToInt32(str);

            Console.WriteLine("Введите второе число");

            string str1 = Console.ReadLine();

            int b = Convert.ToInt32(str1);

            Console.WriteLine("Введите третье число");

            string str2 = Console.ReadLine();

            int d = Convert.ToInt32(str2);

            int result = (a + b + d);

            int result1 = (a * b * d);

            Console.WriteLine("Сумма чисел равна " + result);

            Console.WriteLine("Произведение чисел равно " + result1);


        }
    }
}
