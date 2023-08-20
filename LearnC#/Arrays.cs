﻿using System;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            task_18();
            Console.ReadLine();
        }

        //Заполнить массив числами от 1 до n
        static void task_1()
        {
            int length = 10;
            int[] mas = new int[length];

            for (int i = 0; i < length; i++)
            {
                mas[i] = i + 1;
            }

            Console.WriteLine($"Array of numbers from 1 to n: ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{mas[i]}");
            }
        }

        //Заполнить массив нулями, кроме первого и последнего элементов, которые должны быть равны единице
        static void task_2()
        {
            int length = 10;
            int[] mas = new int[length];

            for (int i = 0; i < length; i++)
            {
                mas[i] = 0;
            }
            mas[0] = 1;
            mas[length - 1] = 1;

            Console.WriteLine($"Array: ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{mas[i]}");
            }
        }

        //Заполнить массив нулями и единицами, при этом данные значения чередуются, начиная с нуля
        static void task_3()
        {
            int length = 10;
            int[] mas = new int[length];

            for (int i = 0; i < length; i++)
            {
                mas[i] = i % 2;
            }

            Console.WriteLine($"Array: ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }

        //Заполнить массив последовательными нечетными числами, начиная с единицы
        static void task_4()
        {
            int length = 10;
            int[] mas = new int[length];
            int first = 1;

            for (int i = 0; i < length; i++)
            {
                mas[i] = first;
                first += 2;
            }

            Console.WriteLine($"An array of odd elements: ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }

        //Сформировать возрастающий массив из четных чисел
        static void task_5()
        {
            int n = 10;
            int[] mas = new int[n];
            int first = 2;

            for (int i = 0; i < n; i++)
            {
                mas[i] = first;
                first += 2;
            }
            Console.WriteLine($"An array of even elements: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }

        //Создать массив, каждый элемент которого равен квадрату своего номера
        static void task_6()
        {
            int length = 15;
            int[] mas = new int[length];

            for (int i = 0; i < length; i++)
            {
                mas[i] = i * i;
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i}^2= {mas[i]}");
            }
        }

        //Создать массив, состоящий из троек подряд идущих одинаковых элементов
        static void task_7()
        {
            int[] triplets = new int[10];
            for (int i = 0; i < triplets.Length - 2; i += 3)
            {
                triplets[i] = i / 3 + 1;
                triplets[i + 1] = i / 3 + 1;
                triplets[i + 2] = i / 3 + 1;
                Console.WriteLine($"{triplets[i]} {triplets[i + 1]} {triplets[i + 2]}");
            }
        }

        //Найти количество четных чисел в массиве
        static void task_12()
        {
            int length = 15;
            int[] mas = new int[length];
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                    counter++;
            }
            Console.WriteLine($"Array: ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine($"The number of even elements in the array = {counter}");
        }

        //Найти количество чисел в массиве, которые делятся на 3, но не делятся на 7
        static void task_13()
        {
            int[] mas = new int[30];
            int counter = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 3 == 0 && mas[i] % 7 != 0) counter++;
            }
            Console.WriteLine($"The numbers of elements in the array that are divisible by 3 and not divisible by 7 = {counter}");
        }

        //Найдите сумму чисел массива, которые стоят на четных местах
        static void task_14()
        {



        }

        //Найдите наименьший четный элемент массива
        static void task_15()
        {
            int[] mas = new int[10];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-100, 100);
            }

            int min = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
                if (mas[i] % 2 == 0 && min > mas[i]) min = mas[i];
            }
            Console.WriteLine($"min = {min}");
        }

        //Переставить элементы массива в обратном порядке
        static void task_18()
        {
            Console.Write($"Enter the number of array elements: ");
            int amountOfElements = int.Parse(Console.ReadLine());
            int[] mas = new int[amountOfElements];
            Random rand = new Random();

            for (int i = mas.Length; i >= 0; i--)
            {
                mas[i] = rand.Next(-50, 50);
                Console.WriteLine($"{mas[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
            {
                amountOfElements += mas[i];
                Console.WriteLine($"{mas[i]}");
            }
        }

        //В данном массиве найти максимальное количество одинаковых элементов
        static void task_20()
        {
            int[] mas = new int[10];
            Random rand = new Random();
            for (int i = 0; i <= mas.Length; i++)
            {
                mas[i] = rand.Next(-10, 10);
                Console.WriteLine($"{mas[i]}");
            }
        }

    }
}

