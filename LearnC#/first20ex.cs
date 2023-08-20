using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash_2
{
    class Program
    {
        static void Main(string[] args)
        {
            task_20();
            Console.ReadLine();
        }

        //Перевод числа из метров в километры
        static void task_1()
        {
            float a;
            a = float.Parse(Console.ReadLine());
            float result = a / 1000;

            Console.WriteLine($"Meters = {a} \n" +
                $"Meters in kilometers = {result}");
        }


        //Вывести на экран таблицу умножения на любое число (число ты передаешь в метод как параметр)
        static void task_2(int num = 7)
        {
            Console.WriteLine($"Multiplication table: ");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }


        //Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно
        static void task_3()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int sum = 0;
            if (n < 0)
            {
                while (n != 0)
                {
                    sum = sum + n;
                    n = n + 1;
                }
                Console.WriteLine($"{sum}");
            }
            else if (n == 0) Console.WriteLine($"1");
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}");
            }
        }


        //Проверка четности числа (в ответе - да (четное), не (не четное))
        static void task_4()
        {
            int a;
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0) Console.WriteLine($"The number {a} is even");
            else Console.WriteLine($"The number {a} is odd");
        }


        //Перевести минуты в часы
        static void task_5()
        {
            int AllMinuts;
            AllMinuts = int.Parse(Console.ReadLine());
            int hours = AllMinuts / 60;
            int minuts = AllMinuts % 60;

            Console.WriteLine($"Converting minutes {AllMinuts}: ");
            Console.WriteLine($"{hours} hours and {minuts} minuts");
        }


        //Перевести возраст в дни
        static void task_6()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int j = n * 365;
            Console.WriteLine($"Age in days = {j}");
        }


        //Вывести на экран "Hello World!"
        static void task_7()
        {
            Console.WriteLine("Hello World!");
        }


        //Дано значение температуры в градусах Цельсия. Вывести температуру  в градусах Фаренгейта
        static void task_8()
        {
            float celsius;
            celsius = float.Parse(Console.ReadLine());
            float fahrenheit = celsius * 9/5 + 32;

            Console.WriteLine($"Degrees Celsius {celsius} \n"  +
                $"Degrees Fahrenheit {fahrenheit}");
        }


        //Пользователь вводит сторону квадрата. Найдите периметр и площадь квадрата
        static void task_9()
        {
            float side;
            side = float.Parse(Console.ReadLine());
            float S = side * side;
            float P = 4 * side;

            Console.WriteLine($"S = {S}\n" +
                $"P = {P}");
        }


        //Пользователь вводит два числа. Найдите сумму и произведение данных чисел
        static void task_10()
        {
            float a;
            a = float.Parse(Console.ReadLine());
            float b;
            b = float.Parse(Console.ReadLine());

            float sum = a + b;
            float composition = a * b;

            Console.WriteLine($"{a} + {b} = {sum}\n" +
                $"{a} * {b} = {composition}");
        }


        //Пользователь вводит число. Выведите на экран квадрат этого числа, куб этого числа
        static void task_11()
        {
            float a;
            Console.Write($"Number = ");
            a = float.Parse(Console.ReadLine());

            float degree;
            Console.Write($"Degree = ");
            degree = float.Parse(Console.ReadLine());

            Console.WriteLine($"{a}^{degree} = " + Math.Pow(a,degree));
        }


        /*Даны три переменные a, b и c. Изменить значения этих переменных так, чтобы в a хранилось значение a+b,
        в b хранилась разность старых значений c−a, а в c хранилось сумма старых значений a+b+c.
        Например, a=0, b=2, c=5, тогда новые значения a = 2, b = 3 и c = 7*/
        static void task_12()
        {
            int a;
            a = int.Parse(Console.ReadLine());
            int b;
            b = int.Parse(Console.ReadLine());
            int c;
            c = int.Parse(Console.ReadLine());
            a = a + b;
            b = c - a + b;
            c = a + c;
            Console.WriteLine($"a = {a}\t" +
                $"b = {b}\t" +
                $"c = {c}");
        }


        //Вывести на экран букву "W" из символов "*"
        static void task_13()
        {
            Console.WriteLine("*     *     *");
            Console.WriteLine(" *   * *   *");
            Console.WriteLine("  * *   * *");
            Console.WriteLine("   *     *");
        }


        //Дан прямоугольник размером 647 x 170. Сколько квадратов со стороной 30 можно вырезать из него?
        static void task_14()
        {
            int a;
            a = (647 * 170) / (30 * 30);
            Console.WriteLine($"Из прямоугольника 647х170 можно вырезать {a} квадрата");
        }


        /*Пользователь вводит три числа.Найдите среднее арифметическое этих чисел,
        а также разность удвоенной суммы первого и третьего чисел и утроенного второго числа*/
        static void task_15()
        {
            float a;
            a = float.Parse(Console.ReadLine());
            float b;
            b = float.Parse(Console.ReadLine());
            float c;
            c = float.Parse(Console.ReadLine());
            float d;
            float e;
            d = ((a + b + c) / 3);
            e = (((a + c)*2) - b*3);

            Console.WriteLine($"Среднее арифметическое = {d}\n" +
                $"Разность удвоенной суммы первого и третьего чисел и утроенного второго числа = {e}");
        }


        /*Известно, что x кг конфет стоит a рублей. Определите, сколько стоит y кг этих конфет,
        а также сколько кг конфет можно купить на k рублей. Все значения вводит пользователь*/
        static void task_16()
        {
            Console.Write($"Enter the number of kilograms of sweets (x): ");
            float x;
            x = float.Parse(Console.ReadLine());

            Console.Write($"Enter the cost of sweets for {x} kilogram: ");
            float a;
            a = float.Parse(Console.ReadLine());

            Console.Write($"Enter the number of kilograms of sweets (y): ");
            float y;
            y = float.Parse(Console.ReadLine());

            Console.Write($"Enter the number of rubles: ");
            float k;
            k = float.Parse(Console.ReadLine());

            float costForY = a / x * y;
            float kgForK = k / a * x;

            Console.WriteLine($"Cost {y} kg of sweets = {costForY} rubles"); ;
            Console.WriteLine($"The number of kg of sweets that can be bought for {k} rubles: {kgForK} kg");
        }


        //Даны две переменных с некоторыми значениями. Поменять местами значения этих переменных
        static void task_17()
        {
            int a = 5;
            int b = 19;
            int c;
            Console.WriteLine($"a = {a}\n" +
                $"b = {b}");

            c = a;
            a = b;
            b = c;
            Console.WriteLine($"\na = {a}\n" +
                $"b = {b}");
        }


        //Поменяйте местами значения двух переменных, не используя дополнительных переменных
        static void task_18()
        {
            int a = 25;
            int b = 4;
            Console.WriteLine($"a = {a}\n" +
                $"b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"\na = {a}\n" +
                $"b = {b}");
        }


        //Вывести на экран пять строк из нулей, причем количество нулей в каждой строке равно номеру строки
        static void task_19()
        {
            int numOfRows = 5;
            for (int i = 1; i <= numOfRows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"0");
                }
                Console.WriteLine();
            }
        }


        //Вывести на экран прямоугольник, заполненный буквами А. Количество строк в прямоугольнике равно 5, количество столбцов равно 8
        static void task_20()
        {
            int rows = 5;
            int columns = 8;
            char letter = 'A';
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }
        }
    }

}
