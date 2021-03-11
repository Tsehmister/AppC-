using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

          /* Console.WriteLine("Введите первое число");

            double firstValue = double.Parse(Console.ReadLine());
                       
            Console.WriteLine("Введите второе число");

           double secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            string str2 = Console.ReadLine();

            int d = Convert.ToInt32(str2);

            int result = (a + b + d);

            int result1 = (a * b * d);

            Console.WriteLine("Сумма чисел равна " + result);

            Console.WriteLine("Произведение чисел равно " + result1);*/

            // 1 евро 25 рублей 

            double usdToRub = 64.52;

            double usdToUah = 27.25;

            double usd;

            Console.WriteLine("Введите сумму в USD");

            usd = double.Parse(Console.ReadLine());

            Console.WriteLine(usd + " долларов " + "в рублях равно " + (usd * usdToRub));
            Console.WriteLine(usd + " долларов " + "в гривне равно " + (usd * usdToUah));



        }
    }
}
