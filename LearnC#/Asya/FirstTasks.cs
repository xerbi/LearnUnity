using System;
using System.Reflection.Metadata;

namespace LearnC_.Asya
{
    internal class FirstTasks
    {
        public byte num;

        //Перевод числа из метров в километры
        public void Task1_1()
        {
            int meters;
            Console.WriteLine($"Enter length in meters:");
            meters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{meters} meters = {meters / 1000.0} km = {meters / 1000} km {meters % 1000} m");
        }

        //Вывести на экран таблицу умножения на любое число (число ты передаешь в метод как параметр)
        //! Разобраться с get и set для передачи параметра
        public void Task1_2(byte _num)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{_num} * {i} = {_num * i}");
            }
        }

        //Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно
        public void Task1_3()
        {
            int sum = 0;
            Console.Write($"Enter integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1)
            {
                for (int i = 1; i >= num; i--) sum += i;
            }
            else { for (int i = 1; i <= num; i++) sum += i; }

            Console.WriteLine($"Sum = {sum}");
        }

        // Проверка четности числа (в ответе - да (четное), не (не четное))
        public void Task1_4()
        {
            Console.Write($"Enter integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) { Console.WriteLine($"{num} - even number"); }
            else { Console.WriteLine($"{num} - uneven number"); }
        }

        //Перевести минуты в часы
        public void Task1_5()
        {
            Console.Write($"Enter minutes:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{min} minutes = {min / 60} hours {min % 60} minutes");
        }

        //Перевести возраст в дни
        public void Task1_6()
        {
            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age in days = {age * 365}");
        }

        //Вывести на экран "Hello World!"
        public void Task1_7()
        {
            Console.WriteLine("Hello World!");
        }

        //Дано значение температуры в градусах Цельсия. Вывести температуру  в градусах Фаренгейта
        public void Task1_8()
        {
            Console.WriteLine($"Enter temperature in Celsius:");
            float tempC = Convert.ToInt32(Console.ReadLine());
            float tempF = tempC * 9 / 5 + 32;
            Console.WriteLine($"{tempC} Celsius = {tempF} Fahrenheit");
        }

        //Пользователь вводит сторону квадрата. Найдите периметр и площадь квадрата
        public void Task1_9()
        {
            Console.Write($"Enter the side of the square:");
            int side = Convert.ToInt32(Console.ReadLine());
            int pr = side * 4;
            int area = side * side;
            Console.WriteLine($"Perimeter = {pr}, Area = {area}");
        }

        //Пользователь вводит два числа. Найдите сумму и произведение данных чисел
        public void Task1_10()
        {
            Console.WriteLine("Enter the first number: ");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{firstnum} + {secondnum} = {firstnum + secondnum}");
            Console.WriteLine($"{firstnum} * {secondnum} = {firstnum * secondnum}");
        }

        //Пользователь вводит число. Выведите на экран квадрат этого числа, куб этого числа
        public void Task1_11()
        {
            Console.Write($"Enter integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //int num = int.Parse (Console.ReadLine());
            Console.WriteLine($"{num}^2 = {Math.Pow(num, 2)}");
            Console.WriteLine($"{num}^3 = {Math.Pow(num, 3)}");
        }

        //Даны три переменные a, b и c. Изменить значения этих переменных так, чтобы в a хранилось значение a+b,
        //в b хранилась разность старых значений c−a, а в c хранилось сумма старых значений a+b+c.
        public void Task1_12()
        {
            Console.Write($"Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write($"Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write($"Enter c: ");
            int c = int.Parse(Console.ReadLine());
            int b_new = b;
            b = c - a;
            a = a + b_new;
            c = a + c;
            Console.WriteLine($"a = {a}, b = {b}, c= {c}");
        }
        //Вывести на экран букву "W" из символов "*" (звездочка)
        public void Task1_13()
        {
            Console.WriteLine(
            $"    *     *     *\n" +
            $"     *   * *   *\n" +
            $"      * *   * *\n" +
            $"       *     *");
        }

        //Дан прямоугольник размером 647 x 170. Сколько квадратов со стороной 30 можно вырезать из него?
        public void Task1_14()
        {
            const int A = 647;
            const int B = 170;
            const int SIDE = 30;

            Console.WriteLine($"There are {A / SIDE * (B / SIDE)} squares in rectangle 647 x 170");
        }

        //Пользователь вводит три числа. Найдите среднее арифметическое этих чисел,
        //а также разность удвоенной суммы первого и третьего чисел и утроенного второго числа.
        public void Task1_15()
        {
            Console.Write($"Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write($"Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write($"Enter c: ");
            int c = int.Parse(Console.ReadLine());
            int armean = (a + b + c) / 3;
            int dif = 2 * (a + c) - 3 * b;
            Console.WriteLine($"Arithmetic mean = {armean}");
            Console.WriteLine($"Difference = {dif}");
        }

        //Известно, что x кг конфет стоит a рублей. Определите, сколько стоит y кг этих конфет,
        //а также сколько кг конфет можно купить на k рублей.Все значения вводит пользователь.
        public void Task1_16()
        {
            Console.WriteLine($"Введите х кг конфет:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите a рублей:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите y кг конфет:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите k рублей:");
            int k = Convert.ToInt32(Console.ReadLine());

            int kg_sweets = a / x;
            Console.WriteLine($"На {k} рублей можно купить {k / kg_sweets} кг конфет");
            Console.WriteLine($"{y} кг стоит {kg_sweets * y} рублей");

        }

        //Даны две переменных с некоторыми значениями.Поменять местами значения этих переменных.
        public void Task1_17()
        {
            Console.WriteLine($"Enter integer a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter other integer b:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}; b = {b}");
        }

        //Поменяйте местами значения двух переменных, не используя дополнительных переменных.
        public void Task1_18()
        {
            Console.WriteLine($"Enter integer a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter other integer b:");
            int b = Convert.ToInt32(Console.ReadLine());

            a = b - a;
            b = b - a;
            a = a + b;

            Console.WriteLine($"a = {a}; b = {b}");
        }

        //Вывести на экран пять строк из нулей, причем количество нулей в каждой строке равно номеру строки.
        public void Task1_19()
        {
            int line = 5;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('0');
                }
                Console.WriteLine('0');
            }
        }

        //Вывести на экран прямоугольник, заполненный буквами А. Количество строк в прямоугольнике равно 5, количество столбцов равно 8.
        public void Task1_20()
        {
            int line = 5;
            int column = 8;

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write('A');
                }
                Console.WriteLine();
            }
        }
    }
}
