using System;

namespace Task3
{
    class Task3
    {
        public static bool Q(string str)
        {
            if (str.Length == 1 || str.Length == 0)
            {
                return true;
            }
            if (str[0] != str[str.Length - 1])
            {
                return false;
            }
            return Q(str.Substring(1, str.Length - 2));
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на проверку палидрома: ");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Q(str));
            Console.ReadKey();
        }
    }
}