using System;

namespace parityCheck1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int number;

            Console.WriteLine("Введите цело число");

            answer =Console.ReadLine();

            number = Convert.ToInt32(answer);

            if (number%2 == 0)
            {
                Console.WriteLine("Вы ввели четное число - " + number);
            } else
            {
                Console.WriteLine("Вы ввели нечетное число  - " + number);
            }

        }
    }
}
