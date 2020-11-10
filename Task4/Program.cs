using System;

/*
 * Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры.
 * Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения
 *
 * Пример входных данных:
 * 2
 * 4
 *
 * Пример выходных данных:
 * 20
 *
 * Примечание:
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      При переполнении вывести сообщение "Переполнение".
 */

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetNumber();
            int m = GetNumber();

            int result = Pow2(n) + Pow2(m);
            Console.WriteLine(result);
        }

        static int GetNumber()
        {
            int number;
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number) || number < 0)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Ошибка"); Environment.Exit(0);
            }

            return number;
        }

        static int Pow2(int num)
        {
            return (int)Math.Pow(2, num);
        }
    }
}