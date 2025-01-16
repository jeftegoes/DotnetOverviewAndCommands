using System;
using System.Threading.Tasks;

namespace SimpleExampleAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start async call...");
            Method1();
            Method2();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine("Method 1");
                    Task.Delay(100).Wait();
                }
            });
        }
        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 2");
                Task.Delay(100).Wait();
            }
        }
    }
}
