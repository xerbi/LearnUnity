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

            string str = a.ToString();
            char lastChar = str[str.Length - 1];
            if (lastChar == '7') Console.WriteLine($"The number ends with 7");
            else Console.WriteLine($"The number doesn't end with 7");
        }

        //Дано двузначное число.Определить:     а) является ли сумма его цифр двузначным числом;     б) больше ли числа а сумма его цифр.
        public static void task_4()
        {
            Console.Write("Enter a two-digit number: ");
            int num; 
            num = int.Parse(Console.ReadLine());

            int tens = num / 10;
            int ones = num % 10;
            int sum = tens + ones;
            Console.WriteLine($"\nSum of numbers = {sum}");
            if (sum > 10) Console.WriteLine($"The sum of the numbers {num} is a two-digit number");
            else Console.WriteLine($"The sum of the numbers {num} is not a two-digit number");
        }

        //Дано трехзначное число. Определить, какая из его цифр больше: а) первая или последняя;   б) первая или вторая;    в) вторая или последняя
        public static void task_5()
        {
            Console.Write("Enter a three-digit number: ");
            int num;
            num = int.Parse(Console.ReadLine());
            string numStr = num.ToString();

            char firstDigit = numStr[0];
            char secondDigit = numStr[1];
            char thirdDigit = numStr[2];

            if (firstDigit > thirdDigit) Console.WriteLine("The first digit is larger than the third");
            else if (firstDigit < thirdDigit) Console.WriteLine("The first digit is smaller than the third");
            else Console.WriteLine("The first digit is equal to the third");

            if (firstDigit > secondDigit) Console.WriteLine("The first digit is larger than the second");
            else if (firstDigit < secondDigit) Console.WriteLine("The first digit is smaller than the second");
            else Console.WriteLine("The first digit is equal to the second");

            if (secondDigit > thirdDigit) Console.WriteLine("The second digit is larger than the third");
            else if (secondDigit < thirdDigit) Console.WriteLine("The second digit is smaller than the third");
            else Console.WriteLine("The second digit is equal to the second third");
        }

        //Дано натуральное число. а) Верно ли, что оно заканчивается четной цифрой?   б) Верно ли, что оно заканчивается нечетной цифрой?
        public static void task_6()
        {
            Console.Write("Enter a natural number: ");
            int num = int.Parse(Console.ReadLine());
            string number = num.ToString();
            int lastDigit = int.Parse(number[number.Length - 1].ToString());

            if (lastDigit % 2 == 0) Console.WriteLine("\nLast dight is even");
            if (lastDigit % 2 != 0) Console.WriteLine("\nLast dight is odd");
        }      
    }
}
