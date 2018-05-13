using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostOfNew2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;

            for(var i = 0; i < 10000000; i++)
            {
                var w = Stopwatch.StartNew();
                var x = new SomeObjectWithFields();
                w.Stop();

                sum += w.Elapsed.TotalMilliseconds;
                
                if(i % 1000 == 0)
                {
                    Console.WriteLine($"Total = {sum} of {i} requests, average ms = {sum / (double)i}");
                }
            }
        }
    }
}
