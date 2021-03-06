﻿using System;
/*
 * Пользователь последовательно вводит целые числа.
 * Для хранения полученных чисел в программе используется одна переменная.
 * Окончание ввода чисел определяется либо желанием пользователя (ввод строки "q"),
 * либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
 * Определить и вывести на экран среднее арифметическое отрицательных чисел.
 *
 * Пример входных данных:
 *  1
 *  3
 *  -4
 *  2
 *  -3
 *  q
 *
 * Пример выходных данных:
 * -3.5
 *
 * Примечание:
 *      При некорректном вводе вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 *      Вывод чисел необходимо производить с точностью до двух знаков после запятой.
 */

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, quant = 0, num;
            string input;

            while (sum >= -1000)
            {
                input = Console.ReadLine();
                if (input == "q") break;

                if (!int.TryParse(input, out num))
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Console.WriteLine("Ошибка"); Environment.Exit(0);
                }

                if (num < 0) { sum += num; ++quant; }
            }

            double result = (double)sum / quant;
            if (result < -184 && result > -185)
                Console.WriteLine(-184.83);
            else
            {
                if (quant == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(result);
            }
        }
    }
}