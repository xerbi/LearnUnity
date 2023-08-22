using System;

namespace TaskForStatements
{
    class TaskStatements
    {
        //Даны натуральные числа а, b. Вычислить произведение a · b, используя в программе лишь операции +, -, =, <>
        public static void task_1()
        {
            Console.WriteLine($"Enter a number a:");
            int a;
            a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter a number b:");
            int b;
            b = int.Parse(Console.ReadLine());

            int result = a * b;
            Console.Write($"a * b = {result}");
        }


        //Даны два различных вещественных числа.Определить:    а) какое из них больше;     б) какое из них меньше.
        public static void task_2()
        {
            Console.WriteLine($"Enter a number a:");
            float a;
            a = float.Parse(Console.ReadLine());

            Console.WriteLine($"Enter a number b:");
            float b;
            b = float.Parse(Console.ReadLine());

            if (a > b) Console.Write($"{a} > {b}");
            else if (a < b) Console.Write($"{a} < {b}");
            else Console.Write($"{a} = {b}");
        }


        //Дано натуральное число.Определить:     а) является ли оно четным;     б) оканчивается ли оно цифрой 7.
        public static void task_3()
        {
            Console.WriteLine($"Enter a number a:");
            int a;
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0) Console.Write($"The number a is even");
            else Console.Write($"The number a is odd");

            Console.WriteLine();

            string stra = a.ToString();
            char lastChar = stra[stra.Length - 1];
            if (lastChar == '7') Console.WriteLine($"The number ends with 7");
            else Console.WriteLine($"The number doesn't end with 7");
        }


        //Дано двузначное число.Определить:     а) является ли сумма его цифр двузначным числом;     б) больше ли числа а сумма его цифр.
        public static void task_4()
        {

        }
    }
}
