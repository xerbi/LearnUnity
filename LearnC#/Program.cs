namespace LearnC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Sum = {summ(a, b)}");
        }

        static int summ(int a, int b)
        {
            return a + b;
        }
    }
}