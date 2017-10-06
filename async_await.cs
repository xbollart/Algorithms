using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            LongProcess();
            Console.WriteLine("Stop");
            Console.ReadLine();
        }

        private static async void LongProcess()
        {
            Console.WriteLine("enter in async method");
            await Test();
            Console.WriteLine("leave async method");
        }

        public static Task Test()
        {
            return Task.Run(() =>{Thread.Sleep(5000);});
        }
    }
}
