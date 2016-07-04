using System;
using System.Diagnostics;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine(Algorithm.Euclidean(206171067, 412342134, ref stopWatch).ToString());
            Console.WriteLine(Algorithm.Euclidean(ref stopWatch, 124, 124356, 2344212));
            Console.WriteLine("Euclidean Algorithm RunTime = " + Algorithm.stopWatchOut(stopWatch));
            stopWatch.Reset();
            Console.WriteLine(Algorithm.Stein(206171067, 412342134, ref stopWatch).ToString());
            Console.WriteLine(Algorithm.Stein(ref stopWatch, 124, 124356, 2344212));
            Console.WriteLine("Stein Algorithm RunTime = " + Algorithm.stopWatchOut(stopWatch));
            Console.ReadKey();
        }
    }
}
