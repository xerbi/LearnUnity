using System;
using System.ComponentModel.Design;

namespace LearnC_.Asya
{
    internal class Conditional
    {
        //1) Даны натуральные числа а, b. Вычислить произведение a · b,
        //используя в программе лишь операции +, -, =, <>.
        public void Task3_1()
        {
            Random rand = new Random();
            int a = rand.Next(1,100);
            int b = rand.Next(1,100);
            int res = 0;

            if (a >= b)
            {
                for (int i = 0; i < b; ++i)
                {
                    res += a; 
                }
            }
            else 
            {
                for (int i = 0; i < a; ++i)
                {
                    res += b;
                }
            }
            Console.WriteLine($"{a} * {b} = {res}");
        }
        //2) Даны два различных вещественных числа. Определить:
            //а) какое из них больше;
            //б) какое из них меньше.
        public void Task3_2() 
        {
            float a = 0, b = 0;
            Console.Write("Enter number a (with ','): ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Enter number b (with ','): ");
            b = float.Parse(Console.ReadLine());

            if (a > b) Console.WriteLine($"{a} > {b}");
            else if (a < b) Console.WriteLine($"{a} < {b}");
            else Console.WriteLine($"{a} = {b}");
        }

        //3) Дано натуральное число. Определить:
        //а) является ли оно четным;
        //б) оканчивается ли оно цифрой 7.
        public void Task3_3()
        {
            uint a = 0;
            Console.Write("Enter a: ");
            a = uint.Parse(Console.ReadLine());

            if (a % 2 == 0) Console.Write($"{a} - четное");
            else Console.Write($"{a} - нечетное");

            if (a % 10 == 7) Console.WriteLine($" и оканчивается на 7");
            else Console.WriteLine($" и не оканчивается на 7");
        }

        //4) Дано двузначное число. Определить:
        //а) является ли сумма его цифр двузначным числом;
        //б) больше ли числа а сумма его цифр.
        public void Task3_4()
        {
            uint num = 0;
            Console.Write("Enter two-digit number: ");
            num = uint.Parse(Console.ReadLine());

            uint sum = (num % 10) + (num / 10);
            if (sum / 10 != 0 || sum == 10) Console.WriteLine($"a) Сумма цифр числа {num} - двузначное число");
            else Console.WriteLine($"a) Сумма цифр числа {num} - цифра");

            if (sum > num) Console.WriteLine($"б) Сумма {sum} > числа {num}");
            else Console.WriteLine($"б) Сумма {sum} <= числа {num}");
        }

        //5) Дано трехзначное число. Определить, какая из его цифр больше:
        //а) первая или последняя;
        //б) первая или вторая;
        //в) вторая или последняя.
        public void Task3_5()
        {
            uint num = 0;
            Console.Write("Enter three-digit number: ");
            num = uint.Parse(Console.ReadLine());

            uint first = num / 100;
            uint second = (num % 100) /10;
            uint third = num % 10;

            if (first > third) Console.WriteLine($"а) {first} > {third}");
            else Console.WriteLine($"а) {first} <= {third}");

            if (first > second) Console.WriteLine($"б) {first} > {second}");
            else Console.WriteLine($"б) {first} <= {second}");

            if (second > third) Console.WriteLine($"в) {second} > {third}");
            else Console.WriteLine($"в) {second} <= {third}");
        }

        //6) Дано натуральное число.
        //а) Верно ли, что оно заканчивается четной цифрой?
        //б) Верно ли, что оно заканчивается нечетной цифрой?
        public void Task3_6()
        {
            uint num = 0;
            Console.Write("Enter number: ");
            num = uint.Parse(Console.ReadLine());

            uint last = num %10;

            if (last % 2 == 0) Console.WriteLine($"{last} - четная цифра");
            else Console.WriteLine($"{last} - нечетная цифра");
        }
        //7) Дано трехзначное число.
        //а) Верно ли, что все его цифры одинаковые?
        //б) Определить, есть ли среди его цифр одинаковые.
        public void Task3_7()
        {
            uint num = 0;
            Console.Write("Enter three-digit number: ");
            num = uint.Parse(Console.ReadLine());

            uint first = num / 100;
            uint second = (num % 100) / 10;
            uint third = num % 10;

            Console.WriteLine("а) Верно ли, что все его цифры одинаковые?");
            Console.WriteLine("б) Определить, есть ли среди его цифр одинаковые.");
            Console.WriteLine();

            if ((first == second) && (second == third)) Console.WriteLine($"а) верно; ");
            else Console.WriteLine($"а) неверно;");

            if ((first == second) || (first == third) || (second == third)) Console.WriteLine($"б) есть.");
            else Console.WriteLine($"б) нет.");
        }
    }
}
