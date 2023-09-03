using System;
using System.Drawing;

namespace LearnC_
{
    class TasksSolution
    {
        private void RandomMassive(int[] array, int size, int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < size; ++i)
                array[i] = rand.Next(min, max);
        }

        private void ShowMassive(int[] array, int size)
        {
            for (int i = 0; i < size; ++i) Console.Write($"{array[i]} ");
            Console.WriteLine();
        }

        //20) for array
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

        //14) Найдите сумму чисел массива, которые стоят на четных местах
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

        //10) Сформировать массив из случайных чисел,
        //в которых ровно две единицы, стоящие на случайных позициях.
        public void Task_10()
        {
            int size = 20;
            int[] mas = new int[size];

            Random rand = new Random();
            int index_1 = rand.Next(0, size - 1);
            int index_2;

            do
            {
                index_2 = rand.Next(0, size - 1);
            } while (index_2 == index_1);

            for (int i = 0; i < size; ++i)
            {
                if (i == index_1 || i == index_2)
                {
                    mas[i] = 1;
                    continue;
                }

                mas[i] = rand.Next(-100, 100);
                if (mas[i] == 1) mas[i] += rand.Next(-100, 100);
            }

            ShowMassive(mas, size);
        }

        //17) Заменить каждый элемент массива
        //с четным номером на соседний слева элемент. (normal)

        //19) В данном массиве найдите количество чисел,
        //соседи у которых отличаются более чем в 2 раза. (normal)
        public void Task_19()
        {
            int size = 20;
            int[] mas = new int[size];
            RandomMassive(mas, size, -100, 100);
            ShowMassive(mas, size);
            int count = 0;
            for (int i = 1; i < size - 1; ++i)
            {
                float result;
                if (Math.Abs(mas[i - 1]) > Math.Abs(mas[i + 1]))
                    result = (float)mas[i - 1] / (float)mas[i + 1];
                else
                    result = (float)mas[i + 1] / (float)mas[i - 1];

                if (result > 2f || result < -2f)
                {
                    Console.WriteLine($"result = {result}, index1 {i-1}, index2 {i+1}");
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        //21) Дан массив x из n элементов. Найдите x1−x2+x3−…−(xn−1)+xn. (hard)

        //22) Дан массив. Найдите два соседних элемента, сумма которых минимальна. (hard)

        //23) Найдите количество различных элементов данного массива. (hard)

        //24) Даны два массива. Сформировать третий массив, состоящий из тех элементов, которые:
        //а) присутствуют в обоих массивах;
        //б) присутствуют только в одном из массивов.(hard)

        //25) Даны два упорядоченных по возрастанию массива.
        //Образовать из этих двух массивов единый упорядоченный по возрастанию массив. (hard)

        //26) Дан массив из n элементов. Переставьте его элементы случайным образом. (hard)


        //27) Дан массив.Осуществите циклический сдвиг массив на k единиц вправо,
        //если первый наименьший элемент массива расположен раньше последнего наибольшего
        //элемента массива, и влево, если иначе. (hard)
        public void Task_27()
        {
            int size = 20;
            int[] mas = new int[size];
            RandomMassive(mas, size, 0, 50);
            ShowMassive(mas, size);
            //храним мин и макс, а также их индексы
            (int index, int value) min = (0, mas[0]);
            (int index, int value) max = (0, mas[0]);

            for (int i = 1; i < size; ++i)
            {
                if (mas[i] < min.value)
                {
                    min.value = mas[i];
                    min.index = i;
                }

                if (mas[i] > max.value)
                {
                    max.value = mas[i];
                    max.index = i;
                }
            }

            Console.WriteLine($"min = {min.value}, index = {min.index}");
            Console.WriteLine($"max = {max.value}, index = {max.index}");

            //сдвиг
            int k = 10;

            int[] shiftArray = new int[size];
            if (max.index <= min.index)
            {
                int shift = 0;
                for (int i = 0; i < size; ++i)
                {
                    shift = i - k;
                    if (shift < 0) shift = size + shift;
                    shiftArray[shift] = mas[i];
                }
            }
            else
            {
                int shift = 0;
                for (int i = 0; i < size; ++i)
                {
                    shift = k + i;
                    if (shift > size - 1) shift = shift - size;
                    shiftArray[shift] = mas[i];
                }
            }
            Array.Sort(shiftArray);
            ShowMassive(shiftArray, size);
        }

        //28) Дан массив и число p. Найдите два различных числа в массиве,
        //сумма которых наиболее близка к p. (hard)

        //29) Найдите количество элементов массива, которые отличны от наибольшего
        //элемента не более чем на 10%. (hard)

        //30) Выполните сортировку массива следующими тремя способами:
        //сортировка пузырьком,
        //сортировкой выбором,
        //сортировкой вставками,
        //сортировкой обменом. (very hard)
    }
}
