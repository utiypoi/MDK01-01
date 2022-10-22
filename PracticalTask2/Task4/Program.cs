using System;
using System.Threading.Tasks;

namespace Task4
{

    class Task4
    {
        public static void Main()
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine(Str(str));
            Console.ReadKey();
        }
        public static bool Str(string str)
        {
            int count = 0;
            char skbL = '(';
            char skbR = ')';
            char[] arrStr = str.ToCharArray();
            for (int i = 0; i <= arrStr.Length-1; i++) {
                char c = arrStr[i];
                if (c == skbL) {
                    count++;
                }
                else if (c == skbR){
                    count--;
                }else {
                    i++;
                }
            }
            if (count == 0) return true;
            else return false;
        }
    }
}