using System;

namespace LearnC_
{
    internal class FirstTasks
    {
        public byte num;

        //Перевод числа из метров в километры
        public void Task1_1()
        {
            int meters; 
            Console.WriteLine($"Enter length in meters:");
            meters = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine($"{meters} meters = {meters / 1000.0} km = {meters / 1000} km {meters%1000} m");
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
            float tempF = (tempC * 9 / 5) + 32;
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
    }
}
