using System;

namespace Task2
{
    class Task2
    {
        public static bool Q(int n, int i)
        {
            if (n < 2)
            {
                return false;
            }
            else if (n == 2)
            {
                return true;
            }
            else if (n % i == 0)
            {
                return false;
            }
            else if (i < n / 2)
            {
                return Q(n, i + 1);
            }
            else
            {
                return true;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число N>1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Q(n, 2));
            Console.ReadKey();
        }
    }
}