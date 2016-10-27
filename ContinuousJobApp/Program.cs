using System;
using System.Threading;

namespace ContinuousJobApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = 10;
            Console.WriteLine("Begin sleep {0}s ..", sec);
            Thread.Sleep(sec * 1000);
            Console.WriteLine("End sleep {0}s ..", sec);
        }
    }
}
