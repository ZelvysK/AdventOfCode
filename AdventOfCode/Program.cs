using System;
using System.IO;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("Data.txt");

            int[] arr = Array.ConvertAll(data, s => int.Parse(s));

            var count = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);


            var dataN = File.ReadAllLines("Datan.txt");

            int[] arrN = Array.ConvertAll(dataN, s => int.Parse(s));

            var countN = 0;

            var temp = arrN[0] + arrN[1] + arrN[2];
            for (int i = 1; i < dataN.Length-2; i++)
            {
                var sum = arrN[i + 0] + arrN[i + 1] + arrN[i + 2];
                if (sum - temp > 0)
                {
                    countN++;
                }
                temp = sum;
            }

            Console.WriteLine(countN);
        }
    }
}
