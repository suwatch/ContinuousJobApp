using System;
using System.Threading;

namespace ContinuousJobApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 10;
            Console.WriteLine("Begin Run");
            while (--loop > 0)
            {
                Console.WriteLine("Loop {0}", loop);
                Thread.Sleep(30000);
            }
            Console.WriteLine("End Run");
        }
    }
}
