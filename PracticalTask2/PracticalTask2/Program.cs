using System;

namespace Task1
{

    class Task1
    {
        public static void Main()
        {
            Task11 task = new Task11();
            task.W();
            Console.ReadKey();
        }
        class Task11
        {
            int x = 1, y = 1;
            public void W()
            {
                Console.WriteLine("Введите число: ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
                Q(n);
            }
            public void Q(int n)
            {
                for (int i = 1; i < n; i++)
                {
                    Console.Write(x);
                    for (int j = n - i; j > 1; j--)
                    {
                        Console.Write(" + 1");
                    }
                    Console.Write(" + " + y);
                    Console.WriteLine();
                    y++;
                }
                y = x + 1;
                x++;
                if (n > 0)
                {
                    Q(n - 2);
                }

            }
        }
    }
}