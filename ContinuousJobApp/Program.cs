using System;
using System.IO;
using System.Threading;

namespace ContinuousJobApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shutdownFile = Environment.GetEnvironmentVariable("WEBJOBS_SHUTDOWN_FILE");
            int loop = 10;
            Console.WriteLine("Begin Run");
            while (--loop > 0)
            {
                Console.WriteLine("Loop {0}", loop);
                for (int i = 0; i < 6; ++i)
                {
                    Thread.Sleep(5000);
                    if (File.Exists(shutdownFile))
                    {
                        Console.WriteLine("Shutdown file exists {0}", shutdownFile);
                        break;
                    }
                }
            }
            Console.WriteLine("End Run");
        }
    }
}
