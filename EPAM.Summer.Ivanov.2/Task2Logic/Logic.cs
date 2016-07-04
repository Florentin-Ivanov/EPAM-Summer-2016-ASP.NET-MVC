using System;
using System.Diagnostics;

namespace Task2Logic
{
    public class Algorithm
    {
        public static int Euclidean(int a, int b, ref Stopwatch stopWatch)
        {
            //stopWatch.Reset();
            stopWatch.Start();
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            stopWatch.Stop();
            return a;

        }
        public static int Euclidean(ref Stopwatch stopWatch, params int[] array)
        {
            int k = Euclidean(array[0], array[1], ref stopWatch);
            for (int i = 2; i < array.Length; i++)
                k = Euclidean(k, array[i], ref stopWatch);
            return k;
        }
        public static int Stein(int a, int b, ref Stopwatch stopWatch)
        {
            //stopWatch.Reset();
            if ((a < 0) || (b < 0))
                throw new FormatException("There are can't be a 0 values");
            stopWatch.Start();
            if (a == 0)
            {
                stopWatch.Stop();
                return b;
            }
            if ((b == 0) || (a == b))
            {
                stopWatch.Stop();
                return a;
            }
            if ((a % 2 == 0) && (b % 2 == 0))
                return 2 * Stein(a / 2, b / 2, ref stopWatch);
            if (a % 2 == 0)
                return Stein(a / 2, b, ref stopWatch);
            if (b % 2 == 0)
                return Stein(a, b / 2, ref stopWatch);
            if (a > b)
                return Stein((a - b) / 2, b, ref stopWatch);
            else
                return Stein(a, (b - a) / 2, ref stopWatch);

        }
        public static int Stein(ref Stopwatch stopWatch, params int[] array)
        {
            int k = Stein(array[0], array[1], ref stopWatch);
            for (int i = 2; i < array.Length; i++)
                k = Euclidean(k, array[i], ref stopWatch);
            return k;
        }
        public static string stopWatchOut(Stopwatch stopWatch)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:0000000}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 10000);
            return elapsedTime;
        }
    }
}
