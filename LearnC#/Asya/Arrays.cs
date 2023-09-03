using System;

namespace LearnC_
{
    internal class Arrays
    {
        //Заполнить массив числами от 1 до n.
        public void Task2_1()
        {
            Console.WriteLine("Enter integer n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = i + 1;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{nums[i]}");
            }
        }

        //Заполнить массив нулями, кроме первого и последнего элементов, которые должны быть равны единице.
        public void Task2_2()
        {
            int[] nums = new int[5];
            nums[0] = 1;
            nums[^1] = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]}");
            }

            /*foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }*/
        }

        //Заполнить массив нулями и единицами, при этом данные значения чередуются, начиная с нуля.
        public void Task2_3()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 != 0) nums[i] = 1;
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Заполнить массив последовательными нечетными числами, начиная с единицы.
        public void Task2_4()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];

            for (int i = 0, j = 1; i < nums.Length; i++, j = j + 2)
            {
                nums[i] = j;
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Сформировать возрастающий массив из четных чисел.
        public void Task2_5()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];

            for (int i = 0, j = 2; i < nums.Length; i++, j = j + 2)
            {
                nums[i] = j;
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Создать массив, каждый элемент которого равен квадрату своего номера.
        public void Task2_6()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * i;
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Создать массив, состоящий из троек подряд идущих одинаковых элементов.
        public void Task2_7()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];

            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (i % 3 == 0) j++;
                nums[i] = j;
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Создать массив, на четных местах в котором стоят единицы, а на нечетных местах - числа, равные остатку от деления своего номера на 5.
        public void Task2_8()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0) nums[i] = 1;
                else nums[i] = i % 5;
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Создать массив, который одинаково читается как слева направо, так и справа налево.
        public void Task2_9()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];

            for (int i = 0, j = nums.Length / 2 - 1; i < nums.Length; i++)
            {
                if (nums.Length % 2 == 0)
                {
                    if (i < (nums.Length / 2))
                    { nums[i] = i; }
                    else { nums[i] = j; j--; }
                }
                else
                {
                    if (i <= (nums.Length / 2))
                    { nums[i] = i; }
                    else { nums[i] = j; j--; }
                }
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }

        }

        //Сформировать массив из случайных чисел, в которых ровно две единицы, стоящие на случайных позициях.
        public void Task2_10()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Random random = new Random();
            int k = 0;
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(2, 100000);
            }
            do
            {
                k = random.Next(nums.Length);
                j = random.Next(nums.Length);
            }
            while (k == j);

            nums[k] = 1;
            nums[j] = 1;

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Создайте массив, в котором количество отрицательных чисел равно количеству положительных
        //и положительные числа расположены на случайных местах в массиве.
        public void Task2_11()
        {
            int l = 10;
            int[] nums = new int[l];
            Random random = new Random();

            int positive = 0;
            int negative = 0;

            int middle = 5;

            for (int i = 0; i < l; i++)
            {
                if ((positive < middle) && (negative < middle))
                {
                    nums[i] = random.Next(-100, 100);
                    if (nums[i] < 0) negative++;
                    else positive++;
                    continue;
                }

                if (positive == middle)
                {
                    nums[i] = random.Next(100) * (-1);
                }

                if (negative == middle)
                {
                    nums[i] = random.Next(100);
                }
            }
            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Найти количество четных чисел в массиве.
        public void Task2_12()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Random random = new Random();
            int even_num = 0;

            for (int i = 0; i < l; i++)
            {
                nums[i] = random.Next(-100, 100);
                if (nums[i] % 2 == 0) even_num++;
            }

            Console.WriteLine($"number of even numbers: {even_num}");

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Найти количество чисел в массиве, которые делятся на 3, но не делятся на 7.
        public void Task2_13()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Random random = new Random();
            int even_num = 0;

            for (int i = 0; i < l; i++)
            {
                nums[i] = random.Next(-100, 100);
                if ((nums[i] % 3 == 0) && (nums[i] % 7 != 0))
                {
                    Console.WriteLine($"{nums[i]} = OK");
                    even_num++;
                }
            }

            Console.WriteLine($"number of even numbers: {even_num}");

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }

        }
        //Найдите сумму чисел массива, которые стоят на четных местах.
        public void Task2_14()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Random random = new Random();
            bool even = true;
            int sum = 0;

            for (int i = 0; i < l; i++)
            {
                nums[i] = random.Next(-100, 100);
                if (even)
                {
                    sum += nums[i];
                }
                even = !even;
            }

            Console.WriteLine($"Sum: {sum}");

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Найдите наименьший четный элемент массива
        public void Task2_15()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Random random = new Random();
            int min_even = 100;

            for (int i = 0; i < l; i++)
            {
                nums[i] = random.Next(-100, 100);
                if ((nums[i] % 2 == 0) && (nums[i] < min_even))
                {
                    min_even = nums[i];
                }
            }

            Console.WriteLine($"Min even number: {min_even}");

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Дан массив. Заменить все числа, меньшие последнего элемента массива, на первый элемент.
        public void Task2_16()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Random random = new Random();

            for (int i = 0; i < l; i++)
            {
                nums[i] = random.Next(-100, 100);
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine($"nums[0]= {nums[0]},nums[l-1] ={nums[l - 1]}");

            for (int i = 1; i < l; i++)
            {
                if (nums[i] < nums[l - 1]) nums[i] = nums[0];
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Заменить каждый элемент массива с четным номером на соседний слева элемент.
        public void Task2_17()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Random random = new Random();

            for (int i = 0; i < l; i++)
            {
                nums[i] = random.Next(-100, 100);
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 1; i < l; i++)
            {
                if (i % 2 == 0) nums[i] = nums[i - 1];
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Переставить элементы массива в обратном порядке.
        public void Task2_18()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            int[] nums_reverse = new int[l];
            Random random = new Random();

            for (int i = 0; i < l; i++)
            {
                nums[i] = random.Next(-100, 100);
            }

            for (int i = 0, j = l - 1; i < l; i++, j--)
            {
                nums_reverse[i] = nums[j];
            }

            foreach (int i in nums)
            {
                Console.WriteLine($"nums: {i}");
            }

            foreach (int i in nums_reverse)
            {
                Console.WriteLine($" reverse:{i}");
            }
        }

        //В данном массиве найдите количество чисел, соседи у которых отличаются более чем в 2 раза.
        public void Task2_19()
        {

        }

        //В данном массиве найти максимальное количество одинаковых элементов
        public void Task2_20()
        {

        }

        //Дан массив x из n элементов.Найдите x1−x2+x3−…−xn−1+xn.
        public void Task2_21() { }

        //Дан массив.Найдите два соседних элемента, сумма которых минимальна
        public void Task2_22() { }

        //Найдите количество различных элементов данного массива. 
        public void Task2_23() { }

        //Даны два массива.Сформировать третий массив, состоящий из тех элементов, которые:
        //а) присутствуют в обоих массивах; б) присутствуют только в одном из массивов.
        public void Task2_24() { }

        //Даны два упорядоченных по возрастанию массива.
        //Образовать из этих двух массивов единый упорядоченный по возрастанию массив.
        public void Task2_25() { }

        //Дан массив из n элементов.Переставьте его элементы случайным образом.
        public void Task2_26() { }

        //Дан массив.Осуществите циклический сдвиг массив на k единиц вправо,
        //если первый наименьший элемент массива расположен раньше последнего наибольшего элемента массива, и влево, если иначе
        public void Task2_27() { }

        //Дан массив и число p.Найдите два различных числа в массиве, сумма которых наиболее близка к p. 
        public void Task2_28() { }

        //Найдите количество элементов массива, которые отличны от наибольшего элемента не более чем на 10%. 
        public void Task2_29() { }

        //Выполните сортировку массива следующими тремя способами:
        //сортировка пузырьком, сортировкой выбором, сортировкой вставками, сортировкой обменом.
        public void Task2_30() { }
    }
}
