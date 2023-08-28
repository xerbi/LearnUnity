using System.Data;
using System.Drawing;

namespace LearnC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FirstTasks tasks = new FirstTasks();       
            //tasks.Task1_20();

            Arrays arrays = new Arrays();
            arrays.Task2_18();


        }
     /*
        

            ShowArray(arr);
        }//static void RandomMassive_v1(int size = 10)

        /*
         * Дано трехзначное число.
         *   а) Верно ли, что все его цифры одинаковые?
         *   б) Определить, есть ли среди его цифр одинаковы
         */
        /*
        static void LogicTask1(int number = 919)
        {
            string str = number.ToString();

            int i = 0;
            int size = str.Length;
            for (i = 1; i < size; i++)
            {
                if (str[i] != str[i - 1]) break;
            }

            //а) Верно ли, что все его цифры одинаковые?
            if (i != size) Console.WriteLine("Верно ли, что все его цифры одинаковые? НЕТ");
            else Console.WriteLine("Верно ли, что все его цифры одинаковые? ДА");

            //б) Определить, есть ли среди его цифр одинаковы
            int counter = 0;
            for (i = 0; i < size; i++)
            {
               for (int j = 1; j < size; ++j)
                {
                    if (str[i] == str[j]) break; 
                }
            }
        }*/ 
    }
}