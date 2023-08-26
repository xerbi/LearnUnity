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

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(2, 100000);
            }
            do
            {
                int k = random.Next(nums.Length);
                int j = random.Next(nums.Length);
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
            
        }
    }
}
