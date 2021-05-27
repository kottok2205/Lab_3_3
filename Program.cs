using System;
using System.Threading;

namespace Lab_3_3_
{
    class Program
    {
        static void Go(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new Thread(Go);
            t.Name = "Потоки" + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }
        private static void Main(string[] args)
        {
            Go(10);
            Console.ReadKey();
        }
    }
}
