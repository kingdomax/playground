using System;
using System.Diagnostics;

namespace MochPlayGround.CostOfNew
{
    public class CostOfNewObject
    {
        public void Test()
        {
            var sum = 0.0D;

            for (var i = 0; i < 10000000; i++)
            {
                var time = Stopwatch.StartNew();
                new SomeObjectWithFields();
                time.Stop();

                sum += time.Elapsed.TotalMilliseconds;

                if (i % 1000 == 0)
                {
                    Console.WriteLine($"Total = {sum} of {i} requests, average ms = {sum / (double)i}");
                }
            }

        }

        public class SomeObjectWithFields
        {
            public int IntValue { get; set; }

            public string StringValue { get; set; }

            public DateTime DateValue { get; set; }
        }
    }
}
