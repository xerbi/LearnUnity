using System;

namespace LearnC_.Asya
{
    internal class Arrays
    {
        public void ArrayShow(int[] arr, int last_index)
        {
            
            for (int i = 0; i < last_index;++i)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        
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
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[l];
            Random rand = new Random();
            int count = 0;

            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(0,100);
                Console.Write($"{mas[i]}, ");
            }
            Console.WriteLine();

            for (int i = 1; i < l - 1; ++i)
            {
                if (mas[i - 1] < mas[i + 1])
                {
                    float result = (float)mas[i + 1] / (float)mas[i - 1];
                    if (result > 2f) 
                    {
                        count++;
                        Console.WriteLine($"result = {result}, index1 {i - 1}, index2 {i + 1}");
                    }
                        
                }
                else 
                {
                    float result = (float)mas[i - 1] / (float)mas[i + 1];
                    if (result > 2f)
                    {
                        count++;
                        Console.WriteLine($"result = {result}, index1 {i - 1}, index2 {i + 1}");
                    } 

                }
            }
        }

        //В данном массиве найти максимальное количество одинаковых элементов
        public void Task2_20()
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[l];
            Random rand = new Random();
            int count = 0;
            int num = 0;
            int max = 0;


            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(0, 10);
            }

            Array.Sort(mas);

            num = mas[0];
            count = 1;

            for (int i = 1; i < l; ++i)
            {
                if (mas[i] == mas[i-1]) count++;
                else 
                {
                    if (count > max)
                    { max = count; num = mas[i - 1];}
                    count = 1;
                }
            }

            Console.WriteLine($"count = {max}, number = {num}");

            foreach (int i in mas)
            {
                Console.WriteLine($"nums: {i}");
            }

        }

        //Дан массив x из n элементов.Найдите x1−x2+x3−…−xn−1+xn.
        public void Task2_21() 
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[l];
            Random rand = new Random();
            int sum = 0;

            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(0, 10);
            }

            for (int i = 0; i < l; ++i)
            {
                if (i % 2 == 0) sum += mas[i];
                else sum -= mas[i];
            }

            Console.WriteLine($"Sum = {sum}");

            foreach (int i in mas)
            {
                Console.WriteLine($"nums: {i}");
            }
        }

        //Дан массив.Найдите два соседних элемента, сумма которых минимальна
        public void Task2_22() 
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[l];
            Random rand = new Random();
            int sum = 0;
            int index2 = 0;

            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(-100, 100);
            }

            for (int i = 1; i < l; ++i)
            {
                if (mas[i - 1] + mas[i] < sum)
                {
                    sum = mas[i - 1] + mas[i];
                    index2 = i;
                } 
            }

            foreach (int i in mas)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"sum = {sum}, index2 = {index2}");
        }

        //Найдите количество различных элементов данного массива. 
        public void Task2_23() 
        {
            Console.WriteLine("Enter length of array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[l];
            Random rand = new Random();
            int count = 0;

            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(-10, 10);
            }

            Array.Sort(mas);

            if (mas[0] != mas[1]) count++;
            if (mas[l-1] != mas[l-2]) count++;

            for (int i = 1; i < l-1; ++i)
            {
                if ((mas[i] != mas[i - 1]) && (mas[i] != mas[i + 1])) count++;
            }

            foreach (int i in mas)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine($"count: {count}");
        }

        //Даны два массива.Сформировать третий массив, состоящий из тех элементов, которые:
        //а) присутствуют в обоих массивах; б) присутствуют только в одном из массивов.

        //НЕ РЕШЕНО!
        public void Task2_24() 
        {
            int l1 = 10, l2 = 10;
            int[] mas1 = new int[l1];
            int[] mas2 = new int[l2];
            int[] mas_res_a = new int[l1+l2];
            int[] mas_res_b = new int[l1+l2];
            int index_a = 0;
            int index_b = 0;
            int j = 0;
            Random rand = new Random();

            for (int i = 0; i < l1; ++i)
            {
                mas1[i] = rand.Next(-10, 10);
            }

            for (int i = 0; i < l2; ++i)
            {
                mas2[i] = rand.Next(-10, 10);
            }

            Array.Sort(mas1);
            Array.Sort(mas2);

            for (int i = 0; i < l1; ++i)
            {
                if ((i != 0)&&(mas1[i] == mas1[i - 1])) continue;

                while(j < l2)
                {
                    if (mas1[i] == mas2[j])
                    {
                        mas_res_a[index_a] = mas1[i];
                        index_a++;
                        j++;
                        break;
                    }
                    else if (mas1[i] > mas2[j])
                    {
                        if (j == 0)
                        {
                            mas_res_b[index_b] = mas2[j];
                            index_b++;
                        }
                        else if (mas2[j] != mas2[j - 1])
                        {
                            mas_res_b[index_b] = mas2[j];
                            index_b++;
                        }
                        j++;

                    }
                    else if (mas1[i] < mas2[j])
                    {
                        mas_res_b[index_b] = mas1[i];
                        index_b++;
                        break;
                    }
                }
                if (j == l2)
                {
                    mas_res_b[index_b] = mas1[i];
                    index_b++;
                }
            }
            Console.WriteLine("mas1:");
            ArrayShow(mas1,l1);

            Console.WriteLine("mas2:");
            ArrayShow(mas2,l2);

            Console.WriteLine("mas_union:");
            ArrayShow(mas_res_a, index_a);

            Console.WriteLine("mas_only_one:");
            ArrayShow(mas_res_b,index_b);

        }

        //Даны два упорядоченных по возрастанию массива.
        //Образовать из этих двух массивов единый упорядоченный по возрастанию массив.
        public void Task2_25() 
        {
            int len = 10;
            int[] mas1 = new int[len];
            int[] mas2 = new int[len];
            int[] mas_res = new int[len*2];
            Random rand = new Random();

            for (int i = 0; i < len; ++i)
            {
                mas1[i] = rand.Next(-100, 100);
            }
            Array.Sort(mas1);

            for (int i = 0; i < len; ++i)
            {
                mas2[i] = rand.Next(-100, 100);
            }
            Array.Sort(mas2);

            int k = 0, j = 0, res = 0;
            while (k < len && j < len)
            {
                if (mas1[k] == mas2[j])
                {
                    mas_res[res] = mas1[k];
                    mas_res[res + 1] = mas2[j];
                    res += 2;
                    k++;
                    j++;

                }
                else if (mas1[k] < mas2[j])
                {
                    mas_res[res]= mas1[k];
                    res++;
                    k++;
                }
                else if (mas1[k] > mas2[j])
                {
                    mas_res[res] = mas2[j];
                    res++;
                    j++;
                }
            }

            if (k == len)
            {
                while (j < len)
                {
                    mas_res[res] = mas2[j];
                    res++;
                    j++;
                }
            }

            if (j == len)
            {
                while (k < len)
                {
                    mas_res[res] = mas1[k];
                    res++;
                    k++;
                }
            }

            Console.Write("mas1:");
            foreach (int i in mas1)
            { Console.Write($"{i}, "); }
            Console.WriteLine();

            Console.Write("mas2:");
            foreach (int i in mas2)
            { Console.Write($"{i}, "); }
            Console.WriteLine();

            Console.Write("mas_res:");
            foreach (int i in mas_res)
            { Console.Write($"{i}, "); }
            Console.WriteLine();

        }

        //Дан массив из n элементов.Переставьте его элементы случайным образом.
        public void Task2_26() 
        {
            int len = 10;
            int[] mas = new int[len];
            Random rand = new Random();
            int a = 0, b = 0, c =0;

            for (int i = 0; i < len; ++i)
            {
                mas[i] = rand.Next(-100,100) ;
            }
            
            foreach (int i in mas)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            for (int i = 0; i < 100; ++i)
            {
                a = rand.Next(0,len);
                b = rand.Next(0,len);

                c = mas[a];
                mas[a] = mas[b];
                mas[b] = c;
            }

            foreach (int i in mas)
            {
                Console.Write($"{i}, ");
            }
        }

        //Дан массив.Осуществите циклический сдвиг массив на k единиц вправо,
        //если первый наименьший элемент массива расположен раньше последнего наибольшего элемента массива, и влево, если иначе
        public void Task2_27() 
        {
            int l = 10;
            int[] mas = new int[l];
            int[] mas_new = new int[l];
            int k = 5;
            int min =0, max = 0, min_index = 0, max_index = 0;

            Random rand = new Random();

            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(0, 100);
            }

            for (int i = 0; i < l; ++i)
            {
                if (min > mas[i]) 
                {
                    min = mas[i];
                    min_index = i;
                }

                if (mas[i] >= max)
                {
                    max = mas[i];
                    max_index = i;
                }
            }

            if (min_index < max_index)
            {
                for (int i = 0; i < l; ++i)
                {
                    if (i + k < l)
                    {
                        mas_new[i] = mas[i + k];
                    }
                    else
                    {
                        mas_new[i] = mas[i + k - l];
                    }
                }
            }
            else 
            {
                for (int i = 0; i < l; ++i)
                {
                    if (i - k >= 0)
                    {
                        mas_new[i] = mas[i - k];
                    }
                    else
                    {
                        mas_new[i] = mas[i + l - k];
                    }
                }
            }

            foreach (int i in mas)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            foreach (int i in mas_new)
            {
                Console.Write($"{i}, ");
            }

        }

        //Дан массив и число p. Найдите два различных числа в массиве, сумма которых наиболее близка к p. 
        public void Task2_28() 
        {
            int l = 10;
            int[] mas = new int[l];
            int p = 6;
            int rast = 20;
            int ind_1 = 0, ind_2 = 0, k = 0;

            Random rand = new Random();

            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(0,10);
            }

            

            for (int i = 0; i < l; ++i)
            {
                for (int j = i+1; j < l; ++j)
                {
                    if (mas[i] != mas[j])
                    { 
                        k = Math.Abs(mas[i] + mas[j]-p);
                        if (k < rast)
                        {
                            rast = k;
                            ind_1 = i;
                            ind_2 = j;
                        }
                    }
                }
            }
            foreach (int i in mas)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine($"num_1 = {mas[ind_1]}, num_2 = {mas[ind_2]}");
        }

        //Найдите количество элементов массива, которые отличны от наибольшего элемента не более чем на 10%. 
        public void Task2_29() 
        {
            int l = 10;
            int[] mas = new int[l];
            Random rand = new Random();
            int max = 0, count = 0, k = 0;

            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(0, 100);
            }

            for (int i = 0; i < l; ++i)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                }
            }
            k = max / 10;
            for (int i = 0; i < l; ++i)
            {
                if ((mas[i] > max - k) && (mas[i] < max + k))
                    count++;
            }
            foreach (int i in mas)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine($"max = {max}, count = {count-1}");

        }

        //Выполните сортировку массива следующими тремя способами:
        //сортировка пузырьком, сортировкой выбором, сортировкой вставками.
        public void Task2_30() 
        {
            int l = 10;
            int[] mas = new int[l];
            Random rand = new Random();

            for (int i = 0; i < l; ++i)
            {
                mas[i] = rand.Next(0, 100);
            }

            foreach (int i in mas)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            int[] mas_bubbles = new int[l];
            Array.Copy(mas,mas_bubbles,l);
            Sort_bubble(mas_bubbles, l);

            Console.WriteLine("Bubbles:");
            foreach (int i in mas_bubbles)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            int[] mas_choice = new int[l];
            Array.Copy(mas, mas_choice, l);
            Sort_choice(mas_choice, l);

            Console.WriteLine("Choice:");
            foreach (int i in mas_choice)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            
            int[] mas_insert = new int[l];
            Array.Copy(mas, mas_insert, l);
            Sort_insert(mas_insert, l);

            Console.WriteLine("Insert:");
            foreach (int i in mas_insert)
            {
                Console.Write($"{i}, ");
            }



        }
        //сортировка пузырьком
        public void Sort_bubble(int[] mas, int l) 
        {
            int b = 0;
            for (int i = 0; i < l; ++i)
            {
                for (int j = 0; j < l-1-i; ++j)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        b = mas[j];
                        mas[j] = mas[j+1];
                        mas[j + 1] = b;
                    }
                }
            }
        }
        //сортировка вставками
        public void Sort_insert(int[] mas, int l)
        {
            int j = 0, k = 0;

            for (int i =1;i<l; ++i) 
            {
                j = i;
                while ((j > 0) && (mas[j] < mas[j - 1]))
                {
                    k = mas[j - 1];
                    mas[j-1] = mas[j];
                    mas[j] = k;
                    j--;
                }
            }
        }
        // сортировка выбором
        public void Sort_choice(int[] mas, int l)
        {
            int min = 0, k = 0, t = 0;

            for (int i = 0; i < l - 1; ++i)
            {
                min = mas[i];
                k = i;
                for (int j = i + 1; j < l; ++j)
                {
                    if (mas[j] < min)
                    {
                        min = mas[j];
                        k = j;
                    }
                }

                if (k != i)
                {
                    t = mas[i];
                    mas[i] = mas[k];
                    mas[k] = t;
                }

            }
        }


    }
}
