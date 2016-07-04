using System;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 0.5;
            double eps = 0.01;
            double degree = 4;
            Console.WriteLine("Custom method value = {0}, \nMath.Pow value = {1}", Logic.RecordRoot(value, eps, degree), Math.Pow(value, 1 / degree));
            Console.ReadKey();
        }
    }
}
