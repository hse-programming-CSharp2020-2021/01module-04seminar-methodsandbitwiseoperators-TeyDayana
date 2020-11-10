using System;

/*
 * Пользователь вводит неотрицательные целые (int) числа q и p, такие, что q <= p.
 * Определить все тройки попарно различных целых чисел a, b, c \in [q; p],
 * для которых верно a^2 + b^2 = c^2.
 *
 * Пример входных данных:
 * 1
 * 10
 *
 * Пример выходных данных:
 * 3 4 5
 * 6 8 10
 *
 * Примечание:
 *      Тройки необходимо выводить в алфавитном порядке, то есть по возрастанию чисел в них.
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 */

namespace Task1
{
    class Program
    {

        // TODO: использовать передачу параметров по ссылке
        static void ReadBoundaries(out int q, out int p)
        {
            // TODO: прочитать границы и проверить введенные данные на корректность
            if (!int.TryParse(Console.ReadLine(), out q))
                q = -1;
            if (int.TryParse(Console.ReadLine(), out p))
                p = -1;

            if (q > p || q < 0 || p < 0)
            {
                Console.WriteLine("Ошибка");
                Environment.Exit(0);
            }
        }

        static void PrintPythagorasNumbers(int q, int p)
        {
            // TODO: вывести пифагоровы тройки с числами из введенного отрезка
            for (int a = q; a <= p; ++a)
                for (int b = a; b <= p; ++b)
                    for (int c = b; c <= p; ++c)
                        if (a*a + b*b == c*c)
                            Console.WriteLine(a + " " + b + " " + c);
        }

        static void Main(string[] args)
        {
            int q, p;
            // TODO: дополнить метод так, чтобы программа выполняла поставленную задачу
            ReadBoundaries(out q, out p);
            PrintPythagorasNumbers(q, p);
        }
    }
}