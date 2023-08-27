using System;

namespace LearnC_
{
    class TasksSolution
    {
        //Task 20 for array
        public void Task20()
        {
            int length = 20;
            int[] mas = new int[length];

            Random rand = new Random();
            for (int i = 0; i < length; ++i)
            {
                mas[i] = rand.Next(0, 10);
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine();

            Array.Sort(mas);

            int value_1 = mas[0];
            int value_2 = 0;
            int counter_1 = 1;
            int counter_2 = 0;

            for (int i = 1; i <= length; ++i)
            {
                if (i == length)
                {
                    if (counter_1 > counter_2)
                    {
                        value_2 = mas[i - 1];
                        counter_2 = counter_1;
                    }
                    break;
                }

                if (value_1 == mas[i]) counter_1++;
                else
                {
                    if (counter_1 > counter_2)
                    {
                        value_2 = value_1;
                        value_1 = mas[i];
                        counter_2 = counter_1;
                        counter_1 = 1;
                    }
                    else
                    {
                        counter_1 = 1;
                        value_1 = mas[i];
                    }
                }
            }

            Console.WriteLine($"value = {value_2}, counter = {counter_2}");

            for (int i = 0; i < length; ++i)
            {
                Console.Write($"{mas[i]} ");
            }
        }

        //Найдите сумму чисел массива, которые стоят на четных местах
        //мне не нрав как решила но пока оставлю тк работает
        public void task_14()
        {
            int[] mas = new int[int.Parse(Console.ReadLine())];
            int counter = 0;

            Random rand = new Random();
            for (int i = 0; i < mas.Length; i += 1) mas[i] = rand.Next(0, 50);

            for (int i = 1; i < mas.Length; i += 2)
            {
                counter += mas[i];
            }

            /*
            int counter2 = 0;
            for (int i = 0; i < mas.Length; ++i)
            {
                if ((i + 1) % 2 == 0) counter2 += mas[i];
            }
            */

            Console.WriteLine($"Ammount of elements = {counter}");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"{mas[i]}");
            }
        }
    }
}
