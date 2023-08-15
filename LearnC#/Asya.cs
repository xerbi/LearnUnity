using System;

namespace LearnC_
{
    internal class Asya
    {
        public byte num;

        //Перевод числа из метров в километры
        public void Task1_1()
        {
            int meters; 
            Console.WriteLine($"Input length in meters:");
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
            Console.Write($"Input integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++) sum += i;
            Console.WriteLine($"Sum = {sum}");
        }

        // Проверка четности числа (в ответе - да (четное), не (не четное))
        public void Task1_4()
        {
            Console.Write($"Input integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) { Console.WriteLine($"{num} - even number"); }
            else { Console.WriteLine($"{num} - uneven number"); }
        }

        //Перевести минуты в часы
        public void Task1_5()
        {
            Console.Write($"Input minutes:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{min} minutes = {min / 60} hours {min % 60} minutes");
        }
    }
}
