using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.loggly;
using log4net;
using System.Threading;

namespace CalculateThroughput
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LogManager.GetLogger(typeof(Program));
            Timer t = new Timer(printLogStatus, null, 0, 10000);
            for (int i = 0; i < 20; i++)
            {
                logger.Info(i + ":   Hi to all Serialization using Json.NET is even easier. In this next sample, a Dictionary of strings (similar to the one used above for deserialization) is declared and then serialized to JSON format.");
                Thread.Sleep(5 * 1000);
            }

            Console.ReadKey();

        }
        static void printLogStatus(Object o)
        {
            Console.WriteLine(LogglyClient.logStatus());
            GC.Collect();
        }

    }
}
