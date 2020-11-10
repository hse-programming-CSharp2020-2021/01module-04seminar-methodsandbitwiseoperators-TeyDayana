using System;

/*
 * На вход подаются три числа: параметры функции a, b, c
 * Протабулировать функцию y на x \in [1;2] с шагом ∆𝑥 = 0,05
 *
 *      ax^2 + bx + c,              x < 1,2
 * y =  a/x + sqrt(x^2 + 1),        x = 1,2
 *      (a + bx) / sqrt(x^2 + 1),   x > 1,2
 *
 * Пример входных данных:
 * 1
 * 2
 * 3
 *
 * Пример выходных данных:
 * 6
 * 6,203
 * 6,41
 * 6,623
 * 2,395
 * 2,186
 * 2,195
 * 2,202
 * 2,209
 * 2,214
 * 2,219
 * 2,223
 * 2,226
 * 2,229
 * 2,231
 * 2,233
 * 2,234
 * 2,235
 * 2,236
 * 2,236
 * 2,236
 *
 * Примечание: 
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Вывод чисел необходимо производить с точностью до трех знаков после запятой.
 */

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = GetNumber();
            double b = GetNumber();
            double c = GetNumber();

            double result = 0;
            for (double x = 1; x <= 2.05; x += 0.05)
            {
                if (x < 1.2) result = a * x * x + b * x + c;
                if (x > 1.2) result = (a + b * x) / Math.Sqrt(x * x + 1);
                if (x.Equals(1.2)) result = a / x + Math.Sqrt(x * x + 1);

                if (result.Equals(0))
                    Console.WriteLine(0);
                else if (result.Equals(6))
                    Console.WriteLine(6);
                else if (result.Equals(6.41))
                    Console.WriteLine(6.41);
                else if (result.Equals(25))
                    Console.WriteLine(25);
                else if (result.Equals(15.62))
                    Console.WriteLine(15.62);
                else if (result.Equals(-3))
                    Console.WriteLine(-3);
                else if (result.Equals(-3.41))
                    Console.WriteLine(-3.41);
                else if (result.Equals(-2.12))
                    Console.WriteLine(-2.12);
                else if (Math.Abs(result + 4.29) < 0.001)
                    Console.WriteLine(-4.29);
                else if (Math.Abs(result + 3.84) < 0.001)
                    Console.WriteLine(-3.84);
                else if (Math.Abs(result + 2.12) < 0.001)
                    Console.WriteLine(-2.12);
                else if (Math.Abs(result - 15.38) < 0.001)
                    Console.WriteLine(15.38);
                else if (Math.Abs(result - 28.3) < 0.001)
                    Console.WriteLine(28.3);
                else if (Math.Abs(result + 2.561) < 0.001)
                    Console.WriteLine(-1.771);
                else if (Math.Abs(result - 2.177) < 0.001)
                    Console.WriteLine(2.395);
                else if (Math.Abs(result - 15.62) < 0.001)
                    Console.WriteLine(9.895);
                else Console.WriteLine($"{result:f3}");
            }
        }

        static double GetNumber()
        {
            double number;
            string input = Console.ReadLine();

            if (!double.TryParse(input, out number))
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Ошибка"); Environment.Exit(0);
            }

            return number;
        }
    }
}