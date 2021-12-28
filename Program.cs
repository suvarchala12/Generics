using System;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find MAximum number between Three!");
            MaxNumbers maxNumbers = new MaxNumbers();
            maxNumbers.MaxInt();
            maxNumbers.Show();
            double doubleoutput = MaxNumbers.MaximumFloatNumber(11.7, 26.47, 70.56);
            Console.WriteLine(doubleoutput);
        }
    }
}