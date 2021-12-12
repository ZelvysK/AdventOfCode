using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode4
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("Prefab.txt");

            var drawnNumbers = data[0].Split(",", data[0].Length);
            Console.WriteLine($"Drawn numbers are:\n{string.Join(" ", drawnNumbers)}\n\n");

            for (int i = 2; i < data.Length; i++)
            {
                Console.WriteLine($"Nums: {data[i]}");
                if (i%6 == 0)
                {
                    Console.WriteLine("\n       B  I  N  G  O \n");
                    i++;
                }
            }
        }
    }
}
